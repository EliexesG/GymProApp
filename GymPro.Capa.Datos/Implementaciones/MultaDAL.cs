using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    /// <summary>
    /// Clase de acceso a datos para el Porcentaje de Multa de un JSON local
    /// </summary>
    public class MultaDAL : IMultaDAL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static MultaDAL Instancia;

        private const string RutaDirectorio = @"C:\Windows\Temp";
        private const string RutaJSON = @"C:\Windows\Temp\Multa.json";
        private const double PorcentajeBaseMulta = 0.17;

        /// <summary>
        /// Retorna una instancia de tipo MultaDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static MultaDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new MultaDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public Multa ObtenerMulta()
        {
            try
            {
                if (!Directory.Exists(RutaDirectorio))
                {
                    Directory.CreateDirectory(RutaDirectorio);
                }

                if (!File.Exists(RutaJSON))
                {

                    Multa multaBase = new Multa() { PorcentajeMulta = PorcentajeBaseMulta };

                    string json = Util.JsonGenerics<Multa>.ObjetoAJSON(multaBase);

                    File.WriteAllText(RutaJSON, json);
                }

                string dataTraer = File.ReadAllText(RutaJSON);
                return Util.JsonGenerics<Multa>.JsonAObjeto(dataTraer);
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        /// <inheritdoc />
        public void ModificarMulta(Multa pMulta)
        {
            try
            {
                if (!Directory.Exists(RutaDirectorio))
                {
                    Directory.CreateDirectory(RutaDirectorio);
                }

                string json = Util.JsonGenerics<Multa>.ObjetoAJSON(pMulta);

                File.WriteAllText(RutaJSON, json);
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
