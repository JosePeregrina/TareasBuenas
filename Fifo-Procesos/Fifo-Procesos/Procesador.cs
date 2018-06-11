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
        //public string Procesar()
        //{
        //    int ciclosVacio = 0, procesosAtendidos = 0, procesosPendientes = 0, ciclosPendientes = 0;
        //    for (int x = 0; x < 300; x++)
        //    {
        //        int n = random.Next(1, 101);
        //        if (n <= 35)
        //        {
        //            n = .Next(4, 15);
        //            aux = new Proceso(n);
        //            agregarFinal(aux);
        //        }
        //        if (inicio != null)
        //        {
        //            inicio.Ciclos--;// = inicio.Ciclos - 1;
        //            if (inicio.Ciclos == 0)
        //            {
        //                eliminarInicio();
        //                procesosAtendidos++;
        //            }
        //        }
        //        else ciclosVacio++;
        //    }
        //    aux = inicio;
        //    if (inicio != null)
        //        while (aux != null)
        //        {
        //            procesosPendientes++;
        //            ciclosPendientes += aux.Ciclos;
        //            aux = aux.Siguiente;
        //        }
        //    return "Ciclos Vacio: " + ciclosVacio + Environment.NewLine + "Procesos Atendidos: " + procesosAtendidos + Environment.NewLine + "Procesos Pendientes: " + procesosPendientes + Environment.NewLine + "Ciclos Pendientes: " + ciclosPendientes;
        //}
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
