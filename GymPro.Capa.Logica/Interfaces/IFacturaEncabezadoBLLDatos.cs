using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IFacturaEncabezadoBLLDatos
    {
        void EliminarFacturaEncabezado(int pCodigo);
        void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        void ModificarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        FacturaEncabezado ObtenerFacturaEncabezadoId(int pCodigo);
        List<FacturaEncabezado> ObtenerFacturaEncabezadoIdentificacionUsuario(string pIdentificacionUsuario);
        List<FacturaEncabezado> ObtenerFacturaEncabezadoTodas();
        FacturaEncabezado ObtenerUltimaFacturaEncabezadoIdentificacionUsuario(string pIdentificacion);
    }
}