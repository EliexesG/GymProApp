using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.BLL.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.InicioSesion
{
    public partial class FrmRegistrarse : Form
    {

        FrmInicioSesion _FrmInicioSesion;
        FrmLogIn _FrmLogIn;

        public object UsuarioBLL { get; private set; }

        public FrmRegistrarse(FrmInicioSesion frmInicioSesion, FrmLogIn frmLogIn)
        {
            InitializeComponent();
            _FrmInicioSesion = frmInicioSesion;
            _FrmLogIn = frmLogIn;
        }

        private void btnIrAtras_Click(object sender, EventArgs e)
        {
            _FrmInicioSesion.AbrirFormEnPanel(_FrmLogIn);
        }

        private void FrmRegistrarse_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            cmbGenero.SelectedIndex = -1;
        }

        private void btnAsignarFotografia_Click(object sender, EventArgs e)
        {

            if (ofdBuscadorImagenes.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbFotografia.Image = new Bitmap(ofdBuscadorImagenes.FileName);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error: " + er.Message, "Error");
                }
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] imagen = null;
                string identificacion = "";
                string nombre = "";
                string apellido1 = "";
                string apellido2 = "";
                string contrasenna = "";
                DateTime? fechaNacimiento = null;
                string correo = "";
                string telefono = "";
                Genero? genero = null;

                Errores.Clear();

                bool hayErrores = false;

                if (pbFotografia.Image == null)
                {
                    Errores.SetError(pbFotografia, "Debe seleccionar una imagen a guardar como fotografía");
                    hayErrores = true;
                }
                else
                {
                    ImageConverter _imageConverter = new ImageConverter();
                    imagen = (byte[])_imageConverter.ConvertTo(pbFotografia.Image, typeof(byte[]));
                }

                if(!int.TryParse(txtIdentificacion.Text, out int resultado))
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario debe contener solamente digitos");
                    hayErrores = true;
                }
                else if(resultado.ToString().Length < 9 || resultado.ToString().Length > 15)
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario debe contener de entre 9 a 15 dígitos");
                    hayErrores = true;
                }
                else
                {
                    identificacion = resultado.ToString();
                }

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

                if(cmbGenero.SelectedIndex == -1)
                {
                    Errores.SetError(cmbGenero, "Debe seleccionar el género del usuario");
                    hayErrores = true;
                }
                else
                {
                    genero = (Genero)cmbGenero.SelectedItem;
                }

                if (hayErrores)
                {
                    return;
                }

                //Construccion usuario
                IUsuario usuario = new Cliente()
                {
                    Identificacion = identificacion,
                    Nombre = nombre,
                    Apellido1 = apellido1,
                    Apellido2 = apellido2,
                    Fotografia = imagen,
                    CodigoTipoUsuario = (int)TipoUsuarioEnum.Cliente,
                    Contrasenna = contrasenna,
                    FechaNacimiento = (DateTime)fechaNacimiento,
                    Correo = correo,
                    Telefono = telefono,
                    Genero = (Genero)genero
                };

                IUsuarioBLL logica = new UsuarioBLL();

                logica.InsertarUsuario(usuario);

                //Si llegó hasta aquí funcionó
                MessageBox.Show("Usuario Registrado!! Espere a ser confirmado por el administrador");
                btnIrAtras_Click(sender, e);

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

    }
}
