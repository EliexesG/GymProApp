using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Detalles de Facturas de la base de datos
    /// </summary>
    public interface IFacturaDetalleDAL
    {
        /// <summary>
        /// Inserta un Detalle de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaDetalle"> Detalle de Factura a insertar </param>
        void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle);

        /// <summary>
        /// Obtiene una lista de todos los Detalles de Factura de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo FacturaDetalle</returns>
        List<FacturaDetalle> ObtenerFacturaDetalleTodas();

        /// <summary>
        /// Obtiene una lista de los Detalles de Factura en relacion con el Codigo del Encabezado de Factura de la base de datos
        /// </summary>
        /// <param name="pCodigoFactura"> Codigo del Encabezado de Factura relacionado </param>
        /// <returns>Lista de entidades de tipo FacturaDetalle</returns>
        List<FacturaDetalle> ObtenerFacturaDetalleCodigoFactura(int pCodigoFactura);
    }
}
