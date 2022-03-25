using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal  { get; set; }
        public decimal Total { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(int id, string nombreCliente, string nombreProducto, int cantidad, decimal subTotal, decimal total)
        {
            Id = id;
            NombreCliente = nombreCliente;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            SubTotal = subTotal;
            Total = total;
        }
    }
}
