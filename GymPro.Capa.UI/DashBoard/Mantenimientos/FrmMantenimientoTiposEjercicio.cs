using GymPro.Capa.Entidades.Implementaciones;
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
    public partial class FrmMantenimientoTiposEjercicio : Form
    {


        ITipoEjercicioBLL logica;

        public FrmMantenimientoTiposEjercicio()
        {
            InitializeComponent();
            logica = new TipoEjercicioBLL();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Errores.Clear();
                bool hayErrores = false;

                string nombre = "";
                string descripcion = "";

                if(!(string.IsNullOrEmpty(txtCodigo.Text)) && dgvTiposEjercicio.SelectedRows.Count >= 1)
                {
                    MessageBox.Show("Previamente se ha seleccionado un Tipo de Ejercicio, presione Modificar o Eliminar");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    Errores.SetError(txtNombre, "Debe digitar el nombre del Tipo de Ejercicio");
                    hayErrores = true;
                }
                else { nombre = txtNombre.Text; }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    Errores.SetError(txtDescripcion, "Debe digitar la descripción del Tipo de Ejercicio");
                    hayErrores = true;
                }
                else { descripcion = txtDescripcion.Text; }

                if (hayErrores)
                {
                    return;
                }

                logica.InsertarTipoEjercicio(new TipoEjercicio() { Nombre = nombre, Descripcion = descripcion });

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

        private void Refrescar()
        {
            try
            {
                dgvTiposEjercicio.DataSource = logica.ObtenerTipoEjercicioTodos();
                dgvTiposEjercicio.ClearSelection();
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtNombre.Text = "";
                Errores.Clear();
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

        private void FrmMantenimientoTiposEjercicio_Load(object sender, EventArgs e)
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

        private void dgvTiposEjercicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TipoEjercicio tipoEjercicio = (TipoEjercicio)dgvTiposEjercicio.CurrentRow.DataBoundItem;

                txtCodigo.Text = tipoEjercicio.Codigo.ToString();
                txtNombre.Text = tipoEjercicio.Nombre;
                txtDescripcion.Text = tipoEjercicio.Descripcion;

            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if((string.IsNullOrEmpty(txtCodigo.Text)) && dgvTiposEjercicio.SelectedRows.Count <= 1)
                {
                    MessageBox.Show("Debe seleccionar el Tipo de Ejercicio a eliminar");
                    return;
                }

                TipoEjercicio tipoEjercicio = (TipoEjercicio)dgvTiposEjercicio.CurrentRow.DataBoundItem;

                logica.EliminarTipoEjercicio(tipoEjercicio.Codigo);

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
                Errores.Clear();
                bool hayErrores = false;

                int codigo;
                string nombre = "";
                string descripcion = "";

                if ((string.IsNullOrEmpty(txtCodigo.Text)) && dgvTiposEjercicio.SelectedRows.Count <= 1)
                {
                    MessageBox.Show("Debe seleccionar el Tipo de Ejercicio a modificar");
                    return;
                }
                else
                {
                    codigo = int.Parse(txtCodigo.Text);
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    Errores.SetError(txtNombre, "Debe digitar el nombre del Tipo de Ejercicio");
                    hayErrores = true;
                }
                else { nombre = txtNombre.Text; }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    Errores.SetError(txtDescripcion, "Debe digitar la descripción del Tipo de Ejercicio");
                    hayErrores = true;
                }
                else { descripcion = txtDescripcion.Text; }

                if (hayErrores)
                {
                    return;
                }

                logica.ModificarTipoEjercicio(new TipoEjercicio() { Codigo = codigo, Nombre = nombre, Descripcion = descripcion });
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
    }
}
