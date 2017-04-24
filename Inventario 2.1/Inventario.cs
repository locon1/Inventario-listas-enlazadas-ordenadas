using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_2._1
{
    class Inventario
    {
        private Producto primero;
        private int _cont;
        public int cont { get { return _cont; } }

        public Inventario()
        {
            primero = null;
            _cont = 0;
        }

        public void Agregar(Producto nuevo)
        {
            if (primero == null) 
            {
                primero = nuevo;
            }
            else if (nuevo.codigo < primero.codigo) 
            {
                nuevo.siguiente = primero;
            }
            else 
            {
                Producto temp = primero;
                while (temp.siguiente != null) 
                {
                    if (nuevo.codigo < temp.siguiente.codigo) 
                    {
                        Producto x = temp.siguiente;
                        temp.siguiente = nuevo;
                        temp.siguiente.siguiente = x;
                        break;
                    }
                    temp = temp.siguiente;
                }
            }
            _cont++;
        }

        public bool Eliminar(string name)
        {
            if (primero.nombre == name) {
                primero = primero.siguiente;
                return true;
            }
            else {
                Producto temp = primero;
                while (temp.siguiente.nombre != name && temp.siguiente != null) {
                    temp = temp.siguiente;
                }

                if (temp.siguiente.nombre == name) {
                    temp.siguiente = temp.siguiente.siguiente;
                    _cont--;
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public Producto Buscar(string name)
        {
            Producto temp = primero;
            while (temp.nombre != name && temp.siguiente != null) {
                temp = temp.siguiente;
            }

            if (temp.nombre == name) {
                return temp;
            }
            else {
                return null;
            }
        }

        public string Reporte()
        {
            string salida = "Número de productos en el inventario: " + _cont + Environment.NewLine + Environment.NewLine + "Inventario: " + Environment.NewLine + Environment.NewLine;
            Producto temp = primero;
            while (temp != null) {
                salida += temp.ToString() + Environment.NewLine;
                salida += "---------------------------------------------------------------------------" + Environment.NewLine;
                temp = temp.siguiente;
            }
            return salida;
        }
    }
}
