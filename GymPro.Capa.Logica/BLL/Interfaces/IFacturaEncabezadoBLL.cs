using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IFacturaEncabezadoBLL
    {
        double CalcularMontoTotal(double pMontoServicios, double pMontoMulta);
        double CalcularMulta(double pMontoServicios);
        void EliminarFacturaEncabezado(int pCodigo);
        bool EstaMoroso(DateTime pFechaSiguientePago);
        void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        void ModificarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);
        FacturaEncabezado ObtenerFacturaEncabezadoId(int pCodigo);
        List<FacturaEncabezado> ObtenerFacturaEncabezadoIdentificacionUsuario(string pIdentificacionUsuario);
        List<FacturaEncabezado> ObtenerFacturaEncabezadoTodas();
        int SiguienteCodigo();
        DateTime SiguientePago(DateTime pFechaPagoActual);
    }
}