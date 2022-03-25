using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            DAUsuario DAusuario = new DAUsuario();
            Usuario usuario = new Usuario();

            usuario = DAusuario.Login(NombreTextBox.Text, ContraseñaTextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("DATOS ERRONEOS.");

                return;
            }


            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            //FrmProductos frmProductos = new FrmProductos();
            //frmProductos.Show();
            this.Hide();
        }
    }
}
