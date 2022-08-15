using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Procesos
{

    public partial class FrmPDFFactura : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private int CodigoFactura;

        public FrmPDFFactura(int pCodigo)
        {
            InitializeComponent();
            CodigoFactura = pCodigo;
        }

        private void FrmPDFFactura_Load(object sender, EventArgs e)
        {
            try
            {
                this.FacturacionTableAdapter.Fill(this.DSUltimaFactura.Facturacion, CodigoFactura);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
            
        }
    }
}
