﻿using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    public interface IFacturaEncabezadoBLLGestor
    {
        double CalcularMontoServicios(List<Servicio> pServicios);
        double CalcularMontoTotal(double pMontoServicios, double pMontoMulta);
        double CalcularMulta(double pMontoServicios);
        bool EstaMoroso(DateTime pFechaSiguientePago);
        byte[] ObtenerCodigoQR(int codigo);
        int SiguienteCodigo();
        DateTime SiguientePago(DateTime pFechaPagoActual);
        void ValidarTarjeta(Tarjeta pTarjeta);
        bool YaPagado(DateTime pFechaSiguientePago);
    }
}