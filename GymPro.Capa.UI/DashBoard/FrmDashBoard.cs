using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard
{
    public partial class FrmDashBoard : Form
    {

        public IUsuario _Usuario { get; set; }

        public FrmDashBoard(IUsuario usuario)
        {
            InitializeComponent();
            _Usuario = usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            lblTipoUsuario.Text = $"{_Usuario.GetType().Name}";
            lblNombreUsuario.Text = $"{_Usuario.Nombre} {_Usuario.Apellido1}";
            pbFotoUsuario.Image = new Bitmap(new MemoryStream(_Usuario.Fotografia));
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
    }
}
