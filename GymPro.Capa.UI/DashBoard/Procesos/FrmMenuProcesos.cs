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
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Procesos
{
    public partial class FrmMenuProcesos : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        IUsuario _Usuario;

        public FrmMenuProcesos(IUsuario pUsuario)
        {
            InitializeComponent();
            _Usuario = pUsuario;
        }

        public void AbrirFormEnPanel(object formhija)
        {
            try
            {
                if (this.pnlDisplay.Controls.Count > 0)
                    this.pnlDisplay.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnlDisplay.Controls.Add(fh);
                this.pnlDisplay.Tag = fh;
                fh.Show();
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }

        }

        private void btnControlIngresoEgreso_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FrmProcesoControlIngresoEgreso(_Usuario));
            }
            catch(Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            try
            {

                IFacturaEncabezadoBLLDatos LogicaDatos;
                IFacturaEncabezadoBLLGestor LogicaGestor;

                FacturaEncabezadoBLL instancia = new FacturaEncabezadoBLL();
                LogicaDatos = instancia;
                LogicaGestor = instancia;

                FacturaEncabezado ultimoPago = null;

                try
                {
                    ultimoPago = LogicaDatos.ObtenerUltimaFacturaEncabezadoIdentificacionUsuario(_Usuario.Identificacion);
                }
                catch { }

                if(ultimoPago != null)
                {
                    if (LogicaGestor.YaPagado(ultimoPago.FechaProximoPago))
                    {
                        if(MessageBox.Show("Ya se ha pagado la matrícula y la mensualidad por este mes, ¿Está seguro de pagar nuevamente?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes){
                            AbrirFormEnPanel(new FrmProcesoFacturacion((Cliente)_Usuario, this));
                        }
                    }
                    else
                    {
                        AbrirFormEnPanel(new FrmProcesoFacturacion((Cliente)_Usuario, this));
                    }
                }
                else
                {
                    AbrirFormEnPanel(new FrmProcesoFacturacion((Cliente)_Usuario, this));
                }

            }
            catch (SqlException sqlError)
            {
                MessageBox.Show($"Ha ocurrido un error en la base de datos: {Utilitarios.GetCustomErrorByNumber(sqlError)}");
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void FrmMenuProcesos_Load(object sender, EventArgs e)
        {
            if(_Usuario is Cliente)
            {
                btnEntrenamiento.Enabled = false;
            }
            else if(_Usuario is Instructor || _Usuario is Administrador)
            {
                btnFacturacion.Enabled = false;
            }
        }

        private void btnEntrenamiento_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FrmProcesoEntrenamiento(this));
            }
            catch (Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }
    }
}
