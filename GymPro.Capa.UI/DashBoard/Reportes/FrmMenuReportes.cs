using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Reportes
{
    public partial class FrmMenuReportes : Form
    {
        public FrmMenuReportes()
        {
            InitializeComponent();
        }

        public void AbrirFormEnPanel(object formhija)
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
    }
}
