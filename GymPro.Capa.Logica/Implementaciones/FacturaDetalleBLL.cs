using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Implementaciones
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Detalles de Factura de la base de datos
    /// </summary>
    public class FacturaDetalleBLL : IFacturaDetalleBLL
    {
        private IFacturaDetalleDAL oFacturaDetalleDAL;

        public FacturaDetalleBLL()
        {
            oFacturaDetalleDAL = FacturaDetalleDAL.GetInstance();
        }

        #region Logica
        /// <inheritdoc />
        public double CalcularMontoServicios(List<Servicio> pServicios)
        {
            try
            {
                double total = 0D;

                IServicioBLL logicaServicio = new ServicioBLL();

                foreach(Servicio servicio in pServicios)
                {
                    total += logicaServicio.CalcularCostoServicio(servicio);
                }

                return total;
            }
            catch(Exception er)
            {
                throw er;
            }
        }
        #endregion

        #region Acceso a datos
        /// <inheritdoc />
        public void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle)
        {

            try
            {
                oFacturaDetalleDAL.InsertarFacturaDetalle(pFacturaDetalle);
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

        /// <inheritdoc />
        public List<FacturaDetalle> ObtenerFacturaDetalleCodigoFactura(int pCodigoFactura)
        {

            try
            {
                return oFacturaDetalleDAL.ObtenerFacturaDetalleCodigoFactura(pCodigoFactura).OrderBy(detalle => detalle._Servicio.Descripcion).ToList();
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

        /// <inheritdoc />
        public List<FacturaDetalle> ObtenerFacturaDetalleTodas()
        {
            try
            {
                return oFacturaDetalleDAL.ObtenerFacturaDetalleTodas().OrderBy(detalle => detalle.CodigoFactura).ThenBy(detalle => detalle._Servicio.Descripcion).ToList();
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
        #endregion
    }
}
