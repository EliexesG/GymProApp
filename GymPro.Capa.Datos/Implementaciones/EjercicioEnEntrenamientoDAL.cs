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
    /// Clase de acceso a datos para los Ejercicios en Entrenamientos de la base de datos
    /// </summary>
    public class EjercicioEnEntrenamientoDAL : IEjercicioEnEntrenamientoDAL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static EjercicioEnEntrenamientoDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo EjercicioEnEntrenamientoDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static EjercicioEnEntrenamientoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new EjercicioEnEntrenamientoDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public void EliminarEjercicioEnEntrenamiento(int pCodigoEntrenamiento, int pCodigoEjercicio)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Eliminar_EjercicioEnEntrenamiento";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pCodigoEntrenamiento);
            comando.Parameters.AddWithValue("@CodigoEjercicio", pCodigoEjercicio);

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
        public void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_EjercicioEnEntrenamiento";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pEjercicioEnEntrenamiento.CodigoEntrenamiento);
            comando.Parameters.AddWithValue("@CodigoEjercicio", pEjercicioEnEntrenamiento.CodigoEjercicio);
            comando.Parameters.AddWithValue("@Repeticiones", pEjercicioEnEntrenamiento.Repeticiones);
            comando.Parameters.AddWithValue("@Peso", pEjercicioEnEntrenamiento.Peso);
            comando.Parameters.AddWithValue("@Series", pEjercicioEnEntrenamiento.Series);
            comando.Parameters.AddWithValue("@Tiempo", pEjercicioEnEntrenamiento.Tiempo);

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
        public void ModificarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Modificar_EjercicioEnEntrenamiento";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pEjercicioEnEntrenamiento.CodigoEntrenamiento);
            comando.Parameters.AddWithValue("@CodigoEjercicio", pEjercicioEnEntrenamiento.CodigoEjercicio);
            comando.Parameters.AddWithValue("@Repeticiones", pEjercicioEnEntrenamiento.Repeticiones);
            comando.Parameters.AddWithValue("@Peso", pEjercicioEnEntrenamiento.Peso);
            comando.Parameters.AddWithValue("@Series", pEjercicioEnEntrenamiento.Series);
            comando.Parameters.AddWithValue("@Tiempo", pEjercicioEnEntrenamiento.Tiempo);

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
        public List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento)
        {

            List<EjercicioEnEntrenamiento> lista = new List<EjercicioEnEntrenamiento>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_EjercicioEnEntrenamiento_CodigoEntrenamientoo";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pCodigoEntrenamiento);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        EjercicioEnEntrenamiento ejercicioEnEntrenamiento = new EjercicioEnEntrenamiento()
                        {
                            CodigoEntrenamiento = int.Parse(dr["CodigoEntrenamiento"].ToString()),
                            CodigoEjercicio = int.Parse(dr["CodigoEjercicio"].ToString()),
                            Repeticiones = int.Parse(dr["Repeticiones"].ToString()),
                            Peso = float.Parse(dr["Peso"].ToString()),
                            Series = dr["Series"].ToString(),
                            Tiempo = int.Parse(dr["Tiempo"].ToString())
                        };

                        ejercicioEnEntrenamiento._Ejercicio = EjercicioDAL.GetInstance().ObtenerEjercicioId(ejercicioEnEntrenamiento.CodigoEjercicio);

                        lista.Add(ejercicioEnEntrenamiento);

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
        public EjercicioEnEntrenamiento ObtenerEjercicioEnEntrenamientoId(int pCodigoEntrenamiento, int pCodigoEjercicio)
        {

            EjercicioEnEntrenamiento ejercicioEnEntrenamiento = null;

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_EjercicioEnEntrenamiento_Id";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pCodigoEntrenamiento);
            comando.Parameters.AddWithValue("@CodigoEjercicio", pCodigoEjercicio);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    IDataReader reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        ejercicioEnEntrenamiento = new EjercicioEnEntrenamiento()
                        {
                            CodigoEntrenamiento = int.Parse(reader["CodigoEntrenamiento"].ToString()),
                            CodigoEjercicio = int.Parse(reader["CodigoEjercicio"].ToString()),
                            Repeticiones = int.Parse(reader["Repeticiones"].ToString()),
                            Peso = float.Parse(reader["Peso"].ToString()),
                            Series = reader["Series"].ToString(),
                            Tiempo = int.Parse(reader["Tiempo"].ToString())
                        };

                        ejercicioEnEntrenamiento._Ejercicio = EjercicioDAL.GetInstance().ObtenerEjercicioId(ejercicioEnEntrenamiento.CodigoEjercicio);
                    }

                }

                return ejercicioEnEntrenamiento;

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
        public List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoTodos()
        {

            List<EjercicioEnEntrenamiento> lista = new List<EjercicioEnEntrenamiento>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_EjercicioEnEntrenamiento_Todos";

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        EjercicioEnEntrenamiento ejercicioEnEntrenamiento = new EjercicioEnEntrenamiento()
                        {
                            CodigoEntrenamiento = int.Parse(dr["CodigoEntrenamiento"].ToString()),
                            CodigoEjercicio = int.Parse(dr["CodigoEjercicio"].ToString()),
                            Repeticiones = int.Parse(dr["Repeticiones"].ToString()),
                            Peso = float.Parse(dr["Peso"].ToString()),
                            Series = dr["Series"].ToString(),
                            Tiempo = int.Parse(dr["Tiempo"].ToString())
                        };

                        ejercicioEnEntrenamiento._Ejercicio = EjercicioDAL.GetInstance().ObtenerEjercicioId(ejercicioEnEntrenamiento.CodigoEjercicio);

                        lista.Add(ejercicioEnEntrenamiento);

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
    }
}
