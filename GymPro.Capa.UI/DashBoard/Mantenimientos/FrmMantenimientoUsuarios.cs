using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Factories;
using GymPro.Capa.Logica.BLL.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    public partial class FrmMantenimientoUsuarios : Form
    {

        private IUsuarioBLL Logica;

        public FrmMantenimientoUsuarios()
        {
            InitializeComponent();
            Logica = new UsuarioBLL();
            dgvUsuarios.AutoGenerateColumns = false;
        }

        private void FrmMantenimientoUsuarios_Load(object sender, EventArgs e)
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



        private void LlenarDgvEjercicios()
        {
            try
            {

                dgvUsuarios.Rows.Clear();

                dgvUsuarios.ColumnCount = 4;
                dgvUsuarios.Columns[0].Name = "Identificación";
                dgvUsuarios.Columns[1].Name = "Nombre";
                dgvUsuarios.Columns[2].Name = "Apellidos";
                dgvUsuarios.Columns[3].Name = "Tipo de Usuario";


                foreach (IUsuario usuario in Logica.ObtenerUsuarioActivoTodos())
                {
                    Object[] row = { usuario.Identificacion, usuario.Nombre, $"{usuario.Apellido1} {usuario.Apellido2}", usuario._TipoUsuario.Descripcion };
                    dgvUsuarios.Rows.Add(row.ToArray());
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

        private void Refrescar()
        {
            try
            {
                Errores.Clear();

                cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
                cmbGenero.SelectedIndex = -1;

                cmbTipoUsuario.DisplayMember = "Descripcion";
                cmbTipoUsuario.ValueMember = "Codigo";
                cmbTipoUsuario.DataSource = new TipoUsuarioBLL().ObtenerTipoUsuarioTodos();

                cmbTipoUsuario.SelectedIndex = -1;

                pbFotografia.Image = null;

                txtIdentificacion.Enabled = true;
                txtIdentificacion.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtApellido1.Text = "";
                txtApellido2.Text = "";
                txtCorreo.Text = "";
                dtpFechaNacimiento.Value = DateTime.Now;
                txtContrasenna.Text = "";

                LlenarDgvEjercicios();
                dgvUsuarios.ClearSelection();

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

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbTipoUsuario.DataSource != null)
                {
                    if (cmbTipoUsuario.SelectedIndex == -1 || ((int)cmbTipoUsuario.SelectedValue) != ((int)TipoUsuarioEnum.Cliente))
                    {
                        txtTelefono.Enabled = false;
                        txtCorreo.Enabled = false;
                        cmbGenero.Enabled = false;
                        dtpFechaNacimiento.Enabled = false;
                    }
                    else if (((int)cmbTipoUsuario.SelectedValue) == ((int)TipoUsuarioEnum.Cliente))
                    {
                        txtTelefono.Enabled = true;
                        txtCorreo.Enabled = true;
                        cmbGenero.Enabled = true;
                        dtpFechaNacimiento.Enabled = true;
                    }
                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string identificacion = dgvUsuarios.SelectedCells[0].Value.ToString();

                IUsuario usuario = Logica.ObtenerUsuarioIdentificacion(identificacion);

                txtIdentificacion.Enabled = false;
                pbFotografia.Image = new Bitmap(new MemoryStream(usuario.Fotografia));
                txtIdentificacion.Text = usuario.Identificacion;
                txtNombre.Text = usuario.Nombre;
                txtApellido1.Text = usuario.Apellido1;
                txtApellido2.Text = usuario.Apellido2;
                cmbTipoUsuario.SelectedValue = usuario.CodigoTipoUsuario;
                txtContrasenna.Text = usuario.Contrasenna;
                cmbGenero.SelectedIndex = -1;

                if(usuario is Cliente)
                {
                    txtTelefono.Text = ((Cliente)usuario).Telefono;
                    txtCorreo.Text = ((Cliente)usuario).Correo;
                    cmbGenero.SelectedItem = ((Cliente)usuario).Genero;
                    dtpFechaNacimiento.Value = ((Cliente)usuario).FechaNacimiento;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(string.IsNullOrEmpty(txtIdentificacion.Text)) && dgvUsuarios.SelectedRows.Count >= 1)
                {
                    MessageBox.Show("Previamente se ha seleccionado un Usuario, presione Modificar o Eliminar");
                    return;
                }

                IUsuario usuario = null;
                byte[] fotografia = null;
                string identificacion = "";
                string nombre = "";
                string telefono = "";
                string apellido1 = "";
                string apellido2 = "";
                string correo = "";
                Genero? genero = null;
                int codigoTipoUsuario = 0;
                TipoUsuarioEnum? tipoUsuario = null;
                DateTime fechaNacimiento = DateTime.Now;
                string contrasenna = "";

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
                    fotografia = (byte[])_imageConverter.ConvertTo(pbFotografia.Image, typeof(byte[]));
                }

                if (!long.TryParse(txtIdentificacion.Text, out long resultado))
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario debe contener solamente digitos");
                    hayErrores = true;
                }
                else if (resultado.ToString().Length < 9 || resultado.ToString().Length > 15)
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario debe contener de entre 9 a 15 dígitos");
                    hayErrores = true;
                }
                else if (int.Parse(txtIdentificacion.Text[0].ToString()) == 0)
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario no puede iniciar en 0");
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

                if (cmbTipoUsuario.SelectedIndex == -1)
                {
                    Errores.SetError(cmbTipoUsuario, "Debe seleccionar que tipo de Usuario es el usuario");
                    hayErrores = true;
                }
                else
                {
                    tipoUsuario = (TipoUsuarioEnum)cmbTipoUsuario.SelectedValue;
                    codigoTipoUsuario = (int)cmbTipoUsuario.SelectedValue;
                }

                if(tipoUsuario == TipoUsuarioEnum.Cliente)
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

                usuario = FactoryUsuario.CrearUsuario((TipoUsuarioEnum)tipoUsuario);
                usuario.Identificacion = identificacion;
                usuario.Nombre = nombre;
                usuario.Apellido1 = apellido1;
                usuario.Apellido2 = apellido2;
                usuario.CodigoTipoUsuario = codigoTipoUsuario;
                usuario.Contrasenna = contrasenna;
                usuario.Fotografia = fotografia;

                if(usuario is Cliente)
                {
                    ((Cliente)usuario).FechaNacimiento = fechaNacimiento;
                    ((Cliente)usuario).Correo = correo;
                    ((Cliente)usuario).Telefono = telefono;
                    ((Cliente)usuario).Genero = (Genero)genero;
                }

                Logica.InsertarUsuario(usuario);
                Logica.ActivarUsuario(usuario.Identificacion);

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtContrasenna.Text)) && dgvUsuarios.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Usuario a modificar");
                    return;
                }

                IUsuario usuario = null;
                byte[] fotografia = null;
                string identificacion = "";
                string nombre = "";
                string telefono = "";
                string apellido1 = "";
                string apellido2 = "";
                string correo = "";
                Genero? genero = null;
                int codigoTipoUsuario = 0;
                TipoUsuarioEnum? tipoUsuario = null;
                DateTime fechaNacimiento = DateTime.Now;
                string contrasenna = "";

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
                    fotografia = (byte[])_imageConverter.ConvertTo(pbFotografia.Image, typeof(byte[]));
                }

                if (!long.TryParse(txtIdentificacion.Text, out long resultado))
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario debe contener solamente digitos");
                    hayErrores = true;
                }
                else if (resultado.ToString().Length < 9 || resultado.ToString().Length > 15)
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario debe contener de entre 9 a 15 dígitos");
                    hayErrores = true;
                }
                else if (int.Parse(txtIdentificacion.Text[0].ToString()) == 0)
                {
                    Errores.SetError(txtIdentificacion, "La identificación del usuario no puede iniciar en 0");
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

                if (cmbTipoUsuario.SelectedIndex == -1)
                {
                    Errores.SetError(cmbTipoUsuario, "Debe seleccionar que tipo de Usuario es el usuario");
                    hayErrores = true;
                }
                else
                {
                    tipoUsuario = (TipoUsuarioEnum)cmbTipoUsuario.SelectedValue;
                    codigoTipoUsuario = (int)cmbTipoUsuario.SelectedValue;
                }

                if (tipoUsuario == TipoUsuarioEnum.Cliente)
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

                usuario = FactoryUsuario.CrearUsuario((TipoUsuarioEnum)tipoUsuario);
                usuario.Identificacion = identificacion;
                usuario.Nombre = nombre;
                usuario.Apellido1 = apellido1;
                usuario.Apellido2 = apellido2;
                usuario.CodigoTipoUsuario = codigoTipoUsuario;
                usuario.Contrasenna = contrasenna;
                usuario.Fotografia = fotografia;

                if (usuario is Cliente)
                {
                    ((Cliente)usuario).FechaNacimiento = fechaNacimiento;
                    ((Cliente)usuario).Correo = correo;
                    ((Cliente)usuario).Telefono = telefono;
                    ((Cliente)usuario).Genero = (Genero)genero;
                }

                Logica.ModificarUsuario(usuario);

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

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtIdentificacion.Text)) && dgvUsuarios.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Usuario a desactivar");
                    return;
                }

                if (MessageBox.Show("¿Está seguro de desactivar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string identificacion = dgvUsuarios.SelectedCells[0].Value.ToString();

                    Logica.EliminarUsuario(identificacion);

                    Refrescar();
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

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmActivarUsuarios ventana = new FrmActivarUsuarios();
                ventana.ShowDialog();

                Refrescar();
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }
    }
}
