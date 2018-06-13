using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_circulares_Procesos
{
    class Procesador
    {
        private Proceso _inicio;
        private Proceso _extra;
        private string _lista;

        public void Agregar(Proceso nuevo)
        {
            if (_inicio == null)
                _inicio = nuevo;
            else
                Agregar(_inicio, nuevo);
        }
        public void Agregar(Proceso principio, Proceso nuevo)
        {
            if(principio.Siguiente == null  || principio.Siguiente == _inicio)
            {
                principio.Siguiente = nuevo;
                nuevo.Siguiente = _inicio;
            }
            else
                Agregar(principio.Siguiente, nuevo);
        }
        public void EliminarPrincipio()
        {
            if (_inicio.Siguiente != null)
                _inicio = null;
            else
            {
                _inicio = _inicio.Siguiente;
            }
        }
        public string Procesar()
        {
            int ciclosHechos = 0;
            int ciclosPendientes = 0;
            int ciclosVacios = 0;
            int procesosPendientes = 0;
            for(int i = 0; i < 10; i++)
            {
                Random r = new Random();
                int n = r.Next(1, 101);
                if(n <= 35)
                {
                    n = r.Next(4, 16);
                    _extra = new Proceso(n);
                    Agregar(_extra);
                }
                if (_inicio != null)
                {
                    if (_inicio.Ciclos == 0)
                    {
                        EliminarPrincipio();
                        ciclosHechos++;
                    }

                    _inicio.Ciclos--;

                }
                else
                    ciclosVacios++;
            }
            Proceso temp = _inicio;
            while (temp.Siguiente != _inicio)
            {
                if(temp.Ciclos != 0)
                {
                    ciclosPendientes++;
                    temp.Ciclos--;
                }
                else
                {
                    procesosPendientes++;
                    temp = temp.Siguiente;
                }

            } 
            _lista = ciclosHechos + "," + ciclosPendientes + "," + ciclosVacios + "," + procesosPendientes;
            return _lista;
        }
    }
}
