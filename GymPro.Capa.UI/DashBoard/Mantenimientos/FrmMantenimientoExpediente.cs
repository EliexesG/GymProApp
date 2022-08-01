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
    public partial class FrmMantenimientoExpediente : Form
    {

        IExpedienteUsuarioBLL LogicaExpediente;
        IUsuarioBLL LogicaUsuario;
        Cliente _Cliente;

        public FrmMantenimientoExpediente(Cliente pCliente)
        {
            InitializeComponent();
            _Cliente = pCliente;
            LogicaExpediente = new ExpedienteUsuarioBLL();
            LogicaUsuario = new UsuarioBLL();
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
                txtIdentificacion.Text = _Cliente.Identificacion;
                Errores.Clear();

                dgvExpediente.DataSource = LogicaExpediente.ObtenerExpedienteUsuarioIdentificacionUsuario(_Cliente.Identificacion);
                dgvExpediente.ClearSelection();

                txtPeso.Text = "";
                txtAltura.Text = "";
                dtpFechaExpediente.Value = DateTime.Now;
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
