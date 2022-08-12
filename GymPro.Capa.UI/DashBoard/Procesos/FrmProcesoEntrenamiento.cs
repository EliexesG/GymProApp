using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.BLL.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using GymPro.Capa.Logica.Interfaces;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Procesos
{
    public partial class FrmProcesoEntrenamiento : Form
    {


        private Cliente _Cliente = null;

        IUsuarioBLL LogicaUsuario = new UsuarioBLL();
        IFacturaEncabezadoBLLDatos DatosFactura;
        IFacturaEncabezadoBLLGestor GestorFactura;
        IEntrenamientoBLL LogicaEntrenamiento = new EntrenamientoBLL();
        IDiaEntrenamientoBLL LogicaDias = new DiaEntrenamientoBLL();

        public FrmProcesoEntrenamiento()
        {
            InitializeComponent();

            FacturaEncabezadoBLL instancia = new FacturaEncabezadoBLL();
            DatosFactura = instancia;
            GestorFactura = instancia;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Errores.Clear();
                bool hayErrores = false;

                int tipoBusqueda = 0;
                string datoParaBusqueda = "";

                if (cmbTipoBusqueda.SelectedItem.ToString().Equals("Identificacion"))
                {
                    if (!long.TryParse(txtBusqueda.Text, out long resultado))
                    {
                        Errores.SetError(txtBusqueda, "La identificación del usuario debe contener solamente digitos");
                        hayErrores = true;
                    }
                    else if (resultado.ToString().Length < 9 || resultado.ToString().Length > 15)
                    {
                        Errores.SetError(txtBusqueda, "La identificación del usuario debe contener de entre 9 a 15 dígitos");
                        hayErrores = true;
                    }
                    else if (int.Parse(txtBusqueda.Text[0].ToString()) == 0)
                    {
                        Errores.SetError(txtBusqueda, "La identificación del usuario no puede iniciar en 0");
                        hayErrores = true;
                    }
                    else 
                    {
                        tipoBusqueda = 1;
                        datoParaBusqueda = txtBusqueda.Text;
                    }
                }
                else if (cmbTipoBusqueda.SelectedItem.ToString().Equals("Email"))
                {
                    if (!CorreoValido(txtBusqueda.Text))
                    {
                        Errores.SetError(txtBusqueda, "Debe digitar un correo válido para buscar al usuario");
                        hayErrores = true;
                    }
                    else
                    {
                        tipoBusqueda = 2;
                        datoParaBusqueda = txtBusqueda.Text;
                    }
                }

                if (hayErrores)
                {
                    return;
                }

                if(!BuscarUsuario(tipoBusqueda, datoParaBusqueda, out _Cliente))
                {
                    MessageBox.Show("No se encontró cliente para asignar entrenamiento");
                }
                else if (GestorFactura.EstaMoroso(DatosFactura.ObtenerUltimaFacturaEncabezadoIdentificacionUsuario(_Cliente.Identificacion).FechaProximoPago))
                {
                    MessageBox.Show("El cliente está moroso, no se puede asignar un entrenamiento");
                }
                else
                {
                    pbFotografia.Image = new Bitmap(new MemoryStream(_Cliente.Fotografia));
                    lblNombre.Text = _Cliente.Nombre;
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

        public bool BuscarUsuario(int pTipoBusqueda, string pDatoParaBuscar, out Cliente pCliente)
        {

            bool hayCliente = false;
            pCliente = null;

            try
            {

                List<Cliente> clientes = LogicaUsuario.ObtenerUsuariosCliente();

                if(pTipoBusqueda == 1)
                {
                    pCliente = clientes.FirstOrDefault(cliente => cliente.Identificacion.Equals(pDatoParaBuscar));
                }
                else
                {
                    pCliente = clientes.FirstOrDefault(cliente => cliente.Correo.Equals(pDatoParaBuscar));
                }

                hayCliente = pCliente != null;

            }
            catch (SqlException sqlError)
            {
                MessageBox.Show($"Ha ocurrido un error en la base de datos: {Util.Utilitarios.GetCustomErrorByNumber(sqlError)}");
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }

            return hayCliente;
        }

        private void FrmProcesoEntrenamiento_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTipoBusqueda.Items.Add("Identificacion");
                cmbTipoBusqueda.Items.Add("Email");
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
                cmbTipoBusqueda.SelectedIndex = 0;

                cmbInstructor.DataSource = LogicaUsuario.ObtenerUsuariosInstructor();
                cmbInstructor.DisplayMember = "Nombre";
                cmbInstructor.ValueMember = "Identificacion";
                cmbInstructor.SelectedIndex = -1;

                cmbDiasDisponibles.Items.Clear();
                cmbDiasDisponibles.Items.Add(Dia.Lunes);
                cmbDiasDisponibles.Items.Add(Dia.Martes);
                cmbDiasDisponibles.Items.Add(Dia.Miercoles);
                cmbDiasDisponibles.Items.Add(Dia.Jueves);
                cmbDiasDisponibles.Items.Add(Dia.Viernes);
                cmbDiasDisponibles.Items.Add(Dia.Sabado);
                cmbDiasDisponibles.Items.Add(Dia.Domingo);
                cmbDiasDisponibles.SelectedIndex = -1;

                cmbDiasAgregados.Items.Clear();

                txtCodigo.Text = "";
                txtNombre.Text = "";

                if(_Cliente != null)
                {
                    dgvEntrenamientos.DataSource = LogicaEntrenamiento.ObtenerEntrenamientoIdentificacionUsuarioCliente(_Cliente.Identificacion);
                    dgvEntrenamientos.ClearSelection();
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

        private void cmbTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusqueda.PlaceholderText = cmbTipoBusqueda.SelectedIndex == 0 ? "000000000" : "ejemplo@gmail.com";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Errores.Clear();
                bool hayErrores = false;

                string nombre = "";
                string identificacionCliente = "";
                string identificacionInstructor = "";
                List<Dia> dias = new List<Dia>();

                if (_Cliente == null)
                {
                    MessageBox.Show("No se puede agregar el Entrenamiento si no ha buscado primero al Cliente");
                    return;
                }

                identificacionCliente = _Cliente.Identificacion;

                if (!(string.IsNullOrEmpty(txtCodigo.Text)) && dgvEntrenamientos.SelectedRows.Count >= 1)
                {
                    MessageBox.Show("Previamente se ha seleccionado un Entrenamiento, presione Modificar o Eliminar");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    hayErrores = true;
                    Errores.SetError(txtNombre, "Debe digitar el nombre del entrenamiento");
                }
                else
                {
                    nombre = txtNombre.Text;
                }

                if (cmbInstructor.SelectedIndex == -1)
                {
                    hayErrores = true;
                    Errores.SetError(cmbInstructor, "Debe seleccionar el instructor a asignar al entrenamiento");
                }
                else
                {
                    identificacionInstructor = cmbInstructor.SelectedValue.ToString();
                }

                if (cmbDiasAgregados.Items.Count < 1)
                {
                    hayErrores = true;
                    Errores.SetError(cmbDiasAgregados, "Debe seleccionar los días del entrenamiento");
                }
                else
                {
                    foreach(Dia dia in cmbDiasAgregados.Items)
                    {
                        dias.Add(dia);
                    }
                }

                if (hayErrores)
                {
                    return;
                }

                Entrenamiento nuevoEntrenamiento = new Entrenamiento()
                {
                    IdentificacionCliente = identificacionCliente,
                    IdentificacionEntrenador = identificacionInstructor,
                    Nombre = nombre
                };

                LogicaEntrenamiento.InsertarEntrenamiento(nuevoEntrenamiento);

                int codigoUltimo = LogicaEntrenamiento.UltimoCodigoEntrenamientoAgregadoCliente(_Cliente.Identificacion);

                dias.ForEach(dia => {
                    DiaEntrenamiento diaEntrenamiento = new DiaEntrenamiento()
                    {
                        CodigoEntrenamiento = codigoUltimo,
                        Dia = (int)dia
                    };

                    LogicaDias.InsertarDiaEntrenamiento(diaEntrenamiento);
                });

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

        private void btnAgregarDia_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbDiasDisponibles.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el dia a agregar");
                    return;
                }

                Dia dia = (Dia)cmbDiasDisponibles.SelectedItem;

                cmbDiasDisponibles.Items.Remove(dia);

                cmbDiasAgregados.Items.Add(dia);
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

        private void btnEliminarDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDiasAgregados.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el dia a eliminar");
                    return;
                }

                Dia dia = (Dia)cmbDiasAgregados.SelectedItem;

                cmbDiasAgregados.Items.Remove(dia);

                cmbDiasDisponibles.Items.Add(dia);
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
                if ((string.IsNullOrEmpty(txtCodigo.Text)) && dgvEntrenamientos.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Entrenamiento a eliminar");
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int codigo = int.Parse(dgvEntrenamientos.SelectedCells[0].Value.ToString());

                    LogicaEntrenamiento.EliminarEntrenamiento(codigo);

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
                string nombre = "";
                string identificacionCliente = "";
                string identificacionInstructor = "";
                List<Dia> diasNuevaConfig = new List<Dia>();

                int codigo;

                if (_Cliente == null)
                {
                    MessageBox.Show("No se puede modificar el Entrenamiento si no ha buscado primero al Cliente");
                    return;
                }

                identificacionCliente = _Cliente.Identificacion;

                if ((string.IsNullOrEmpty(txtCodigo.Text)) && dgvEntrenamientos.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Entrenamiento a modificar");
                    return;
                }
                else
                {
                    codigo = int.Parse(txtCodigo.Text);
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    hayErrores = true;
                    Errores.SetError(txtNombre, "Debe digitar el nombre del entrenamiento");
                }
                else
                {
                    nombre = txtNombre.Text;
                }

                if (cmbInstructor.SelectedIndex == -1)
                {
                    hayErrores = true;
                    Errores.SetError(cmbInstructor, "Debe seleccionar el instructor a asignar al entrenamiento");
                }
                else
                {
                    identificacionInstructor = cmbInstructor.SelectedValue.ToString();
                }

                if (cmbDiasAgregados.Items.Count < 1)
                {
                    hayErrores = true;
                    Errores.SetError(cmbDiasAgregados, "Debe seleccionar los días del entrenamiento");
                }
                else
                {
                    foreach (Dia dia in cmbDiasAgregados.Items)
                    {
                        diasNuevaConfig.Add(dia);
                    }
                }

                if (hayErrores)
                {
                    return;
                }

                Entrenamiento modificadoEntrenamiento = new Entrenamiento()
                {
                    Codigo = codigo,
                    IdentificacionCliente = identificacionCliente,
                    IdentificacionEntrenador = identificacionInstructor,
                    Nombre = nombre
                };

                LogicaEntrenamiento.ModificarEntrenamiento(modificadoEntrenamiento);

                List<DiaEntrenamiento> diasEnBase = LogicaDias.ObtenerDiaEntrenamientoCodigoEntrenamiento(codigo);

                ModificarDias(diasNuevaConfig, diasEnBase, codigo);

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

        private void dgvEntrenamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int codigo = int.Parse(dgvEntrenamientos.SelectedCells[0].Value.ToString());

                Entrenamiento entrenamiento = LogicaEntrenamiento.ObtenerEntrenamientoId(codigo);

                txtCodigo.Text = entrenamiento.Codigo.ToString();
                txtNombre.Text = entrenamiento.Nombre.ToString();
                cmbInstructor.SelectedValue = entrenamiento.IdentificacionEntrenador;

                cmbDiasDisponibles.Items.Clear();
                cmbDiasAgregados.Items.Clear();

                LogicaDias.ObtenerDiaDisponibleSobreCodigoEntrenamiento(codigo).ForEach(dia => cmbDiasDisponibles.Items.Add(dia));
                entrenamiento.DiasEntrenamiento.ForEach(dia => cmbDiasAgregados.Items.Add(((Dia)dia.Dia)));

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

        private void ModificarDias(List<Dia> pDiasNuevaConfiguracion, List<DiaEntrenamiento> pDiasEnBase, int pCodigoEntrenamiento)
        {
            try
            {

                List<DiaEntrenamiento> diasBorrar = new List<DiaEntrenamiento>();
                List<DiaEntrenamiento> diasAgregar = new List<DiaEntrenamiento>();

                //Dias a borrar
                pDiasEnBase.ForEach(dia =>
                {
                    if(!pDiasNuevaConfiguracion.Exists(diaBorrar => (int)diaBorrar == dia.Dia)) 
                    {
                        diasBorrar.Add(new DiaEntrenamiento() { CodigoEntrenamiento = pCodigoEntrenamiento, Dia = dia.Dia });
                    }
                });

                //Dias a agregar
                pDiasNuevaConfiguracion.ForEach(dia =>
                {
                    if (!pDiasEnBase.Exists(diaAgregar => (int)dia == diaAgregar.Dia))
                    {
                        diasAgregar.Add(new DiaEntrenamiento() { CodigoEntrenamiento = pCodigoEntrenamiento, Dia = (int)dia });
                    }
                });

                diasBorrar.ForEach(dia => LogicaDias.EliminarDiaEntrenamiento(dia));
                diasAgregar.ForEach(dia => LogicaDias.InsertarDiaEntrenamiento(dia));

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

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = 0;

                if (_Cliente == null)
                {
                    MessageBox.Show("No se puede ver los ejercicios de un Entrenamiento si no ha buscado primero al Cliente");
                    return;
                }

                if ((string.IsNullOrEmpty(txtCodigo.Text)) && dgvEntrenamientos.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el Entrenamiento para ver sus ejercicios");
                    return;
                }
                
                codigo = int.Parse(dgvEntrenamientos.SelectedCells[0].Value.ToString());

                FrmProcesoEjercicioEnEntrenamiento ventana = new FrmProcesoEjercicioEnEntrenamiento(LogicaEntrenamiento.ObtenerEntrenamientoId(codigo));
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
