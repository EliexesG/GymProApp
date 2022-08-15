using GymPro.Capa.Entidades.Implementaciones;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Procesos
{
    public partial class FrmProcesoEjercicioEnEntrenamiento : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private Entrenamiento _Entrenamiento;

        private IEjercicioBLL LogicaEjercicio = new EjercicioBLL();
        private IEjercicioEnEntrenamientoBLL LogicaEjercicioEnEntrenamiento = new EjercicioEnEntrenamientoBLL();
        private ITipoEjercicioBLL LogicaTipoEjercicio = new TipoEjercicioBLL();

        public FrmProcesoEjercicioEnEntrenamiento(Entrenamiento pEntrenamiento)
        {
            InitializeComponent();
            _Entrenamiento = pEntrenamiento;
            dgvEjercicioEnEntrenamiento.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Metodo que refresca lo controles en la ventana
        /// </summary>
        private void Refrescar()
        {
            try
            {

                txtNombreEntrenamiento.Text = _Entrenamiento.Nombre;

                cmbTipoEjercicio.ValueMember = "Codigo";
                cmbTipoEjercicio.DisplayMember = "Nombre";
                cmbTipoEjercicio.DataSource = LogicaTipoEjercicio.ObtenerTipoEjercicioTodos();
                cmbTipoEjercicio.SelectedIndex = -1;

                LlenarEjercicioTodos();

                LlenarDgvEjericiciosEnEntrenamiento();

                cmbEjercicio.Enabled = true;
                cmbTipoEjercicio.Enabled = true;

                txtSeries.Text = "";
                txtTiempo.Text = "";
                txtRepeticiones.Text = "";
                txtPeso.Text = "";

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
        /// Metodo que repobla de con data el ComboBox de Ejercicios con todos aquellos disponibles no presentes en el entrenamiento
        /// </summary>
        private void LlenarEjercicioTodos()
        {

            try
            {

                cmbEjercicio.Items.Clear();

                foreach(Ejercicio ejercicio in LogicaEjercicio.ObtenerEjercicioDisponibleCodigoEntrenamiento(_Entrenamiento.Codigo))
                {
                    cmbEjercicio.Items.Add(ejercicio);
                }

                cmbEjercicio.DisplayMember = "Nombre";
                cmbEjercicio.ValueMember = "Codigo";
                cmbEjercicio.SelectedIndex = -1;
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

        private void FrmProcesoEjercicioEnEntrenamiento_Load(object sender, EventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }

        private void cmbTipoEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbTipoEjercicio.DataSource != null)
                {
                    if(cmbTipoEjercicio.SelectedIndex != -1)
                    {
                        int tipoEjercicio = int.Parse(cmbTipoEjercicio.SelectedValue.ToString());

                        cmbEjercicio.Items.Clear();

                        foreach(Ejercicio ejercicio in LogicaEjercicio.ObtenerEjercicioDisponibleCodigoEntrenamientoYTipoEjercicio(_Entrenamiento.Codigo, tipoEjercicio))
                        {
                            cmbEjercicio.Items.Add(ejercicio);
                        }

                        cmbEjercicio.DisplayMember = "Nombre";
                        cmbEjercicio.ValueMember = "Codigo";
                        cmbEjercicio.SelectedIndex = -1;
                    }
                }
                    
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

        /// <summary>
        /// Metodo que repobla de con data el DataGridView de los Ejercicios del Entrenamiento
        /// </summary>
        public void LlenarDgvEjericiciosEnEntrenamiento()
        {
            try
            {

                dgvEjercicioEnEntrenamiento.Rows.Clear();

                dgvEjercicioEnEntrenamiento.ColumnCount = 6;

                dgvEjercicioEnEntrenamiento.Columns[0].Name = "IdEjercicio";
                dgvEjercicioEnEntrenamiento.Columns[1].Name = "Nombre";
                dgvEjercicioEnEntrenamiento.Columns[2].Name = "Repeticiones";
                dgvEjercicioEnEntrenamiento.Columns[3].Name = "Series";
                dgvEjercicioEnEntrenamiento.Columns[4].Name = "Peso";
                dgvEjercicioEnEntrenamiento.Columns[5].Name = "Tiempo";

                foreach (EjercicioEnEntrenamiento ejercicioEnEntrenamiento in LogicaEjercicioEnEntrenamiento.ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(_Entrenamiento.Codigo))
                {
                    Object[] data = { ejercicioEnEntrenamiento.CodigoEjercicio, ejercicioEnEntrenamiento._Ejercicio.Nombre, ejercicioEnEntrenamiento.Repeticiones, ejercicioEnEntrenamiento.Series, ejercicioEnEntrenamiento.Peso, ejercicioEnEntrenamiento.Tiempo };

                    dgvEjercicioEnEntrenamiento.Rows.Add(data);
                }

                dgvEjercicioEnEntrenamiento.ClearSelection();
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

        /// <summary>
        /// Metodo que verifica que el formato de series sea correcto (0x00)
        /// </summary>
        /// <param name="pDatoSeries">Series del ejercicio a verificar</param>
        /// <returns>Bool representando si es correcto o no</returns>
        private bool FormatoSeriesValido(string pDatoSeries)
        {
            var regex = new Regex(@"^[\d]{1}[x][\d]+$");

            if (regex.IsMatch(pDatoSeries))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Errores.Clear();
                bool hayErrores = false;

                int codigoEntrenamiento = _Entrenamiento.Codigo;
                int codigoEjercicio = 0;
                int repeticiones = 0;
                float peso = 0f;
                string series = "";
                int tiempo = 0;

                if (dgvEjercicioEnEntrenamiento.SelectedRows.Count >= 1)
                {
                    MessageBox.Show("Previamente se ha seleccionado un Ejercicio del Entrenamiento, presione Modificar o Eliminar");
                    return;
                }

                if(cmbEjercicio.SelectedIndex == -1)
                {
                    Errores.SetError(cmbEjercicio, "Debe seleccionar el ejercicio que se desea agregar");
                    hayErrores = true;
                }
                else
                {
                    codigoEjercicio = (cmbEjercicio.SelectedItem as Ejercicio).Codigo;
                }

                if(!int.TryParse(txtRepeticiones.Text, out repeticiones))
                {
                    Errores.SetError(txtRepeticiones, "Debe digitar la cantidad de repeticiones por serie del ejercicio en formato numérico");
                    hayErrores = true;
                }

                if (!float.TryParse(txtPeso.Text, out peso))
                {
                    Errores.SetError(txtPeso, "Debe digitar la cantidad de peso a utilizar en el ejercicio / si este no utiliza peso digite 0");
                    hayErrores = true;
                }

                if (!FormatoSeriesValido(txtSeries.Text))
                {
                    Errores.SetError(txtSeries, "Debe digitar un formato valido para las series. Ejem: \"4x12\" (4 series de 12)");
                    hayErrores = true;
                }
                else
                {
                    series = txtSeries.Text;
                }

                if (!int.TryParse(txtTiempo.Text, out tiempo))
                {
                    Errores.SetError(txtTiempo, "Debe digitar la cantidad de minutos de descanso por serie del ejercicio en formato numérico");
                    hayErrores = true;
                }

                if (hayErrores)
                {
                    return;
                }

                EjercicioEnEntrenamiento nuevoEjercicioEnEntrenamiento = new EjercicioEnEntrenamiento()
                {
                    CodigoEjercicio = codigoEjercicio,
                    CodigoEntrenamiento = codigoEntrenamiento,
                    Peso = peso,
                    Tiempo = tiempo,
                    Repeticiones = repeticiones,
                    Series = series
                };

                LogicaEjercicioEnEntrenamiento.InsertarEjercicioEnEntrenamiento(nuevoEjercicioEnEntrenamiento);

                MessageBox.Show("Ejercicio en Entrenamiento insertado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un ejercicio en entranamiento ha sido insertado");

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

                int codigoEntrenamiento = _Entrenamiento.Codigo;
                int codigoEjercicio = 0;
                int repeticiones = 0;
                float peso = 0f;
                string series = "";
                int tiempo = 0;

                if (dgvEjercicioEnEntrenamiento.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Ejercicio del Entrenamiento a modificar");
                    return;
                }

                codigoEjercicio = int.Parse(dgvEjercicioEnEntrenamiento.SelectedCells[0].Value.ToString());

                if (!int.TryParse(txtRepeticiones.Text, out repeticiones))
                {
                    Errores.SetError(txtRepeticiones, "Debe digitar la cantidad de repeticiones por serie del ejercicio en formato numérico");
                    hayErrores = true;
                }

                if (!float.TryParse(txtPeso.Text, out peso))
                {
                    Errores.SetError(txtPeso, "Debe digitar la cantidad de peso a utilizar en el ejercicio / si este no utiliza peso digite 0");
                    hayErrores = true;
                }

                if (!FormatoSeriesValido(txtSeries.Text))
                {
                    Errores.SetError(txtSeries, "Debe digitar un formato valido para las series. Ejem: \"4x12\" (4 series de 12)");
                    hayErrores = true;
                }
                else
                {
                    series = txtSeries.Text;
                }

                if (!int.TryParse(txtTiempo.Text, out tiempo))
                {
                    Errores.SetError(txtTiempo, "Debe digitar la cantidad de minutos de descanso por serie del ejercicio en formato numérico");
                    hayErrores = true;
                }

                if (hayErrores)
                {
                    return;
                }

                EjercicioEnEntrenamiento ejercicioModificar = new EjercicioEnEntrenamiento()
                {
                    CodigoEntrenamiento = codigoEntrenamiento,
                    CodigoEjercicio = codigoEjercicio,
                    Peso = peso,
                    Series = series,
                    Repeticiones = repeticiones,
                    Tiempo = tiempo
                };

                LogicaEjercicioEnEntrenamiento.ModificarEjercicioEnEntrenamiento(ejercicioModificar);

                MessageBox.Show("Ejercicio en Entrenamiento modificado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un ejercicio en entranamiento ha sido modificado");

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

        private void dgvEjercicioEnEntrenamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int codigoEjercicio = int.Parse(dgvEjercicioEnEntrenamiento.SelectedCells[0].Value.ToString());


                EjercicioEnEntrenamiento ejercicioSeleccionado = LogicaEjercicioEnEntrenamiento.ObtenerEjercicioEnEntrenamientoId(_Entrenamiento.Codigo, codigoEjercicio);

                cmbTipoEjercicio.SelectedValue = ejercicioSeleccionado._Ejercicio.CodigoTipo;

                cmbEjercicio.Items.Add(ejercicioSeleccionado._Ejercicio);
                cmbEjercicio.SelectedItem = ejercicioSeleccionado._Ejercicio;

                cmbTipoEjercicio.Enabled = false;
                cmbEjercicio.Enabled = false;
                

                txtPeso.Text = ejercicioSeleccionado.Peso.ToString();
                txtRepeticiones.Text = ejercicioSeleccionado.Repeticiones.ToString();
                txtSeries.Text = ejercicioSeleccionado.Series;
                txtTiempo.Text = ejercicioSeleccionado.Tiempo.ToString();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEjercicioEnEntrenamiento.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Ejercicio del Entrenamiento a eliminar");
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int codigoEjercicio = int.Parse(dgvEjercicioEnEntrenamiento.SelectedCells[0].Value.ToString());

                    LogicaEjercicioEnEntrenamiento.EliminarEjercicioEnEntrenamiento(_Entrenamiento.Codigo, codigoEjercicio);

                    MessageBox.Show("Ejercicio en Entrenamiento eliminado!!");
                    _MyLogControlEventos.InfoFormat("Info {0}", "Un ejercicio en entranamiento ha sido eliminado");

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
