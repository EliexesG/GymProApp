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

namespace GymPro.Capa.UI.DashBoard.Procesos
{
    public partial class FrmProcesoFacturacion : Form
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private IFacturaEncabezadoBLLDatos LogicaDatos;
        private IFacturaEncabezadoBLLGestor LogicaGestor;
        private IFacturaDetalleBLL LogicaDetalle;
        private IServicioBLL LogicaServicio;

        private Cliente _Cliente;
        private FrmMenuProcesos MenuProcesos;

        private FacturaEncabezado NuevaFacturaEncabezado;
        private List<FacturaDetalle> DetallesFactura;

        public FrmProcesoFacturacion(Cliente pCliente, FrmMenuProcesos pMenuProcesos)
        {
            InitializeComponent();
            _Cliente = pCliente;
            MenuProcesos = pMenuProcesos;

            FacturaEncabezadoBLL instancia = new FacturaEncabezadoBLL();
            LogicaDatos = instancia;
            LogicaGestor = instancia;

            LogicaDetalle = new FacturaDetalleBLL();
            LogicaServicio = new ServicioBLL();

            DetallesFactura = new List<FacturaDetalle>();
        }

        private void FrmProcesoFacturacion_Load(object sender, EventArgs e)
        {
            try
            {

                cmbTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjeta));
                cmbTipoTarjeta.SelectedIndex = -1;

                List<Servicio> servicios = LogicaServicio.ObtenerServicioTodos();


                FacturaEncabezado ultimoPago = null;

                try
                {
                    ultimoPago = LogicaDatos.ObtenerUltimaFacturaEncabezadoIdentificacionUsuario(_Cliente.Identificacion);
                }
                catch { }

                DateTime fecha = DateTime.Now;
                DateTime proxFecha = LogicaGestor.SiguientePago(fecha);
                double montoMatricula = LogicaServicio.CalcularCostoServicio(servicios.FirstOrDefault(servicio => servicio.Descripcion.Equals("Matricula")));
                double montoMensualidad = LogicaServicio.CalcularCostoServicio(servicios.FirstOrDefault(servicio => servicio.Descripcion.Equals("Mensualidad")));
                double montoMulta = 0D;
                double montoServicios = LogicaGestor.CalcularMontoServicios(servicios);

                if (ultimoPago != null)
                {
                    if (LogicaGestor.EstaMoroso(ultimoPago.FechaProximoPago))
                    {
                        montoMulta = LogicaGestor.CalcularMulta(montoServicios);
                    }
                }

                double montoTotal = LogicaGestor.CalcularMontoTotal(montoServicios, montoMulta);

                txtFecha.Text = fecha.Date.ToString();
                txtFechaProximoPago.Text = proxFecha.Date.ToString();
                txtMontoMatricula.Text = montoMatricula.ToString("C");
                txtMontoMensualidad.Text = montoMensualidad.ToString("C");
                txtMontoMulta.Text = montoMulta.ToString("C");
                txtMontoTotal.Text = montoTotal.ToString("C");


                int codigo = LogicaGestor.SiguienteCodigo();

                NuevaFacturaEncabezado = new FacturaEncabezado()
                {
                    Codigo = codigo,
                    CodigoQR = LogicaGestor.ObtenerCodigoQR(codigo),
                    FechaPago = fecha,
                    FechaProximoPago = proxFecha,
                    IdentificacionUsuario = _Cliente.Identificacion,
                    MontoMulta = montoMulta,
                    MontoTotal = montoTotal
                };

                servicios.ForEach(servicio => {
                    DetallesFactura.Add(new FacturaDetalle() { CodigoFactura = codigo, CodigoServicio = servicio.Codigo });
                });

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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {

                if(cmbTipoTarjeta.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el Tipo de Tarjeta");
                    return;
                }

                Tarjeta tarjeta = new Tarjeta()
                {
                    Numero = txtNumeroTarjeta.Text,
                    CodigoSeguridad = txtCodigoTarjeta.Text,
                    AnnoExpiracion = (int)nudAnno.Value,
                    MesExpiracion = (int)nudMes.Value,
                    _TipoTarjeta = (TipoTarjeta)cmbTipoTarjeta.SelectedItem
                };

                LogicaGestor.ValidarTarjeta(tarjeta);


                LogicaDatos.InsertarFacturaEncabezado(NuevaFacturaEncabezado);

                DetallesFactura.ForEach(detalle => LogicaDetalle.InsertarFacturaDetalle(detalle));

                MessageBox.Show("El Pago ha sido registrado exitosamente!!");
                _MyLogControlEventos.InfoFormat("Info {0}", "Un pago ha sido registrado");

                MenuProcesos.AbrirFormEnPanel(new FrmPDFFactura(NuevaFacturaEncabezado.Codigo));
            }
            catch (SqlException sqlError)
            {
                MessageBox.Show($"Ha ocurrido un error en la base de datos: {Util.Utilitarios.GetCustomErrorByNumber(sqlError)}");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
