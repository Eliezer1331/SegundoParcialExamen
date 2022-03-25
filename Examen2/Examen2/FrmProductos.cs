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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;
        DAProducto DAproducto = new DAProducto();
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
        }
       
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el codigo");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese una descripcion");
                    NombreTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CantidadTextBox.Text))
                {
                    errorProvider1.SetError(CantidadTextBox, "Ingrese un precio");
                    CantidadTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese una existencia");
                    PrecioTextBox.Focus();
                    return;
                }
                Producto producto = new Producto();
                producto.Codigo = CodigoTextBox.Text;
                producto.NombreProducto = NombreTextBox.Text;
                producto.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);



                if (operacion == "Nuevo")
                {
                    bool inserto = DAproducto.InsertarProducto(producto);

                    if (inserto)
                    {
                       
                        ListarProductos();
                        MessageBox.Show("Producto ingresado");
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void ListarProductos()
        {
            ListaProductoDataGridView.DataSource = DAproducto.ListarProductos();
        }

    }
}
