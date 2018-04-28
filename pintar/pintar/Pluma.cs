using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pintar
{
    class Pluma
    {
        private bool _estado;
        public Pluma()
        {
            _estado = false;
        }

        public bool Estado
        {
            set { _estado = value; }
            get { return _estado; }
        }

    }
}
