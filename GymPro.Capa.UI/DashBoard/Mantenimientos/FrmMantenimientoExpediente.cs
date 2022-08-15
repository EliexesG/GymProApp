using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.BLL.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using GymPro.Capa.Logica.Interfaces;
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
    public partial class FrmMantenimientoExpediente : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        IExpedienteUsuarioBLL LogicaExpediente;
        IUsuarioBLL LogicaUsuario;
        Cliente _Cliente;

        IFacturaEncabezadoBLLDatos DatosFactura;
        IFacturaEncabezadoBLLGestor GestorFactura;

        public FrmMantenimientoExpediente()
        {
            InitializeComponent();
            LogicaExpediente = new ExpedienteUsuarioBLL();
            LogicaUsuario = new UsuarioBLL();

            FacturaEncabezadoBLL instancia = new FacturaEncabezadoBLL();
            DatosFactura = instancia;
            GestorFactura = instancia;
        }

        private void FrmMantenimientoExpediente_Load(object sender, EventArgs e)
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

        private void Refrescar()
        {
            try
            {
                if(_Cliente != null)
                {
                    txtIdentificacion.Text = _Cliente.Identificacion;
                    Errores.Clear();

                    dgvExpediente.DataSource = LogicaExpediente.ObtenerExpedienteUsuarioIdentificacionUsuario(_Cliente.Identificacion);
                    dgvExpediente.ClearSelection();

                    pbFotografia.Image = new Bitmap(new MemoryStream(_Cliente.Fotografia));
                }

                txtPeso.Text = "";
                txtAltura.Text = "";
                dtpFechaExpediente.Value = DateTime.Now;
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                Errores.Clear();
                bool hayErrores = false;

                double peso = 0d;
                int altura = 0;
                DateTime fecha = dtpFechaExpediente.Value;

                if(_Cliente == null)
                {
                    MessageBox.Show("Debe buscar el cliente al que se le asignará el Expediente");
                    return;
                }

                if (!double.TryParse(txtPeso.Text, out peso))
                {
                    Errores.SetError(txtPeso, "El peso debe ser un dato numérico en KG");
                    hayErrores = true;
                }

                if (!int.TryParse(txtAltura.Text, out altura))
                {
                    Errores.SetError(txtAltura, "La altura debe ser un dato numérico en CM");
                    hayErrores = true;
                }

                if (hayErrores)
                {
                    return;
                }

                int edad = LogicaUsuario.CalcularEdadUsuario(_Cliente.FechaNacimiento);

                ExpedienteUsuario nuevoExpediente = new ExpedienteUsuario()
                {
                    IdentificacionUsuario = _Cliente.Identificacion,
                    Fecha = fecha,
                    Peso = peso,
                    Altura = altura
                };

                nuevoExpediente.IMC = LogicaExpediente.CalcularIMC(nuevoExpediente);
                nuevoExpediente.MetabolismoBasal = LogicaExpediente.CalcularMetabolismoBasal(nuevoExpediente, edad, _Cliente.Genero);

                LogicaExpediente.InsertarExpedienteUsuario(nuevoExpediente);

                MessageBox.Show("Expediente Insertado!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un expediente de usuario ha sido insertado");

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
                if(dgvExpediente.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar el expediente a eliminar");
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DateTime fecha = DateTime.Parse(dgvExpediente.SelectedCells[0].Value.ToString());

                    string identificacionUsuario = dgvExpediente.SelectedCells[1].Value.ToString();

                    LogicaExpediente.EliminarExpedienteUsuario(fecha, identificacionUsuario);

                    MessageBox.Show("Expediente Eliminado!!");
                    _MyLogControlEventos.InfoFormat("Info {0}", "Un expediente de usuario ha sido eliminado");

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

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Errores.Clear();
                bool hayErrores = false;

                string cedula = "";

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
                    cedula = txtIdentificacion.Text;
                }

                if (hayErrores)
                {
                    return;
                }

                if (!BuscarUsuario(cedula, out _Cliente))
                {
                    MessageBox.Show("No se encontró cliente para asignar Expediente");
                    return;
                }

                try
                {
                    FacturaEncabezado prueba = DatosFactura.ObtenerUltimaFacturaEncabezadoIdentificacionUsuario(_Cliente.Identificacion);
                }
                catch
                {
                    MessageBox.Show("El cliente No ha pagado");
                    return;
                }

                if (GestorFactura.EstaMoroso(DatosFactura.ObtenerUltimaFacturaEncabezadoIdentificacionUsuario(_Cliente.Identificacion).FechaProximoPago))
                {
                    MessageBox.Show("El cliente está moroso, no se puede asignar un Expediente");
                }
                else
                {
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

        private bool BuscarUsuario(string pIdentificacion, out Cliente pCliente)
        {

            bool hayCliente = true;
            pCliente = null;

            try
            {

                IUsuario cliente = LogicaUsuario.ObtenerUsuarioIdentificacion(pIdentificacion);



                if (cliente == null)
                {
                    hayCliente = false;
                }
                else if (!(cliente is Cliente))
                {
                    hayCliente = false;
                }
                else
                {
                    pCliente = cliente as Cliente;
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

            return hayCliente;
        }
    }
}
