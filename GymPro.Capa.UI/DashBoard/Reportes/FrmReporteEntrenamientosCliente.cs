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

namespace GymPro.Capa.UI.DashBoard.Reportes
{
    public partial class FrmReporteEntrenamientosCliente : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        IUsuarioBLL LogicaUsuario = new UsuarioBLL();
        IEntrenamientoBLL LogicaEntrenamiento = new EntrenamientoBLL();

        public FrmReporteEntrenamientosCliente()
        {
            InitializeComponent();
        }

        private void FrmReporteEntrenamientosCliente_Load(object sender, EventArgs e)
        {
            try
            {
                cmbClientes.DisplayMember = "Nombre";
                cmbClientes.ValueMember = "Identificacion";
                cmbClientes.DataSource = LogicaUsuario.ObtenerUsuariosCliente();
                cmbClientes.SelectedValue = -1;
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

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbClientes.DataSource != null)
                {
                    if(cmbClientes.SelectedIndex != -1)
                    {

                        if(cmbClientes.SelectedValue == null)
                        {
                            return;
                        }

                        string identificacion = cmbClientes.SelectedValue.ToString();

                        cmbEntrenamientos.DataSource = LogicaEntrenamiento.ObtenerEntrenamientoIdentificacionUsuarioCliente(identificacion);
                        cmbEntrenamientos.DisplayMember = "Nombre";
                        cmbEntrenamientos.ValueMember = "Codigo";
                        cmbEntrenamientos.SelectedIndex = -1;
                    }
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

        private void cmbEntrenamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEntrenamientos.DataSource != null)
                {
                    if (cmbEntrenamientos.SelectedIndex != -1)
                    {

                        if (cmbEntrenamientos.SelectedValue == null)
                        {
                            return;
                        }

                        string identificacion = cmbClientes.SelectedValue.ToString();
                        int codigo = int.Parse(cmbEntrenamientos.SelectedValue.ToString());

                        EntrenamientoTableAdapter.Fill(DSEntrenamientoCliente.Entrenamiento, identificacion, codigo);
                        reportViewer1.RefreshReport();

                    }
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                MessageBox.Show($"Ha ocurrido un error: {er.Message}");

            }
        }
    }
}
