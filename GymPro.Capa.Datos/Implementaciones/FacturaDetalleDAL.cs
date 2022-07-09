using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class FacturaDetalleDAL : IFacturaDetalleDAL
    {
        private static FacturaDetalleDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo FacturaDetalleDAL
        /// </summary>
        /// <returns></returns>
        public static FacturaDetalleDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new FacturaDetalleDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Inserta un detalle de factura en la base de datos
        /// </summary>
        /// <param name="oFacturaDetalle"></param>
        public void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle)
        {

        }

        /// <summary>
        /// Elimina un detalle de factura de la base de datos por sus Ids
        /// </summary>
        /// <param name="oFacturaDetalle"></param>
        public void EliminarFacturaDetallePorID(FacturaDetalle pFacturaDetalle)
        {

        }

        /// <summary>
        /// Selecciona todas los detalles de factura de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<FacturaDetalle> SeleccionarTodasFacturaDetalle()
        {
            return default;
        }

        /// <summary>
        /// Selecciona todas los detalles de factura de la base de datos en base a la id de factura
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<FacturaDetalle> SeleccionarFacturasDetallePorIDFactura(int pId)
        {
            return default;
        }
    }
}
