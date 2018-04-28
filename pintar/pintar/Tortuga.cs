using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pintar
{
    class Tortuga
    {
        private int _posicionX;
        private int _posicionY;
        private int _orientacion;
        private int[,] _pintarron;
        private bool _estadoPluma;
        private string _mostrar;
        
        public bool Pluma
        {
            set { _estadoPluma = value; }
            get { return _estadoPluma; }
        }
        public int Orientacion
        {
            get { return _orientacion; }
        }
        public int EjeY
        {
            get { return _posicionY; }
        }
        public int EjeX
        {
            get { return _posicionX; }
        }

        public Tortuga()
        {
            _posicionX = 0;
            _posicionY = 0;
            // 1          2         3      4
            // Arriba  Izquierda  Abajo   Derecha
            _orientacion = 3;
            _pintarron = new int[20, 20];
            _estadoPluma = false;
            //  [Renglones, Columnas]
        }

        public void RotarIzquierda()
        {
            if (_orientacion > 1)
                _orientacion--;
            else
                _orientacion = 4;
        }
        public void RotarDerecha()
        {
            if (_orientacion < 4)
                _orientacion++;
            else
                _orientacion = 1;
        }
        public void Pintar()
        {
                _pintarron[_posicionX, _posicionY] = 1;
        }
        public void Avanzar()
        {
            switch (_orientacion)
            {
                case 1:
                    // Solo se modificara el apartado de renglones (eje Y) de manera decreciente (resta)
                    _posicionY--;
                    break;
                case 2:
                    // Solo se modificara el apartado de las columnas (eje X) de manera decreciente (resta)
                    _posicionX--;
                    break;
                case 3:
                    // Solo se modificara el apartado de los renglones (eje Y) de manera creciente (suma)
                    _posicionY++;
                    break;
                case 4:
                    // Solo se modificara el apartado de las columnas (eje X) de manera creciente (suma)
                    _posicionX++;
                    break;
                default:
                    _mostrar = "ERROR404";
                    break;
            }
        }
        public override string ToString()
        {
            for(int Renglon = 0; Renglon < _pintarron.GetLength(0)-1; Renglon++)
            {
                _mostrar += "\n\r";
                for (int Columna = 0; Columna  < _pintarron.GetLength(1)-1; Columna++)
                {
                    if (_pintarron[Renglon, Columna] != 1)
                    {
                        _pintarron[Renglon, Columna] = 0;
                    }
                    _mostrar += _pintarron[Renglon, Columna] + " ";
                }
                _mostrar += "\n\r";
            }

            return _mostrar;
        }
    }
}
