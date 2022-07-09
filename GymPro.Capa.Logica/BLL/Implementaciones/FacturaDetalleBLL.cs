using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
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

        #region Acceso a datos
        /// <summary>
        /// Inserta un detalle de factura en la base de datos
        /// </summary>
        /// <param name="oFacturaDetalle"></param>
        public void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle)
        {
            try
            {
                oFacturaDetalleDAL.InsertarFacturaDetalle(pFacturaDetalle);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Elimina un detalle de factura de la base de datos por sus Ids
        /// </summary>
        /// <param name="oFacturaDetalle"></param>
        public void EliminarFacturaDetallePorID(FacturaDetalle pFacturaDetalle)
        {
            try
            {
                oFacturaDetalleDAL.EliminarFacturaDetallePorID(pFacturaDetalle);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Selecciona todas los detalles de factura de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<FacturaDetalle> SeleccionarTodasFacturaDetalle()
        {
            try
            {
                return oFacturaDetalleDAL.SeleccionarTodasFacturaDetalle();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Selecciona todas los detalles de factura de la base de datos en base a la id de factura
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<FacturaDetalle> SeleccionarFacturasDetallePorIDFactura(int pId)
        {
            try
            {
                return oFacturaDetalleDAL.SeleccionarFacturasDetallePorIDFactura(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
