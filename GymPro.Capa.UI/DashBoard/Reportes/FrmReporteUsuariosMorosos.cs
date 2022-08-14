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
    public partial class FrmReporteUsuariosMorosos : Form
    {
        public FrmReporteUsuariosMorosos()
        {
            InitializeComponent();
        }

        private void FrmReporteUsuariosMorosos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DSUsuariosMorosos.UsuariosMorosos' table. You can move, or remove it, as needed.
                this.UsuariosMorososTableAdapter.Fill(this.DSUsuariosMorosos.UsuariosMorosos);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
           
        }
    }
}
