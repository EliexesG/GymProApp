using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.BLL.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard
{
    public partial class FrmVerPerfil : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private IUsuario _Usuario;
        private IUsuarioBLL Logica;
        private FrmDashBoard DashBoard;
        public FrmVerPerfil(IUsuario pUsuario, FrmDashBoard pDashBoard)
        {
            InitializeComponent();
            _Usuario = pUsuario;
            Logica = new UsuarioBLL();
            DashBoard = pDashBoard;
            dgvData.AutoGenerateColumns = false;
        }

        private void Refrescar()
        {
            try
            {

                cmbGenero.DataSource = Enum.GetValues(typeof(Genero));

                txtIdentificacion.Text = _Usuario.Identificacion;
                txtNombre.Text = _Usuario.Nombre;
                txtApellido1.Text = _Usuario.Apellido1;
                txtApellido2.Text = _Usuario.Apellido2;
                txtContrasenna.Text = _Usuario.Contrasenna;

                if (!(_Usuario is Cliente))
                {
                    lblTelefono.Visible = false;
                    lblFechaNacimiento.Visible = false;
                    lblCorreo.Visible = false;
                    lblGenero.Visible = false;

                    txtTelefono.Visible = false;
                    dtpFechaNacimiento.Visible = false;
                    txtCorreo.Visible = false;
                    cmbGenero.Visible = false;

                    pnlEntrenamientos.Visible = false;
                    lblEntrenamientosExpedientes.Visible = false;
                }
                else
                {
                    Cliente cliente = _Usuario as Cliente;

                    txtTelefono.Text = cliente.Telefono;
                    dtpFechaNacimiento.Value = cliente.FechaNacimiento;
                    txtCorreo.Text = cliente.Correo;
                    cmbGenero.SelectedItem = cliente.Genero;

                    cmbVer.Items.Add("Expedientes");
                    cmbVer.Items.Add("Entrenamientos");
                    cmbVer.SelectedIndex = 0;

                    cmbEntrenamientos.DataSource = cliente.Entrenamientos;
                    cmbEntrenamientos.DisplayMember = "Nombre";
                    cmbEntrenamientos.SelectedIndex = -1;
                }
                
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        private void FrmVerPerfil_Load(object sender, EventArgs e)
        {
            try
            {

                Refrescar();
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = "";
                string telefono = "";
                string apellido1 = "";
                string apellido2 = "";
                string correo = "";
                Genero? genero = null;
                DateTime fechaNacimiento = DateTime.Now;
                string contrasenna = "";

                Errores.Clear();
                bool hayErrores = false;

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    Errores.SetError(txtNombre, "Debe digitar el nombre del usuario");
                    hayErrores = true;
                }
                else
                {
                    nombre = txtNombre.Text;
                }

                if (string.IsNullOrWhiteSpace(txtApellido1.Text))
                {
                    Errores.SetError(txtApellido1, "Debe digitar el primer apellido del usuario");
                    hayErrores = true;
                }
                else
                {
                    apellido1 = txtApellido1.Text;
                }

                if (string.IsNullOrWhiteSpace(txtApellido2.Text))
                {
                    Errores.SetError(txtApellido2, "Debe digitar el segundo apellido del usuario");
                    hayErrores = true;
                }
                else
                {
                    apellido2 = txtApellido2.Text;
                }


                if (string.IsNullOrWhiteSpace(txtContrasenna.Text))
                {
                    Errores.SetError(txtContrasenna, "Debe digitar la contraseña del usuario");
                    hayErrores = true;
                }
                else
                {
                    contrasenna = txtContrasenna.Text;
                }

                if(_Usuario is Cliente)
                {
                    fechaNacimiento = dtpFechaNacimiento.Value;

                    if (!CorreoValido(txtCorreo.Text))
                    {
                        Errores.SetError(txtCorreo, "Debe digitar un correo válido");
                        hayErrores = true;
                    }
                    else
                    {
                        correo = txtCorreo.Text;
                    }

                    if (TelefonoValido(txtTelefono.Text))
                    {
                        Errores.SetError(txtTelefono, "Debe digitar un teléfono válido");
                        hayErrores = true;
                    }
                    else
                    {
                        telefono = txtTelefono.Text;
                    }

                    if (cmbGenero.SelectedIndex == -1)
                    {
                        Errores.SetError(cmbGenero, "Debe seleccionar el género del usuario");
                        hayErrores = true;
                    }
                    else
                    {
                        genero = (Genero)cmbGenero.SelectedItem;
                    }
                }

                if (hayErrores)
                {
                    return;
                }

                _Usuario.Nombre = nombre;
                _Usuario.Apellido1 = apellido1;
                _Usuario.Apellido2 = apellido2;
                _Usuario.Contrasenna = contrasenna;

                if (_Usuario is Cliente)
                {
                    ((Cliente)_Usuario).Telefono = telefono;
                    ((Cliente)_Usuario).FechaNacimiento = fechaNacimiento;
                    ((Cliente)_Usuario).Correo = correo;
                    ((Cliente)_Usuario).Genero = (Genero)genero;
                }

                Logica.ModificarUsuario(_Usuario);

                MessageBox.Show("Usuario Modificado!");

                DashBoard._Usuario = _Usuario;

                DashBoard.Refrescar();

            }
            catch (SqlException sqlError)
            {
                MessageBox.Show($"Ha ocurrido un error en la base de datos: {Util.Utilitarios.GetCustomErrorByNumber(sqlError)}");
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

        private bool TelefonoValido(string telefono)
        {
            var regex = new Regex(@"^[\d]{4}[-][\d]{4}$");

            if (regex.IsMatch(telefono))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cmbVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbVer.SelectedIndex != -1)
                {
                    if(cmbVer.SelectedIndex == 0)
                    {
                        cmbEntrenamientos.Visible = false;
                        lblEntrenamientos.Visible = false;
                        lblDias.Visible = false;

                        dgvData.Rows.Clear();
                        dgvData.ColumnCount = 5;
                        dgvData.Columns[0].Name = "Fecha";
                        dgvData.Columns[1].Name = "Peso";
                        dgvData.Columns[2].Name = "Altura";
                        dgvData.Columns[3].Name = "IMC";
                        dgvData.Columns[4].Name = "Metabolismo Basal";

                        foreach(ExpedienteUsuario expediente in ((Cliente)_Usuario).HistorialExpedientesUsuario)
                        {
                            object[] data = { expediente.Fecha, expediente.Peso, expediente.Altura, expediente.IMC, expediente.MetabolismoBasal};
                            dgvData.Rows.Add(data);
                        }

                    }
                    else if(cmbVer.SelectedIndex == 1)
                    {
                        cmbEntrenamientos.Visible = true;
                        lblEntrenamientos.Visible = true;
                        lblDias.Visible = true;
                        cmbEntrenamientos.SelectedIndex = -1;
                        lblDias.Text = "Dias: ";
                    }
                }
                else
                {
                    cmbEntrenamientos.Visible = false;
                    lblEntrenamientos.Visible = false;
                    lblDias.Visible = false;
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

        private void cmbEntrenamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbEntrenamientos.Visible == true)
                {
                    if(cmbEntrenamientos.SelectedIndex != -1)
                    {

                        string dias = "Dias: ";

                        Entrenamiento entrenamiento = cmbEntrenamientos.SelectedItem as Entrenamiento;

                        entrenamiento.DiasEntrenamiento.ForEach(dia => dias += $"{dia.Nombre}, ");

                        lblDias.Text = dias;

                        dgvData.Rows.Clear();
                        dgvData.ColumnCount = 6;
                        dgvData.Columns[0].Name = "Ejercicio";
                        dgvData.Columns[1].Name = "Repeticiones";
                        dgvData.Columns[2].Name = "Peso";
                        dgvData.Columns[3].Name = "Series";
                        dgvData.Columns[4].Name = "Tiempo";
                        dgvData.Columns[5].Name = "Multimedia";

                        foreach (EjercicioEnEntrenamiento ejercicio in entrenamiento.EjerciciosEnEntrenamiento)
                        {
                            object[] data = { ejercicio._Ejercicio.Nombre, ejercicio.Repeticiones, ejercicio.Peso, ejercicio.Series, ejercicio.Tiempo, ejercicio._Ejercicio.Multimedia };
                            dgvData.Rows.Add(data);
                        }
                    }
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
