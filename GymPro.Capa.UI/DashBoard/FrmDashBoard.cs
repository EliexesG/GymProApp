using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.UI.DashBoard.Mantenimientos;
using GymPro.Capa.UI.DashBoard.Procesos;
using GymPro.Capa.UI.DashBoard.Reportes;
using GymPro.Capa.UI.InicioSesion;
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
            if(MessageBox.Show("¿Desea abrir nueva sesión?", "Cerrar sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmInicioSesion inicioSesion = new FrmInicioSesion();
                inicioSesion.Show();
                this.Close();
            }
            else
            {
                Application.Exit();
            }
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

            if(_Usuario is Cliente)
            {
                btnMantenimientos.Enabled = false;
                btnReportes.Enabled = false;
            }
            else if(_Usuario is Instructor)
            {
                btnReportes.Enabled = false;
            }
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

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmMenuMantenimientos(_Usuario));
            }
            catch(Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmMenuProcesos(_Usuario));
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmMenuReportes());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }
    }
}
