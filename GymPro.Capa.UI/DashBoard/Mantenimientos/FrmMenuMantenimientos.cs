using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    public partial class FrmMenuMantenimientos : Form
    {
        public FrmMenuMantenimientos()
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

        private void btnTiposEntrenamientos_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmMantenimientoTiposEjercicio());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmMantenimientoEjercicios());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }
    }
}
