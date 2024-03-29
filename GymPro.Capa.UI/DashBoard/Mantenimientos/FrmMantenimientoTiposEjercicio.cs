﻿using GymPro.Capa.Entidades.Implementaciones;
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

namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    public partial class FrmMantenimientoTiposEjercicio : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        ITipoEjercicioBLL Logica;

        public FrmMantenimientoTiposEjercicio()
        {
            InitializeComponent();
            Logica = new TipoEjercicioBLL();
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

                Logica.InsertarTipoEjercicio(new TipoEjercicio() { Nombre = nombre, Descripcion = descripcion });

                MessageBox.Show("Tipo de Ejercicio insertado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un tipo de ejercicio ha sido insertado");

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

        /// <summary>
        /// Metodo que refresca lo controles en la ventana
        /// </summary>
        private void Refrescar()
        {
            try
            {
                dgvTiposEjercicio.DataSource = Logica.ObtenerTipoEjercicioTodos();
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
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

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
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if((string.IsNullOrEmpty(txtCodigo.Text)) && dgvTiposEjercicio.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Tipo de Ejercicio a eliminar");
                    return;
                }

                if(new EjercicioBLL().ObtenerEjercicioCodigoTipo(int.Parse(txtCodigo.Text)).Count > 0)
                {
                    MessageBox.Show("No se puede eliminar Tipo de Ejercicio debido a que Ejercicios creados dependen de el");
                    return;
                }

                if(MessageBox.Show("¿Está seguro de eliminar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TipoEjercicio tipoEjercicio = (TipoEjercicio)dgvTiposEjercicio.CurrentRow.DataBoundItem;

                    Logica.EliminarTipoEjercicio(tipoEjercicio.Codigo);

                    MessageBox.Show("Tipo de Ejercicio eliminado!!");
                    _MyLogControlEventos.InfoFormat("Info {0}", "Un tipo de ejercicio ha sido eliminado");

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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                Errores.Clear();
                bool hayErrores = false;

                int codigo;
                string nombre = "";
                string descripcion = "";

                if ((string.IsNullOrEmpty(txtCodigo.Text)) && dgvTiposEjercicio.SelectedRows.Count < 1)
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

                Logica.ModificarTipoEjercicio(new TipoEjercicio() { Codigo = codigo, Nombre = nombre, Descripcion = descripcion });

                MessageBox.Show("Tipo de Ejercicio modificado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un tipo de ejercicio ha sido modificado");

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
