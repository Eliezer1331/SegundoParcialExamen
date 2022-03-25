using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Producto
    {

        public string Codigo { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string nombreProducto, int cantidad, decimal precio)
        {
            Codigo = codigo;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
