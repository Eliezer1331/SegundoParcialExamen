using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        FrmPedidos frmPedidos= null;
        FrmProductos frmProductos = null;
         
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (frmPedidos == null)
            {
                frmPedidos = new FrmPedidos();
                frmPedidos.MdiParent = this;
               frmPedidos.FormClosed += FrmPedidos_FormClosed;
                frmPedidos.Show();
            }
            else
            {
                frmPedidos.Activate();
            }
        }
        private void FrmPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPedidos = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (frmProductos == null)
            {
                frmProductos  = new FrmProductos();
                frmProductos.MdiParent = this;
                frmProductos.FormClosed += FrmProductos_FormClosed;
                frmProductos.Show();
            }
            else
            {
                frmProductos.Activate();
            }
            
        }
        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProductos = null;
        }
    }
}
