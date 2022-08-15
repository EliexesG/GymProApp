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

namespace GymPro.Capa.UI.DashBoard.Reportes
{
    public partial class FrmReporteEjerciciosPorTIpo : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private ITipoEjercicioBLL oTipoEjercicioBLL = new TipoEjercicioBLL();

        public FrmReporteEjerciciosPorTIpo()
        {
            InitializeComponent();
        }

        private void FrmReporteEjerciciosPorTIpo_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTipoEjercicio.DisplayMember = "Nombre";
                cmbTipoEjercicio.ValueMember = "Codigo";
                cmbTipoEjercicio.DataSource = oTipoEjercicioBLL.ObtenerTipoEjercicioTodos();
                cmbTipoEjercicio.SelectedIndex = -1;
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

        private void cmbTipoEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if(cmbTipoEjercicio.DataSource != null)
                {
                    if(cmbTipoEjercicio.SelectedIndex != -1)
                    {
                        int codigo = int.Parse(cmbTipoEjercicio.SelectedValue.ToString());

                        EjerciciosPorTipoTableAdapter.Fill(DSEjerciciosPorTipo.EjerciciosPorTipo, codigo);
                        this.reportViewer1.RefreshReport();
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
