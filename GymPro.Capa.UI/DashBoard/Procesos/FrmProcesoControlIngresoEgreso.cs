using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Procesos
{
    public partial class FrmProcesoControlIngresoEgreso : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private IUsuario _Usuario;
        private IControlIngresoEgresoBLL LogicaControl;
        private TimeSpan HoraUltima;
        private Timer myTimer = new Timer();

        public FrmProcesoControlIngresoEgreso(IUsuario pUsuario)
        {
            InitializeComponent();
            _Usuario = pUsuario;
            LogicaControl = new ControlIngresoEgresoBLL();
        }

        private void FrmProcesoControlIngresoEgreso_Load(object sender, EventArgs e)
        {
            try
            {
                Refrescar();
            }
            catch (SqlException sqlError)
            {
                MessageBox.Show($"Ha ocurrido un error en la base de datos: {Util.Utilitarios.GetCustomErrorByNumber(sqlError)}");
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {

                TimeSpan tiempoTranscurrido = DateTime.Now.TimeOfDay - HoraUltima;

                string horas = tiempoTranscurrido.Hours < 10 ? ("0" + tiempoTranscurrido.Hours) : tiempoTranscurrido.Hours.ToString();
                string minutos = tiempoTranscurrido.Minutes < 10 ? ("0" + tiempoTranscurrido.Minutes) : tiempoTranscurrido.Minutes.ToString();
                string segundos = tiempoTranscurrido.Seconds < 10 ? ("0" + tiempoTranscurrido.Seconds) : tiempoTranscurrido.Seconds.ToString();

                string contador = $"{horas}:{minutos}:{segundos}";

                lblContador.Text = contador;
            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        /// <summary>
        /// Inicia un contador que se muestra en pantalla
        /// </summary>
        private void ActivarContador()
        {
            try
            { 

                myTimer.Interval = 1000;
                myTimer.Enabled = true;

                myTimer.Tick += Timer_Tick;

                myTimer.Start();
            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        /// <summary>
        /// Finaliza el contador mostrado en pantalla
        /// </summary>
        private void DesactivarContador()
        {
            try
            {
                myTimer.Enabled = false;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        /// <summary>
        /// Metodo que refresca lo controles en la ventana
        /// </summary>
        private void Refrescar()
        {
            try
            {
                txtIdentificacion.Text = _Usuario.Identificacion;

                ControlIngresoEgreso control = LogicaControl.ObtenerControlIngresoEgresoUltimoIdentificacionUsuario(_Usuario.Identificacion);

                if(control != null)
                {
                    if (control.Fecha.Date == DateTime.Now.Date && control.HoraSalida == null)
                    {
                        btnRegistrarIngreso.Enabled = false;
                        btnRegistrarEgreso.Enabled = true;
                        HoraUltima = control.HoraEntrada;


                        ActivarContador();

                        txtFecha.Text = control.Fecha.Date.ToString();
                        txtHoraIngreso.Text = control.HoraEntrada.ToString();

                    }
                    else
                    {
                        btnRegistrarIngreso.Enabled = true;
                        btnRegistrarEgreso.Enabled = false;
                        HoraUltima = DateTime.Now.TimeOfDay;

                        txtFecha.Text = DateTime.Now.Date.ToString();
                    }
                }
                else
                {
                    btnRegistrarIngreso.Enabled = true;
                    btnRegistrarEgreso.Enabled = false;
                    HoraUltima = DateTime.Now.TimeOfDay;

                    txtFecha.Text = DateTime.Now.Date.ToString();
                }

                dgvControlIngresoEgreso.DataSource = LogicaControl.ObtenerControlIngresoEgresoIdentificacionUsuario(_Usuario.Identificacion);
                dgvControlIngresoEgreso.ClearSelection();
            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            try
            {

                ControlIngresoEgreso controlNuevo = new ControlIngresoEgreso()
                {
                    IdentificacionUsuario = _Usuario.Identificacion,
                    Fecha = DateTime.Parse(txtFecha.Text),
                    HoraEntrada = HoraUltima
                };

                LogicaControl.InsertarIngreso(controlNuevo);

                ActivarContador();

                MessageBox.Show("Ingreso registrado, contador iniciado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un ingreso ha sido registrado, se activo el contador");

                btnRegistrarIngreso.Enabled = false;
                btnRegistrarEgreso.Enabled = true;
                txtHoraIngreso.Text = HoraUltima.ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ha ocurrido un error en la base de datos: El usuario ya registró un Ingreso y Egreso el día de hoy");
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }

        private void btnRegistrarEgreso_Click(object sender, EventArgs e)
        {
            try
            {

                ControlIngresoEgreso control = LogicaControl.ObtenerControlIngresoEgresoUltimoIdentificacionUsuario(_Usuario.Identificacion);

                control.HoraSalida = DateTime.Now.TimeOfDay;

                txtHoraEgreso.Text = control.HoraSalida.ToString();

                LogicaControl.ModificarEgreso(control);

                Refrescar();

                DesactivarContador();

                MessageBox.Show("Egreso registrado, contador desactivado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un egreso ha sido registrado, se desactivo el contador");

                btnRegistrarIngreso.Enabled = true;
                btnRegistrarEgreso.Enabled = false;

            }
            catch (SqlException sqlError)
            {
                MessageBox.Show($"Ha ocurrido un error en la base de datos: {Util.Utilitarios.GetCustomErrorByNumber(sqlError)}");
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }
    }
}
