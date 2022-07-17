using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IFacturaEncabezadoBLL
    {
        void EliminarFacturaEncabezado(int pCodigo);
        void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        void ModificarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        FacturaEncabezado ObtenerFacturaEncabezadoId(int pCodigo);
        List<FacturaEncabezado> ObtenerFacturaEncabezadoIdentificacionUsuario(string pIdentificacionUsuario);
        List<FacturaEncabezado> ObtenerFacturaEncabezadoTodas();
    }
}