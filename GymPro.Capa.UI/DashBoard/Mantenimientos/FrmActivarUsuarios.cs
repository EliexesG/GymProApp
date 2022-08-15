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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    public partial class FrmActivarUsuarios : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        IUsuarioBLL Logica;

        public FrmActivarUsuarios()
        {
            InitializeComponent();
            Logica = new UsuarioBLL();
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


                foreach (IUsuario usuario in Logica.ObtenerUsuarioInactivoTodos())
                {
                    Object[] row = { usuario.Identificacion, usuario.Nombre, $"{usuario.Apellido1} {usuario.Apellido2}", usuario._TipoUsuario.Descripcion };
                    dgvUsuarios.Rows.Add(row.ToArray());
                }

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

        private void Refrescar()
        {
            try
            {
                LlenarDgvEjercicios();
                dgvUsuarios.ClearSelection();
            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        private void FrmActivarUsuarios_Load(object sender, EventArgs e)
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

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvUsuarios.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Usuario a activar");
                    return;
                }

                string cedula = dgvUsuarios.SelectedCells[0].Value.ToString();

                Logica.ActivarUsuario(cedula);

                IUsuario usuario = Logica.ObtenerUsuarioIdentificacion(cedula);

                if(usuario is Cliente)
                {
                    string receptor = (usuario as Cliente).Correo;
                    string tema = "Activación de la cueta";
                    string mensaje = $"Hola! {usuario.Nombre}, tu cuenta de cliente ha sido activada, ya puede logearse";
                    Util.Utilitarios.EnviarCorreo(receptor, tema, mensaje);
                }

                MessageBox.Show("Activado!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un usuario ha sido activado");

                Refrescar();

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
