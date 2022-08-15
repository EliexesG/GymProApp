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
    /// Clase que representa la conexion y utilizacion de una base de datos
    /// </summary>
    public class DataBase : IDataBase, IDisposable
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        /// <inheritdoc />
        public IDbConnection Conexion
        {
            get;
            set;
        }

        /// <inheritdoc />
        public IDataReader ExecuteReader(IDbCommand pCommand)
        {

            IDataReader lector = null;
            try
            {

                pCommand.Connection = Conexion;
                lector = pCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return lector;
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
        public DataSet ExecuteDataSet(IDbCommand pCommand)
        {

            DataSet dsTabla = new DataSet();
            try
            {

                using (SqlDataAdapter adaptador = new SqlDataAdapter(pCommand as SqlCommand))
                {
                    pCommand.Connection = Conexion;
                    dsTabla = new DataSet();
                    adaptador.Fill(dsTabla);
                }
                return dsTabla;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
            finally
            {

                if (dsTabla != null)
                    dsTabla.Dispose();
            }
        }

        /// <inheritdoc />
        public DataSet ExecuteDataSet(IDbCommand pCommand, String pTabla)
        {

            DataSet dsTabla = new DataSet();
            try
            {

                using (SqlDataAdapter adaptador = new SqlDataAdapter(pCommand as SqlCommand))
                {
                    pCommand.Connection = Conexion;
                    dsTabla = new DataSet();
                    adaptador.Fill(dsTabla, pTabla);
                }
                return dsTabla;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
            finally
            {

                if (dsTabla != null)
                    dsTabla.Dispose();
            }
        }

        /// <inheritdoc />
        public double ExecuteNonQuery(IDbCommand pCommand, IsolationLevel pIsolationLevel)
        {
            using (IDbTransaction transaccion = Conexion.BeginTransaction(pIsolationLevel))
            {
                double registrosafectados = 0;
                try
                {

                    pCommand.Connection = Conexion;
                    pCommand.Transaction = transaccion;
                    registrosafectados = pCommand.ExecuteNonQuery();

                    // Commit a la transacción
                    transaccion.Commit();

                    return registrosafectados;
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

        /// <inheritdoc />
        public int ExecuteNonQuery(IDbCommand pCommand)
        {

            int registrosafectados = 0;
            try
            {

                pCommand.Connection = Conexion;

                registrosafectados = pCommand.ExecuteNonQuery();

                return registrosafectados;

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
        public object ExecuteScalar(IDbCommand pCommand)
        {
            object respuesta = null;
            try
            {

                pCommand.Connection = Conexion;

                respuesta = pCommand.ExecuteScalar();

                return respuesta;
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
        public void ExecuteNonQuery(ref IDbCommand pCommand, IsolationLevel pIsolationLevel)
        {
            using (IDbTransaction transaccion = Conexion.BeginTransaction(pIsolationLevel))
            {

                try
                {

                    pCommand.Connection = Conexion;
                    pCommand.Transaction = transaccion;
                    pCommand.ExecuteNonQuery();

                    // Commit a la transacción
                    transaccion.Commit();


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

        /// <inheritdoc />
        public void ExecuteNonQuery(List<IDbCommand> pCommands, IsolationLevel pIsolationLevel)
        {

            try
            {
                using (IDbTransaction transaccion = Conexion.BeginTransaction(pIsolationLevel))
                {
                    foreach (IDbCommand command in pCommands)
                    {
                        command.Connection = (Conexion as SqlConnection);
                        command.Transaction = transaccion;
                        // command.CommandTimeout = int.Parse(System.Configuration.ConfigurationManager.AppSettings["ConnectionTimeOut"].ToString());
                        command.ExecuteNonQuery();
                    }
                    // Commit a la transacción
                    transaccion.Commit();
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
            finally
            {
            }

        }

        public void Dispose()
        {
            if (Conexion != null)
                Conexion.Close();
        }
    }
}
