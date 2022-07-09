using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IFacturaDetalleBLL
    {
        void EliminarFacturaDetallePorID(FacturaDetalle pFacturaDetalle);
        void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle);
        List<FacturaDetalle> SeleccionarFacturasDetallePorIDFactura(int pId);
        List<FacturaDetalle> SeleccionarTodasFacturaDetalle();
    }
}