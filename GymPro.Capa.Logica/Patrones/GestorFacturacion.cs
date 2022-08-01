using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Patrones
{
    public class GestorFacturacion : IGestorFacturacion
    {
        private IFacturaEncabezadoBLL oLogicaEncabezadoBLL;
        private IFacturaDetalleBLL oLogicaDetalleBLL;

        public GestorFacturacion()
        {
            oLogicaDetalleBLL = new FacturaDetalleBLL();
            oLogicaEncabezadoBLL = new FacturaEncabezadoBLL();
        }

        public byte[] ObtenerCodigoQR(int codigo)
        {
            try
            {
                return CodigoQR.ObtenerCodigoQR(codigo);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public int SiguienteCodigo()
        {
            try
            {
                return oLogicaEncabezadoBLL.SiguienteCodigo();
            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public bool EstaMoroso(DateTime pFechaSiguientePago)
        {
            return oLogicaEncabezadoBLL.EstaMoroso(pFechaSiguientePago);
        }

        public DateTime SiguientePago(DateTime pFechaPagoActual)
        {
            return oLogicaEncabezadoBLL.SiguientePago(pFechaPagoActual);
        }
        public double CalcularMontoServicios(List<Servicio> pServicios)
        {
            try
            {
                return oLogicaDetalleBLL.CalcularMontoServicios(pServicios);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public double CalcularMulta(double pMontoServicios)
        {
            return oLogicaEncabezadoBLL.CalcularMulta(pMontoServicios);
        }

        public double CalcularMontoTotal(double pMontoServicios, double pMontoMulta)
        {
            return oLogicaEncabezadoBLL.CalcularMontoTotal(pMontoServicios, pMontoMulta);
        }
    }
}
