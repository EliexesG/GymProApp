using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Procesos
{

    public partial class FrmPDFFactura : Form
    {
        private int CodigoFactura;

        public FrmPDFFactura(int pCodigo)
        {
            InitializeComponent();
            CodigoFactura = pCodigo;
        }

        private void FrmPDFFactura_Load(object sender, EventArgs e)
        {
            
            this.FacturacionTableAdapter.Fill(this.DSUltimaFactura.Facturacion, CodigoFactura);
            this.reportViewer1.RefreshReport();
        }
    }
}
