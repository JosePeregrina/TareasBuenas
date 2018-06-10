using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_circulares
{
    class Base
    {
        private Base _siguiente;
        private int _tiempo;
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _telefono;

        public Base(string Nombre, string Apellido, int Edad, int Telefono, int Tiempo)
        {
            _nombre = Nombre;
            _apellido = Apellido;
            _edad = Edad;
            _telefono = Telefono;
            _tiempo = Tiempo;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public Base Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public override string ToString()
        {
            return _nombre + "," + _apellido + "," + _edad + "," + _telefono + "," +_tiempo;
        }
       public int Tiempo
        {
            get { return _tiempo; }
            set { _tiempo = value; }
        }
    }
}
