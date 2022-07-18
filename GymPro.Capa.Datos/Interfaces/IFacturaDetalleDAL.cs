using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IFacturaDetalleDAL
    {
        void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle);
        List<FacturaDetalle> ObtenerFacturaDetalleTodas();
        List<FacturaDetalle> ObtenerFacturaDetalleCodigoFactura(int pCodigoFactura);
    }
}
