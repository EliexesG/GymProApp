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

namespace GymPro.Capa.UI.DashBoard.Reportes
{
    public partial class FrmReporteFacturacionPorFechas : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public FrmReporteFacturacionPorFechas()
        {
            InitializeComponent();
        }

        private void FrmReporteFacturacionPorFechas_Load(object sender, EventArgs e)
        {
            dtpFechaA.Value = DateTime.Now;
            dtpFechaB.Value = DateTime.Now;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime fechaA = dtpFechaA.Value;
                DateTime fechaB = dtpFechaB.Value;

                // TODO: This line of code loads data into the 'DSFacturacionPorFechas.FacturacionPorFechas' table. You can move, or remove it, as needed.
                this.FacturacionPorFechasTableAdapter.Fill(this.DSFacturacionPorFechas.FacturacionPorFechas, fechaA.ToShortDateString(), fechaB.ToShortDateString());

                this.reportViewer1.RefreshReport();

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }
    }
}
