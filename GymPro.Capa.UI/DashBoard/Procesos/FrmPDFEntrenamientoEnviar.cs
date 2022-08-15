using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Procesos
{
    public partial class FrmPDFEntrenamientoEnviar : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private int CodigoEntrenamiento;
        private Cliente _Cliente;

        private string Ruta = @"C:\Windows\Temp\Entrenamiento.pdf";

        public FrmPDFEntrenamientoEnviar(int pCodigoEntrenamiento, Cliente pCliente)
        {
            InitializeComponent();
            CodigoEntrenamiento = pCodigoEntrenamiento;
            _Cliente = pCliente;
        }

        private void FrmPDFEntrenamientoEnviar_Load(object sender, EventArgs e)
        {
            try
            {

                pbFoto.Image = new Bitmap(new MemoryStream(_Cliente.Fotografia));
                txtCorreo.Text = _Cliente.Correo;

                EntrenamientoTableAdapter.Fill(this.DSEntrenamiento.Entrenamiento, CodigoEntrenamiento);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }

        private bool CorreoValido(string email)
        {
            var valido = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valido = false;
            }

            return valido;
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                ExportarYGuardarReporteAPDF();

                if (!CorreoValido(txtCorreo.Text))
                {
                    MessageBox.Show("Debe digitar un correo válido");
                    return;
                }

                string receptor = txtCorreo.Text;
                string tema = "Nuevo Entrenamiento";
                string mensaje = $"Se ha creado un entrenamiento nuevo para usted {_Cliente.Nombre}, descarga el PDF para poder verlo!";

                Util.Utilitarios.EnviarCorreo(receptor, tema, mensaje, Ruta);

                MessageBox.Show("Entrenamiento Enviado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un entrenamiento ha sido enviado por correo");
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }

        private void ExportarYGuardarReporteAPDF()
        {
            try
            {
                

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out filenameExtension,
                    out streamids, out warnings);

                using (FileStream fs = new FileStream(Ruta, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }
    }
}
