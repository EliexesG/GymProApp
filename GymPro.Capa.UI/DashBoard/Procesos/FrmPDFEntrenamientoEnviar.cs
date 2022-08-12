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
    public partial class FrmPDFEntrenamientoEnviar : Form
    {
        private int CodigoEntrenamiento;

        public FrmPDFEntrenamientoEnviar(int pCodigoEntrenamiento)
        {
            InitializeComponent();
            CodigoEntrenamiento = pCodigoEntrenamiento;
        }

        private void FrmPDFEntrenamientoEnviar_Load(object sender, EventArgs e)
        {
            try
            {
                EntrenamientoTableAdapter.Fill(this.DSEntrenamiento.Entrenamiento, CodigoEntrenamiento);
                reportViewer1.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
            this.reportViewer1.RefreshReport();
        }
    }
}
