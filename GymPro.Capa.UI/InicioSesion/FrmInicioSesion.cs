using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.InicioSesion
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }


        public void AbrirFormEnPanel(object formhija)
        {

            if (this.pnlfondo.Controls.Count > 0)
                this.pnlfondo.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlfondo.Controls.Add(fh);
            this.pnlfondo.Tag = fh;
            fh.Show();

        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FrmLogIn(this));
            }
            catch(Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
