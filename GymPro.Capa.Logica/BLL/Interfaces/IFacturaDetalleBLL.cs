using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IFacturaDetalleBLL
    {
        void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle);
        List<FacturaDetalle> ObtenerFacturaDetalleCodigoFactura(int pCodigoFactura);
        List<FacturaDetalle> ObtenerFacturaDetalleTodas();
    }
}