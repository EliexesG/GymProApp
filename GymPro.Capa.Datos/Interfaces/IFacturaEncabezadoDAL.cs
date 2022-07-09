using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IFacturaEncabezadoDAL
    {
        void ActualizarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        void EliminarFacturaEncabezadoPorID(int pId);
        void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        List<FacturaEncabezado> SeleccionarFacturasEncabezadoIDUsaurio(string pIdUsuario);
        List<FacturaEncabezado> SeleccionarTodasFacturasEncabezado();
    }
}