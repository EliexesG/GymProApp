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
    public partial class FrmMenuReportes : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public FrmMenuReportes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que muestra en el panel el Frame dado por parametro
        /// </summary>
        /// <param name="formhija">Frame a mostrar</param>
        public void AbrirFormEnPanel(object formhija)
        {
            try
            {
                if (this.pnlDisplay.Controls.Count > 0)
                    this.pnlDisplay.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnlDisplay.Controls.Add(fh);
                this.pnlDisplay.Tag = fh;
                fh.Show();
            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        private void btnEntrenamientosCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmReporteEntrenamientosCliente());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnEjerciciosMasUsados_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmReporteEjerciciosMasUsados());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnRangoFacturacion_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmReporteFacturacionPorFechas());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnEjerciciosPorTipo_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmReporteEjerciciosPorTIpo());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnMorosos_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmReporteUsuariosMorosos());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }
    }
}
