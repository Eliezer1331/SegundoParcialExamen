using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        DAPedidos DApedidos = new DAPedidos();
        Pedidos  pedidos = new Pedidos();
        //Producto producto;

        

        //decimal subtotal = decimal.Zero;
        //decimal TotalAPagar = decimal.Zero;
        string operacion = string.Empty;

        private void HacerPedidoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IdTextBox.Text))
                {
                    errorProvider1.SetError(IdTextBox, "Ingrese el codigo");
                    IdTextBox.Focus();
                    return;
                }
              
                if (string.IsNullOrEmpty(NombreClienteTextBox.Text))
                {
                    errorProvider1.SetError(NombreClienteTextBox, "Ingrese el nombre del cliente");
                    NombreClienteTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ProductoTextBox.Text))
                {
                    errorProvider1.SetError(ProductoTextBox, "Ingrese el nombre del producto");
                    ProductoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese el precio del producto");
                    PrecioTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CantidadTextBox.Text))
                {
                    errorProvider1.SetError(CantidadTextBox, "Ingrese la cantidad");
                    CantidadTextBox.Focus();
                    return;
                }
               
                Pedidos pedidos = new Pedidos();
                pedidos.Id =Convert.ToInt32( IdTextBox.Text);
                pedidos.NombreCliente = NombreClienteTextBox.Text;
                pedidos.NombreProducto = ProductoTextBox.Text;
                pedidos.SubTotal = Convert.ToDecimal(PrecioTextBox.Text);
                pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                pedidos.Total = pedidos.SubTotal * Convert.ToInt32(CantidadTextBox.Text);

                if (operacion == "Nuevo")
                {
                    bool inserto = DApedidos.HacerPedido(pedidos);

                    if (inserto)
                    {

                       ListarPedidos();
                        MessageBox.Show("Pedido Realizado");
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void ListarPedidos()
        {
            dataGridView1.DataSource = DApedidos.ListarPedidos();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
        }
    }
    
}
