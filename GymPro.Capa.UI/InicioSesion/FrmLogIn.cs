using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.UI.DashBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.InicioSesion
{
    public partial class FrmLogIn : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private FrmInicioSesion _FrmInicioSesion;

        public FrmLogIn(FrmInicioSesion frmInicioSesion)
        {
            InitializeComponent();
            _FrmInicioSesion = frmInicioSesion;
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            _FrmInicioSesion.AbrirFormEnPanel(new FrmRegistrarse(_FrmInicioSesion, this));
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Errores.Clear();

                string identificacion = "";
                string contrasenna = "";

                bool hayErrores = false;

                if (!int.TryParse(txtIdentificacion.Text, out int resultado))
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario debe contener solamente digitos");
                    hayErrores = true;
                }
                else if (resultado.ToString().Length < 9 || resultado.ToString().Length > 15)
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario debe contener de entre 9 a 15 dígitos");
                    hayErrores = true;
                }
                else
                {
                    identificacion = resultado.ToString();
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

                if (hayErrores)
                {
                    return;
                }

                IUsuarioBLL logica = new UsuarioBLL();

                bool existeInactivo = false;

                logica.ObtenerUsuarioInactivoTodos().ForEach(usuario =>
                {

                    if (usuario.Identificacion.Equals(identificacion) && usuario.Contrasenna.Equals(contrasenna))
                    {
                        MessageBox.Show("Usuario pendiente de activación, espere a que su Usuario sea activado por el administrador");
                        existeInactivo = true;
                    }

                });

                if (existeInactivo)
                {
                    return;
                }

                bool inicioSesion = false;

                logica.ObtenerUsuarioActivoTodos().ForEach(usuario =>
                {

                    if (usuario.Identificacion.Equals(identificacion) && usuario.Contrasenna.Equals(contrasenna))
                    {
                        inicioSesion = true;

                        FrmDashBoard frmDashBoard = new FrmDashBoard(usuario);

                        _MyLogControlEventos.InfoFormat("Info {0}", $"El usuario {usuario.Nombre} {usuario.Apellido1} de tipo {usuario.GetType().Name} ha iniciado sesion");

                        frmDashBoard.Show();
                        _FrmInicioSesion.Hide();
                    }

                });

                if (!inicioSesion)
                {
                    lblMensajeError.Visible = true;
                    _MyLogControlEventos.InfoFormat("Info {0}", "Intento de inicio de sesion fallido");
                }
                
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
