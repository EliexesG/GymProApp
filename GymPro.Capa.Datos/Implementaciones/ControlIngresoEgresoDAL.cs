using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Datos.Persistencia;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    /// <summary>
    /// Clase de acceso a datos para el Control de Ingreso y Egresos de la base de datos
    /// </summary>
    public class ControlIngresoEgresoDAL : IControlIngresoEgresoDAL
    {
        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static ControlIngresoEgresoDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo ControlIngresoEgresoDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static ControlIngresoEgresoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ControlIngresoEgresoDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public void InsertarIngreso(ControlIngresoEgreso pControlIngresoEgreso)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_Ingreso";
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pControlIngresoEgreso.IdentificacionUsuario);
            comando.Parameters.AddWithValue("@Fecha", pControlIngresoEgreso.Fecha.Date);
            comando.Parameters.AddWithValue("@HoraEntrada", pControlIngresoEgreso.HoraEntrada);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    db.ExecuteNonQuery(comando);

                }

            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
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
        public void ModificarEgreso(ControlIngresoEgreso pControlIngresoEgreso)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Modificar_Egreso";
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pControlIngresoEgreso.IdentificacionUsuario);
            comando.Parameters.AddWithValue("@Fecha", pControlIngresoEgreso.Fecha.Date);
            comando.Parameters.AddWithValue("@HoraSalida", pControlIngresoEgreso.HoraSalida);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    db.ExecuteNonQuery(comando);

                }

            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
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
        public List<ControlIngresoEgreso> ObtenerControlIngresoEgresoIdentificacionUsuario(string pIdentificacionUsuario)
        {

            List<ControlIngresoEgreso> lista = new List<ControlIngresoEgreso>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_ControlIngresoEgreso_IdentificacionUsuario";
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pIdentificacionUsuario);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {

                        TimeSpan? horaSalida = null;

                        if (!string.IsNullOrWhiteSpace(dr["HoraSalida"].ToString()))
                        {
                            horaSalida = TimeSpan.Parse(dr["HoraSalida"].ToString());
                        }

                        ControlIngresoEgreso controlIngresoEgreso = new ControlIngresoEgreso()
                        {
                            IdentificacionUsuario = dr["IdentificacionUsuario"].ToString(),
                            Fecha = DateTime.Parse(dr["Fecha"].ToString()),
                            HoraEntrada = TimeSpan.Parse(dr["HoraEntrada"].ToString()),
                            HoraSalida = horaSalida
                        };

                        lista.Add(controlIngresoEgreso);
                    }

                }

                return lista;

            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
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
        public List<ControlIngresoEgreso> ObtenerControlIngresoEgresoTodos()
        {

            List<ControlIngresoEgreso> lista = new List<ControlIngresoEgreso>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_ControlIngresoEgreso_Todos";

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        TimeSpan? horaSalida = null;

                        if (!string.IsNullOrWhiteSpace(dr["HoraSalida"].ToString()))
                        {
                            horaSalida = TimeSpan.Parse(dr["HoraSalida"].ToString());
                        }

                        ControlIngresoEgreso controlIngresoEgreso = new ControlIngresoEgreso()
                        {
                            IdentificacionUsuario = dr["IdentificacionUsuario"].ToString(),
                            Fecha = DateTime.Parse(dr["Fecha"].ToString()),
                            HoraEntrada = TimeSpan.Parse(dr["HoraEntrada"].ToString()),
                            HoraSalida = horaSalida

                        };

                        lista.Add(controlIngresoEgreso);
                    }

                }

                return lista;

            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
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
        public ControlIngresoEgreso ObtenerControlIngresoEgresoUltimoIdentificacionUsuario(string pIdentificacionUsuario)
        {

            ControlIngresoEgreso controlIngresoEgreso = null;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_ControlIngresoEgreso_Ultimo_IdentificacionUsuario";
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pIdentificacionUsuario);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    IDataReader reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {

                        TimeSpan? horaSalida = null;

                        if (!string.IsNullOrWhiteSpace(reader["HoraSalida"].ToString()))
                        {
                            horaSalida = TimeSpan.Parse(reader["HoraSalida"].ToString());
                        }

                        controlIngresoEgreso = new ControlIngresoEgreso()
                        {
                            IdentificacionUsuario = reader["IdentificacionUsuario"].ToString(),
                            Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                            HoraEntrada = TimeSpan.Parse(reader["HoraEntrada"].ToString()),
                            HoraSalida = horaSalida

                        };
                    }

                }

                return controlIngresoEgreso;

            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
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
