using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Servicios
{
    /// <summary>
    /// Clase de llamadas hacia la API del Banco BCCR
    /// </summary>
    public class ServicioVentaDolarDAL : IServicioVentaDolarDAL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static ServicioVentaDolarDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo ServicioVentaDolarDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static ServicioVentaDolarDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ServicioVentaDolarDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public double ObtenerPrecioVentaDolar()
        {
            try
            {
                HttpClient client = new HttpClient();
                string path = "";
                string json = "";

                path = @"https://tipodecambio.paginasweb.cr/api";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                json = sr.ReadToEnd();

                return (JsonGenerics<JsonDatos>.JsonAObjeto(json)).venta;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }
    }
}
