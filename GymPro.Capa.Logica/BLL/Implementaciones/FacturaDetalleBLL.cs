using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class FacturaDetalleBLL : IFacturaDetalleBLL
    {
        private IFacturaDetalleDAL oFacturaDetalleDAL;

        public FacturaDetalleBLL()
        {
            oFacturaDetalleDAL = FacturaDetalleDAL.GetInstance();
        }

        #region Logica
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
        /// <summary>
        /// Inserta un Detalle de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaDetalle"> Detalle de Factura a insertar </param>
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

        /// <summary>
        /// Obtiene una lista de los Detalles de Factura en relacion con el Codigo del Encabezado de Factura de la base de datos
        /// </summary>
        /// <param name="pCodigoFactura"> Codigo del Encabezado de Factura relacionado </param>
        /// <returns>Lista de entidades de tipo FacturaDetalle</returns>
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

        /// <summary>
        /// Obtiene una lista de todos los Detalles de Factura de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo FacturaDetalle</returns>
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
