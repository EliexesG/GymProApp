using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
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
        IUsuario _Usuario;

        public FrmMenuMantenimientos(IUsuario pUsuario)
        {
            InitializeComponent();
            _Usuario = pUsuario;
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

        private void btnEjercicios_Click(object sender, EventArgs e)
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmMantenimientoUsuarios());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmMantenimientoExpediente());
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void FrmMenuMantenimientos_Load(object sender, EventArgs e)
        {
            if (_Usuario is Cliente)
            {
                btnEjercicios.Enabled = false;
                btnExpediente.Enabled = false;
                btnTiposEntrenamientos.Enabled = false;
                btnUsuarios.Enabled = false;
            }
            else if(_Usuario is Instructor)
            {
                btnEjercicios.Enabled = false;
                btnTiposEntrenamientos.Enabled = false;
                btnUsuarios.Enabled = false;
            }
        }
    }
}
