using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Procesos
{
    class Procesador
    {
        private Proceso _inicio, extra;
        private string _lista;// ¿La necesitamos?
        private Random random;

        public void Agregar(Proceso nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
            }
            else
                Agregar(_inicio, nuevo);
        }
        private void Agregar(Proceso principio, Proceso nuevo)
        {
            if (principio.Siguiente == null)
            {
                principio.Siguiente = nuevo;
                nuevo.Anterior = principio;
            }
            else
                Agregar(principio.Siguiente, nuevo);
        }
        private void EliminarInicio()
        {
            if (_inicio.Siguiente == null)
            {
                _inicio = null;
            }
            else
            {
                _inicio = _inicio.Siguiente;
                _inicio.Anterior = null;
            }
        }
        public string Procesar()
        { int ciclosHechos = 0, ciclosInconclusos = 0 , ciclosVacios = 0;
            for (int i = 0; i < 300; i++)
            {
                int r = random.Next(1, 101);
                if(r <= 35)//35% de probabilidad de agregar un nuevo proyecto
                {
                    r = random.Next(4, 16);
                    extra = new Proceso(r);
                    Agregar(extra);
                }

                if (_inicio != null)
                {
                    _inicio.Ciclos--;
                    if (_inicio.Ciclos == 0)
                    {
                        EliminarInicio();
                        ciclosHechos++;
                        
                    }
                    else
                        ciclosInconclusos++;
                }
                else
                    ciclosVacios++;
            }
            if(_inicio != null)
            {

            }
            Proceso temp = _inicio;
            while (temp.Siguiente != null)
            {
                if (temp.Ciclos != 0)
                    ciclosVacios += temp.Ciclos;
                temp = temp.Siguiente;
            }
        }
    }
}
}
