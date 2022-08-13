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
    public partial class FrmReporteEjerciciosMasUsados : Form
    {
        public FrmReporteEjerciciosMasUsados()
        {
            InitializeComponent();
        }

        private void FrmReporteEjerciciosMasUsados_Load(object sender, EventArgs e)
        {
            try
            {
                EjerciciosMasUsadosTableAdapter.Fill(DSEjerciciosMasUsados.EjerciciosMasUsados);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
            
        }
    }
}
