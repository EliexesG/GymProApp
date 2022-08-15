using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
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

namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    public partial class FrmMenuMantenimientos : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        IUsuario _Usuario;

        public FrmMenuMantenimientos(IUsuario pUsuario)
        {
            InitializeComponent();
            _Usuario = pUsuario;
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
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
            
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
