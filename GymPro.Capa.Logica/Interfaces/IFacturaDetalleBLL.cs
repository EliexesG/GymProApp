using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Detalles de Factura de la base de datos
    /// </summary>
    public interface IFacturaDetalleBLL
    {
        /// <summary>
        /// Calcula el monto total en base a la lista de servicios dada (cada servicio tiene su monto, estos seran calculados y sumados)
        /// </summary>
        /// <param name="pServicios">Lista de entidades de tipo Servicio cuyos montos seran calculados y sumados</param>
        /// <returns>Double representando el total a pagar por los servicios</returns>
        double CalcularMontoServicios(List<Servicio> pServicios);

        /// <summary>
        /// Inserta un Detalle de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaDetalle"> Detalle de Factura a insertar </param>
        void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle);

        /// <summary>
        /// Obtiene una lista de los Detalles de Factura en relacion con el Codigo del Encabezado de Factura de la base de datos
        /// </summary>
        /// <param name="pCodigoFactura"> Codigo del Encabezado de Factura relacionado </param>
        /// <returns>Lista de entidades de tipo FacturaDetalle</returns>
        List<FacturaDetalle> ObtenerFacturaDetalleCodigoFactura(int pCodigoFactura);

        /// <summary>
        /// Obtiene una lista de todos los Detalles de Factura de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo FacturaDetalle</returns>
        List<FacturaDetalle> ObtenerFacturaDetalleTodas();
    }
}