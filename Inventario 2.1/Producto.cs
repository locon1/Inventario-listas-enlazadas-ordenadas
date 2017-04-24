using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_2._1
{
    class Producto
    {
        private int _codigo;
        public int codigo { get { return _codigo; } }
        private string _nombre;
        public string nombre { get { return _nombre; } }
        private int _cantidad;
        public int cantidad { get { return _cantidad; } }
        private int _costo;
        public int costo { get { return _costo; } }
        private Producto _siguiente;
        public Producto siguiente { get { return _siguiente; } set { Producto x = _siguiente; } }

        public Producto(int codigo, string nombre, int cantidad, int costo)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._cantidad = cantidad;
            this._costo = costo;
            this._siguiente = null;
        }

        public override string ToString()
        {
            return "Código: " + Convert.ToString(_codigo) + " | " + "Nombre: " + _nombre + " | " + "Cantidad: " + Convert.ToString(_cantidad) + " | " + "Costo: " + Convert.ToString(_costo) + ".";
        }
    }
}
