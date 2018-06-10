using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_circulares
{
    class Agenda
    {
        private Base _inicio;
        private Base _final;
        private string _lista;

        public void Agregar(Base obj)
        {
            if (_inicio == null)
            {
                _inicio = obj;
                _inicio.Siguiente = _inicio;
            }
                
            else
            {
                Agregar(_inicio, obj);
            }
        }
        private void Agregar(Base principio, Base nuevo)
        {
            if (principio.Siguiente == null)
            {
                principio.Siguiente = nuevo;
                nuevo.Siguiente = principio;
                _final = nuevo;
            }
            else if(principio.Siguiente == _inicio)
            {
                principio.Siguiente = nuevo;
                nuevo.Siguiente = _inicio;
            }
            else
                Agregar(principio.Siguiente, nuevo);
        }
        public Base Buscar(string nombre)
        {
            if(_inicio != null)
            {
                if (_inicio.Nombre == nombre)
                    return _inicio;
                else
                {   Base blanco = _inicio;
                    while(blanco.Siguiente != _inicio)
                    {
                        if (blanco.Siguiente.Nombre == nombre)
                            return blanco.Siguiente;
                        blanco = blanco.Siguiente;
                    }
                                return null;
                }
            }
            return _inicio;
            
        }
        private Base BuscarA(string nombre)
        {
            if (_inicio.Nombre == nombre)
                return _final;
            else
            {
                Base temp = _inicio;
                while(temp.Siguiente != _inicio)
                {
                    if (temp.Siguiente.Nombre == nombre)
                        return temp;
                    temp = temp.Siguiente;
                }
                return null;
            }
        }
        public Base Eliminar(string nombre)
        {
            Base ablanco;
            Base blanco;
            ablanco = BuscarA(nombre);
            blanco = Buscar(nombre);
            ablanco.Siguiente = blanco.Siguiente;//eliminamos la conexion a blanco (el nodo que deseamos eliminar)
            return blanco;
        }
        public string Listar()
        {
            _lista = "";
            if (_inicio == null)
                return _lista = "lista vacia";
            else
            {
                _lista += _inicio.ToString();
                if (_inicio.Siguiente != null)
                {
                    Base temp = _inicio;
                    while(temp.Siguiente != _inicio)
                    {
                        _lista += temp.Siguiente.ToString();
                        temp = temp.Siguiente;
                    }
                    return _lista;

                }
                return _lista;
               
            }
        }
       public Base EliminarInicio()
        {
            if(_inicio != null)
            {
                if (_inicio.Siguiente != null)
                {
                    _final.Siguiente = _inicio.Siguiente;
                    _inicio = _final.Siguiente;
                }
                else
                {
                    _inicio = null;
                    return _inicio;
                }
            }
            return null;
           
        }
        public Base EliminarFinal()
        {
            if(_final == _inicio)
            {
                Base x = _inicio;
                _inicio = null;
                return x;
            }
            else
            {
                Base blanco = BuscarA(_final.Nombre);
                blanco.Siguiente = _inicio;
                _final = blanco;
                return blanco;
            }

        }
        public void Insertar(Base obj, int pos)
        {
            if(pos == 1)
            {
                if(_inicio.Siguiente == _inicio)
                {
                    obj.Siguiente = _inicio;
                    _inicio.Siguiente = obj;
                    _inicio = obj;
                }
                else
                {
                    Base temp = _inicio;
                    while (temp.Siguiente != _inicio)
                        temp = temp.Siguiente;

                    obj.Siguiente = _inicio;
                    temp.Siguiente = obj;
                    _inicio = obj;
                }
            }
            else if(pos == 2)
            {
                obj.Siguiente = _inicio.Siguiente;
                _inicio.Siguiente = obj;
            }
            else
            {
                Base temp = _inicio;
                for(int i = 3; i <= pos; i++)
                {
                    temp = temp.Siguiente;
                }
                obj.Siguiente = temp.Siguiente;
                temp.Siguiente = obj;
            }
        }
        public string Ruta(string nombreBase, int horaInicio, int horaFin)
        {   //recibimos la hora de inicio y fin como cantidades de 4 digítos
            Base bi = Buscar(nombreBase);
            if( bi != null)
            {
                _lista = bi.ToString() + horaInicio + horaFin;
                while (horaInicio < horaFin)
                {
                    bi = bi.Siguiente;
                    horaInicio += bi.Tiempo;
                    _lista += bi.Nombre + horaInicio + horaFin + "\n\r";
                }
                return _lista;
            }
            return null;
           
        }
    }
}
