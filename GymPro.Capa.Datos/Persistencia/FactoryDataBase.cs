using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Persistencia
{
    /// <summary>
    /// Clase encargada de crear las representaciones de la base de datos a utilizar
    /// </summary>
    public class FactoryDataBase
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Crea una version Default de la base de datos en base a la conexion encontrada en el proyecto principal
        /// </summary>
        /// <returns>Base de datos a utilizar</returns>
        public static IDataBase CreateDefaultDataBase()
        {
            IDbConnection conexion = null;
            try
            {
                string pStringConnection = FactoryConexion.CreateConnection();

                IDataBase db = new DataBase();

                conexion = new SqlConnection(pStringConnection);

                conexion.Open();

                db.Conexion = conexion;

                if (conexion.State != ConnectionState.Open)
                {

                    Exception er = new Exception("No se pudo abrir la Base de Datos, revise los parámetros de conexión! ");

                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                    throw er;
                }

                return db;
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
        /// Crea una base de datos en base al string de conexion dado por parametro
        /// </summary>
        /// <param name="pStringConnection">String de conexion a utilizar</param>
        /// <returns>Base de datos a utilizar</returns>
        public static IDataBase CreateDataBase(string pStringConnection)
        {
            IDbConnection conexion = null;
            try
            {
                IDataBase db = new DataBase();

                conexion = new SqlConnection(pStringConnection);

                conexion.Open();

                db.Conexion = conexion;

                if (conexion.State != ConnectionState.Open)
                {
                    Exception er = new Exception("No se pudo abrir la Base de Datos, revise los parámetros de conexión! ");

                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                    throw er;
                }

                return db;
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
