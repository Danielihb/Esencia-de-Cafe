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

namespace Win.Esencia_de_Cafe
{
    public partial class FormReporteFacturas : Form
    {
        public FormReporteFacturas()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            var _facturaBL = new FacturaBL();
            var bidingSource = new BindingSource();
            bidingSource.DataSource = _facturaBL.ObtenerFacturas();

            var reporte = new DetalledeReportesFacturas();
            reporte.SetDataSource(bidingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();


        }

        private void FormReporteFacturas_Load(object sender, EventArgs e)
        {

        }
    }
}
