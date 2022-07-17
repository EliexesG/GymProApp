using GymPro.Capa.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class ServicioBCCRDAL : IServicioBCCRDAL
    {
        private static ServicioBCCRDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo SesrvicioBCCRDAL
        /// </summary>
        /// <returns></returns>
        public static ServicioBCCRDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ServicioBCCRDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Obtiene el precio de venta del dolar actualmente del BAC
        /// </summary>
        /// <returns></returns>
        public float ObtenerPrecioVentaDolar()
        {
            try
            {
                WebRequest solicitud = WebRequest.Create("https://gee.bccr.fi.cr/Indicadores/Suscripciones/WS/wsindicadoreseconomicos.asmx");
                WebResponse respuesta = solicitud.GetResponse();
                StreamReader sr = new StreamReader(respuesta.GetResponseStream());

                return 0;
            }
            catch (Exception er)
            {
                throw new Exception($"Ha ocurrido un error al conectarse con el banco: {er.Message}");
            }
        }
    }
}
