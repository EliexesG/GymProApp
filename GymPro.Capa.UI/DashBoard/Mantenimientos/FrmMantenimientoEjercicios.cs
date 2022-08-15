﻿using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    public partial class FrmMantenimientoEjercicios : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        IEjercicioBLL Logica;

        public FrmMantenimientoEjercicios()
        {
            InitializeComponent();
            Logica = new EjercicioBLL();
            dgvEjercicios.AutoGenerateColumns = false;
        }

        private void FrmMantenimientoEjercicios_Load(object sender, EventArgs e)
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

                dgvEjercicios.Rows.Clear();

                dgvEjercicios.ColumnCount = 4;
                dgvEjercicios.Columns[0].Name = "Codigo";
                dgvEjercicios.Columns[1].Name = "Nombre";
                dgvEjercicios.Columns[2].Name = "Descripción";
                dgvEjercicios.Columns[3].Name = "Tipo de Ejercicio";


                foreach (Ejercicio ejercicio in Logica.ObtenerEjercicioTodos())
                {
                    Object[] row = { ejercicio.Codigo, ejercicio.Nombre, ejercicio.Descripcion, ejercicio._TipoEjercicio.Nombre };
                    dgvEjercicios.Rows.Add(row.ToArray());
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
                cmdTipoEjercicio.DataSource = new TipoEjercicioBLL().ObtenerTipoEjercicioTodos();
                cmdTipoEjercicio.DisplayMember = "Nombre";
                cmdTipoEjercicio.ValueMember = "Codigo";
                cmdTipoEjercicio.SelectedIndex = -1;

                LlenarDgvEjercicios();
                dgvEjercicios.ClearSelection();

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                pbMultimedia.Image = null;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Errores.Clear();
                bool hayErrores = false;

                string nombre = "";
                string descripcion = "";
                int codigoTipoEjercicio = 0;
                byte[] multimedia = null;

                if (!(string.IsNullOrEmpty(txtCodigo.Text)) && dgvEjercicios.SelectedRows.Count >= 1)
                {
                    MessageBox.Show("Previamente se ha seleccionado un Ejercicio, presione Modificar o Eliminar");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    Errores.SetError(txtNombre, "Debe digitar el nombre perteneciente al Ejercicio");
                    hayErrores = true;
                }
                else
                {
                    nombre = txtNombre.Text;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    Errores.SetError(txtDescripcion, "Debe digitar la descripción perteneciente al Ejercicio");
                    hayErrores = true;
                }
                else
                {
                    descripcion = txtDescripcion.Text;
                }

                if(cmdTipoEjercicio.SelectedIndex == -1)
                {
                    Errores.SetError(cmdTipoEjercicio, "Debe seleccionar el Tipo de Ejercicio relacionado al Ejercicio");
                    hayErrores = true;
                }
                else
                {
                    codigoTipoEjercicio = int.Parse(cmdTipoEjercicio.SelectedValue.ToString());
                }

                if (pbMultimedia.Image == null)
                {
                    Errores.SetError(pbMultimedia, "Debe seleccionar una imagen o video a guardar");
                    hayErrores = true;
                }
                else
                {
                    ImageConverter _imageConverter = new ImageConverter();
                    multimedia = (byte[])_imageConverter.ConvertTo(pbMultimedia.Image, typeof(byte[]));
                }

                if (hayErrores)
                {
                    return;
                }

                Logica.InsertarEjercicio(new Ejercicio() { Nombre = nombre, Descripcion = descripcion, CodigoTipo = codigoTipoEjercicio, Multimedia = multimedia});

                MessageBox.Show("Ejercicio insertado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un ejercicio ha sido insertado");

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

        private void btnAsignarImagenVideo_Click(object sender, EventArgs e)
        {
            if (ofdBuscadorMultimedia.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbMultimedia.Image = new Bitmap(ofdBuscadorMultimedia.FileName);
                }
                catch (Exception er)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                    MessageBox.Show("Error: " + er.Message, "Error");
                }
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
                int codigoTipoEjercicio = 0;
                byte[] multimedia = null;

                if ((string.IsNullOrEmpty(txtCodigo.Text)) && dgvEjercicios.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Ejercicio a modificar");
                    return;
                }
                else
                {
                    codigo = int.Parse(txtCodigo.Text);
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    Errores.SetError(txtNombre, "Debe digitar el nombre perteneciente al Ejercicio");
                    hayErrores = true;
                }
                else
                {
                    nombre = txtNombre.Text;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    Errores.SetError(txtDescripcion, "Debe digitar la descripción perteneciente al Ejercicio");
                    hayErrores = true;
                }
                else
                {
                    descripcion = txtDescripcion.Text;
                }

                if (cmdTipoEjercicio.SelectedIndex == -1)
                {
                    Errores.SetError(cmdTipoEjercicio, "Debe seleccionar el Tipo de Ejercicio relacionado al Ejercicio");
                    hayErrores = true;
                }
                else
                {
                    codigoTipoEjercicio = int.Parse(cmdTipoEjercicio.SelectedValue.ToString());
                }

                if (pbMultimedia.Image == null)
                {
                    Errores.SetError(pbMultimedia, "Debe seleccionar una imagen o video a guardar");
                    hayErrores = true;
                }
                else
                {
                    ImageConverter _imageConverter = new ImageConverter();
                    multimedia = (byte[])_imageConverter.ConvertTo(pbMultimedia.Image, typeof(byte[]));
                }

                if (hayErrores)
                {
                    return;
                }

                Logica.ModificarEjercicio(new Ejercicio() { Codigo = codigo, Nombre = nombre, Descripcion = descripcion, CodigoTipo = codigoTipoEjercicio, Multimedia = multimedia });

                MessageBox.Show("Ejercicio modificado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un ejercicio ha sido modificado");

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

        private void dgvEjercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int codigo = int.Parse(dgvEjercicios.SelectedCells[0].Value.ToString());

                Ejercicio ejercicio = Logica.ObtenerEjercicioId(codigo);

                txtCodigo.Text = ejercicio.Codigo.ToString();
                txtNombre.Text = ejercicio.Nombre;
                txtDescripcion.Text = ejercicio.Descripcion;
                cmdTipoEjercicio.SelectedValue = ejercicio.CodigoTipo;
                pbMultimedia.Image = new Bitmap(new MemoryStream(ejercicio.Multimedia));

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtCodigo.Text)) && dgvEjercicios.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Ejercicio a eliminar");
                    return;
                }

                if (new EjercicioEnEntrenamientoBLL().ObtenerEjercicioEnEntrenamientoCodigoEjercicio(int.Parse(txtCodigo.Text)).Count > 0)
                {
                    MessageBox.Show("No se puede eliminar el Ejercicio debido a que Entrenamientos creados dependen de el");
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int codigo = int.Parse(dgvEjercicios.SelectedCells[0].Value.ToString());

                    Logica.EliminarEjercicio(codigo);

                    MessageBox.Show("Ejercicio eliminado!!");
                    _MyLogControlEventos.InfoFormat("Info {0}", "Un ejercicio ha sido eliminado");

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
    }
}
