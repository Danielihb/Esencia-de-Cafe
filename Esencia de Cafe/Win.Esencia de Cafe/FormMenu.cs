using BL.Esencia_de_cafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Esencia_de_Cafe;

namespace Win.Esencia_de_Cafe
{
    public partial class FormMenu : Form
    {
        
        public FormMenu()
        {
            InitializeComponent();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var FormLogin = new FormLogin();
            FormLogin.ShowDialog();

            toolStripStatusLabel1.Text = "Usuario: "+ Utilidades.nombreusuario;
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RegistroClientes = new RegistroClientes();
            RegistroClientes.MdiParent = this;
            RegistroClientes.Show();

        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RegistroProductos = new RegistroProductos();
            RegistroProductos.MdiParent = this;
            RegistroProductos.Show();

        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ReporteClientes = new ReporteClientes();
            ReporteClientes.MdiParent = this;
            ReporteClientes.Show();

        }

        private void reportesDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ReporteProductos = new FormReportesProducto();
            ReporteProductos.MdiParent = this;
            ReporteProductos.Show();

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormFacturas = new FormFactura();
            FormFacturas.MdiParent = this;
            FormFacturas.Show();

        }

        private void segridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReporteFacturas = new FormReporteFacturas();
            FormReporteFacturas.MdiParent = this;
            FormReporteFacturas.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
