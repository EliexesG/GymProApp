using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Persistencia
{
    /// <summary>
    /// Clase encargada de crear las conexiones con la base de datos
    /// </summary>
    public class FactoryConexion
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Crea una conexion con la base de datos en base a la Cadena de conexion encontrada en las propiedades del proyecto principal
        /// </summary>
        /// <returns>String de la conexion a utilizar</returns>
        public static string CreateConnection()
        {
            try
            {
                // Lee la conexion default
                return ConfigurationManager.ConnectionStrings["GymPro.Capa.UI.Properties.Settings.Cadena"].ConnectionString;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }

        }

        /// <summary>
        /// Crea una conexion con la base de datos en base al nombre da la Cadena de conexion dado por parametro
        /// </summary>
        /// <param name="nombre">Nombre de Cadena de conexion a utilizar</param>
        /// <returns>String de la conexion a utilizar</returns>
        public static string CreateConnection(string nombre)
        {
            try
            {
                // Lee la conexion default
                return ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        /// <summary>
        /// Crea una conexion con la base de datos utilizando las credenciales dadas por parametro
        /// </summary>
        /// <param name="pUsuario">Nombre del usuario en SQL Server</param>
        /// <param name="pContrasena">Contrasenna del Usuario en SQL Server</param>
        /// <returns>String de la conexion a utilizar</returns>
        public static string CreateConnection(string pUsuario, String pContrasena)
        {
            try
            {
                StringBuilder conexion = new StringBuilder();
                // Lee la conexion default
                conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
                // Agrega al usuario
                conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);

                return conexion.ToString();
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
