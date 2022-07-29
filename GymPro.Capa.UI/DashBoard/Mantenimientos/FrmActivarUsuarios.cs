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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    public partial class FrmActivarUsuarios : Form
    {

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
