using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IFacturaEncabezadoDAL
    {
        void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        void ModificarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        void EliminarFacturaEncabezado(int pCodigo);
        List<FacturaEncabezado> ObtenerFacturaEncabezadoTodas();
        FacturaEncabezado ObtenerFacturaEncabezadoId(int pCodigo);
        List<FacturaEncabezado> ObtenerFacturaEncabezadoIdentificacionUsuario(string pIdentificacionUsuario);
    }
}
