using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IFacturaDetalleBLL
    {
        double CalcularMontoServicios(List<Servicio> pServicios);
        void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle);
        List<FacturaDetalle> ObtenerFacturaDetalleCodigoFactura(int pCodigoFactura);
        List<FacturaDetalle> ObtenerFacturaDetalleTodas();
    }
}