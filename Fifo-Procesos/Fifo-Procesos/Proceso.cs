using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Procesos
{
    class Proceso
    {
        private int _ciclos;
        private Proceso _siguiente;
        private Proceso _anterior;

        public Proceso(int Ciclos)
        {
            _ciclos = Ciclos;
        }
        public int Ciclos
        {
            get { return _ciclos; }
            set { _ciclos = value; }
        }
        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Proceso Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }
    }
}
