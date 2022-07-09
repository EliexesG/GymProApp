using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IFacturaDetalleDAL
    {
        void EliminarFacturaDetallePorID(FacturaDetalle pFacturaDetalle);
        void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle);
        List<FacturaDetalle> SeleccionarFacturasDetallePorIDFactura(int pId);
        List<FacturaDetalle> SeleccionarTodasFacturaDetalle();
    }
}