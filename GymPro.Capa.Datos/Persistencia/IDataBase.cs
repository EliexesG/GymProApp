using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Persistencia
{
    /// <summary>
    /// Clase que representa la conexion y utilizacion de una base de datos
    /// </summary>
    public interface IDataBase : IDisposable
    {
        /// <summary>
        /// Propiedad de tipo Connection que representa la conexion con la base de datos en esta instancia
        /// </summary>
        IDbConnection Conexion { get; set; }

        /// <summary>
        /// Ejecuta un Non-query en la base de datos en base al comando y nivel de Isolación dado
        /// </summary>
        /// <param name="pCommand">Comando a utilizar</param>
        /// <param name="pIsolationLevel">Nivel de Isolación</param>
        /// <returns>Double con la cantidad de registros afectados</returns>
        double ExecuteNonQuery(IDbCommand pCommand, IsolationLevel pIsolationLevel);

        /// <summary>
        /// Ejecuta un Non-query en la base de datos en base al comando y nivel de Isolación dado
        /// </summary>
        /// <param name="pCommand">Comando a utilizar</param>
        /// <param name="pIsolationLevel">Nivel de Isolación</param>
        void ExecuteNonQuery(ref IDbCommand pCommand, IsolationLevel pIsolationLevel);

        /// <summary>
        /// Ejecuta un Non-query en la base de datos en base los comandos dados y nivel de Isolación dado
        /// </summary>
        /// <param name="pCommands">Comandos a utilizar</param>
        /// <param name="pIsolationLevel"></param>
        void ExecuteNonQuery(List<IDbCommand> pCommands, IsolationLevel pIsolationLevel);

        /// <summary>
        /// Ejecuta un Non-query en la base de datos en base al comando dado
        /// </summary>
        /// <param name="pCommand">Comando a utilizar</param>
        /// <returns>Integer con la cantidad de registros afectados</returns>
        int ExecuteNonQuery(IDbCommand pCommand);

        /// <summary>
        /// Ejecuta un Data Reader (lector conectado) en la base de datos en base al comando dado
        /// </summary>
        /// <param name="pSqlCommand">Comando a utilizar</param>
        /// <returns>Data Reader (Lector conectado) a utilizar</returns>
        IDataReader ExecuteReader(IDbCommand pSqlCommand);

        /// <summary>
        /// Ejecuta un Data Set (Set de datos desconecto) en la base de datos en base al comando dado y la tabla
        /// </summary>
        /// <param name="pSqlCommand">Comando a utilizar</param>
        /// <param name="pTabla">Tabla sobre la cual se hace la lectura</param>
        /// <returns>Un Data Set (Set de datos desconectado) con los datos a utilizar</returns>
        DataSet ExecuteDataSet(IDbCommand pSqlCommand, string pTabla);

        /// <summary>
        /// Ejecuta un Data Set (Set de datos desconecto) en la base de datos en base al comando dado
        /// </summary>
        /// <param name="pCommand">Comando a utilizar</param>
        /// <returns>Un Data Set (Set de datos desconectado) con los datos a utilizar</returns>
        DataSet ExecuteDataSet(IDbCommand pCommand);

        /// <summary>
        /// Ejecuta un Scalar en la base de datos en base al comando dado
        /// </summary>
        /// <param name="pSQLCommand">Comando a utilizar</param>
        /// <returns>Resultado de tipo Object</returns>
        object ExecuteScalar(IDbCommand pSQLCommand);
    }
}
