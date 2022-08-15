using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.UI.DashBoard.Mantenimientos;
using GymPro.Capa.UI.DashBoard.Procesos;
using GymPro.Capa.UI.DashBoard.Reportes;
using GymPro.Capa.UI.InicioSesion;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard
{
    public partial class FrmDashBoard : Form
    {
        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public IUsuario _Usuario { get; set; }
        private IMultaBLL oMultaBLL = new MultaBLL();

        public FrmDashBoard(IUsuario usuario)
        {
            InitializeComponent();
            _Usuario = usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Desea abrir nueva sesión?", "Cerrar sesión", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                FrmInicioSesion inicioSesion = new FrmInicioSesion();
                inicioSesion.Show();
                this.Close();

                _MyLogControlEventos.InfoFormat("Info {0}", "Se ha cerrado la sesion");
            }
            else if(resultado == DialogResult.No)
            {
                _MyLogControlEventos.InfoFormat("Info {0}", "Se ha cerrado la sesion");
                Application.Exit();
            }
        }

        public void Refrescar()
        {
            try
            {
                lblTipoUsuario.Text = $"{_Usuario.GetType().Name}";
                lblNombreUsuario.Text = $"{_Usuario.Nombre} {_Usuario.Apellido1}";
                pbFotoUsuario.Image = new Bitmap(new MemoryStream(_Usuario.Fotografia));

                if (_Usuario is Cliente)
                {
                    btnMantenimientos.Enabled = false;
                    btnReportes.Enabled = false;

                    lblMulta.Visible = false;
                    txtMulta.Visible = false;
                    btnModificarMulta.Visible = false;
                }
                else if (_Usuario is Instructor)
                {
                    btnReportes.Enabled = false;

                    lblMulta.Visible = false;
                    txtMulta.Visible = false;
                    btnModificarMulta.Visible = false;
                }
                else if (_Usuario is Administrador)
                {
                    txtMulta.Text = (oMultaBLL.ObtenerMulta().PorcentajeMulta * 100).ToString();
                }
            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

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

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFormEnPanel(new FrmVerPerfil(_Usuario, this));
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnModificarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                if(!int.TryParse(txtMulta.Text, out int porcentajeMulta))
                {
                    MessageBox.Show("El porcetaje de la multa debe ser un dato numérico entero");
                    return;
                }

                if(porcentajeMulta < 0 || porcentajeMulta > 100)
                {
                    MessageBox.Show("El porcetaje de la multa debe comprender entre el rango de 0 a 100");
                    return;
                }

                Multa multaNueva = new Multa()
                {
                    PorcentajeMulta = porcentajeMulta / 100D
                };

                oMultaBLL.ModificarMulta(multaNueva);

                MessageBox.Show("Multa modificada!!");

                Refrescar();
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }
    }
}
