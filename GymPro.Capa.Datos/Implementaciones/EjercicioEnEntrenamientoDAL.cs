using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Datos.Persistencia;
using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class EjercicioEnEntrenamientoDAL : IEjercicioEnEntrenamientoDAL
    {
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

        /// <summary>
        /// Elimina un Ejercicio de Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento">Codigo del entrenamiento relacionado al ejercicio a eliminar</param>
        /// <param name="pCodigoEjercicio">Codigo del ejercicio de Entrenamiento a eliminar</param>
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
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
            }
            catch (Exception er)
            {
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        /// <summary>
        /// Insertar un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEjercicioEnEntrenamiento">Ejercicio en Entrenamiento a eliminar</param>
        public void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_EjercicioEnEntrenamiento";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pEjercicioEnEntrenamiento.CodigoEntrenamiento);
            comando.Parameters.AddWithValue("@CodigoEjercicio", pEjercicioEnEntrenamiento.CodigoEjercicio);
            comando.Parameters.AddWithValue("@Repeticiones", pEjercicioEnEntrenamiento.Repeticiones);
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
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
            }
            catch (Exception er)
            {
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        /// <summary>
        /// Modificar un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEjercicioEnEntrenamiento">Ejercicio en Entrenamiento a modificar</param>
        public void ModificarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Modificar_EjercicioEnEntrenamiento";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pEjercicioEnEntrenamiento.CodigoEntrenamiento);
            comando.Parameters.AddWithValue("@CodigoEjercicio", pEjercicioEnEntrenamiento.CodigoEjercicio);
            comando.Parameters.AddWithValue("@Repeticiones", pEjercicioEnEntrenamiento.Repeticiones);
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
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
            }
            catch (Exception er)
            {
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        /// <summary>
        /// Obtiene una lista de Ejercicios en Entrenamiento relacionados al Codigo de Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento">Codigo de Entrenamiento relacionado a los Ejercicios en Entrenamiento a buscar</param>
        /// <returns>Lista de entidades de tipo EjericicioEnEntrenamiento</returns>
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
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
            }
            catch (Exception er)
            {
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        /// <summary>
        /// Obtiene un Ejercicio en Entrenamiento relacionado a sus Ids de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento"> Codigo del entrenamiento relacionado al ejercicio a buscar</param>
        /// <param name="pCodigoEjercicio">Codigo del ejercicio de Entrenamiento a buscar</param>
        /// <returns>Entidad de tipo EjercicioEnEntrenamiento</returns>
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
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
            }
            catch (Exception er)
            {
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }

        /// <summary>
        /// Retorna una lista de todos los Ejercicios en Entrenamiento en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo EjercicioEnEntrenamiento</returns>
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

                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        EjercicioEnEntrenamiento ejercicioEnEntrenamiento = new EjercicioEnEntrenamiento()
                        {
                            CodigoEntrenamiento = int.Parse(dr["CodigoEntrenamiento"].ToString()),
                            CodigoEjercicio = int.Parse(dr["CodigoEjercicio"].ToString()),
                            Repeticiones = int.Parse(dr["Repeticiones"].ToString()),
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
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw sqlError;
            }
            catch (Exception er)
            {
                //StringBuilder msg = new StringBuilder();
                //msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                //_MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }
    }
}
