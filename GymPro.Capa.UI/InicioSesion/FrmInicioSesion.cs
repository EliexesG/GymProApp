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

namespace GymPro.Capa.UI.InicioSesion
{
    public partial class FrmInicioSesion : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public FrmInicioSesion()
        {
            InitializeComponent();
        }


        public void AbrirFormEnPanel(object formhija)
        {
            try
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
            catch(Exception er)
            {
                throw er;
            }
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FrmLogIn(this));
                Util.Utilitarios.CultureInfo();
            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.InfoFormat("Info {0}", "Se ha cerrado la aplicacion");

            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
