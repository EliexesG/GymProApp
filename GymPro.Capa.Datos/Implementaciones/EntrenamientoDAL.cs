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
    public class EntrenamientoDAL : IEntrenamientoDAL
    {
        private static EntrenamientoDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo EntrenamientoDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static EntrenamientoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new EntrenamientoDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Elimina un Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigo"> Codigo del entrenamiento a eliminar </param>
        public void EliminarEntrenamiento(int pCodigo)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Eliminar_Entrenamiento";
            comando.Parameters.AddWithValue("@Codigo", pCodigo);

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
        /// Inserta un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento">Entrenamiento a insertar</param>
        public void InsertarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_Entrenamiento";
            comando.Parameters.AddWithValue("@IdentificacionCliente", pEntrenamiento.IdentificacionCliente);
            comando.Parameters.AddWithValue("@IdentificacionEntrenador", pEntrenamiento.IdentificacionEntrenador);
            comando.Parameters.AddWithValue("@Nombre", pEntrenamiento.Nombre);

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
        /// Modifica un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento">Entrenamiento a modificar</param>
        public void ModificarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Modificar_Entrenamiento";
            comando.Parameters.AddWithValue("@Codigo", pEntrenamiento.Codigo);
            comando.Parameters.AddWithValue("@IdentificacionCliente", pEntrenamiento.IdentificacionCliente);
            comando.Parameters.AddWithValue("@IdentificacionEntrenador", pEntrenamiento.IdentificacionEntrenador);
            comando.Parameters.AddWithValue("@Nombre", pEntrenamiento.Nombre);

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
        /// Obtiene un Entrenamiento por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del entrenamiento a buscar</param>
        /// <returns>Entidad de tipo Entrenamiento</returns>
        public Entrenamiento ObtenerEntrenamientoId(int pCodigo)
        {
            Entrenamiento entrenamiento = null;

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Entrenamiento_Id";
            comando.Parameters.AddWithValue("@Codigo", pCodigo);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    IDataReader reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        entrenamiento = new Entrenamiento()
                        {
                            Codigo = int.Parse(reader["Codigo"].ToString()),
                            IdentificacionCliente = reader["IdentificacionCliente"].ToString(),
                            IdentificacionEntrenador = reader["IdentificacionEntrenador"].ToString(),
                            Nombre = reader["Nombre"].ToString()
                        };
                    }

                    return entrenamiento;
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
        /// Obtiene una lista de Entrenamientos basado en la Identificacion del Usuario Cliente de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario Cliente </param>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        public List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioCliente(string pIdentificacionUsuario)
        {

            List<Entrenamiento> lista = new List<Entrenamiento>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Entrenamiento_IdentificacionUsuario_Cliente";
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pIdentificacionUsuario);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Entrenamiento entrenamiento = new Entrenamiento()
                        {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            IdentificacionCliente = dr["IdentificacionCliente"].ToString(),
                            IdentificacionEntrenador = dr["IdentificacionEntrenador"].ToString(),
                            Nombre = dr["Nombre"].ToString()
                        };

                        lista.Add(entrenamiento);
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
        /// Obtiene una lista de Entrenamientos basado en la Identificacion del Usuario Entrenador de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario Entrenador </param>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        public List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioEntrenador(string pIdentificacionUsuario)
        {
            List<Entrenamiento> lista = new List<Entrenamiento>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Entrenamiento_IdentificacionUsuario_Entrenador";
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pIdentificacionUsuario);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Entrenamiento entrenamiento = new Entrenamiento()
                        {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            IdentificacionCliente = dr["IdentificacionCliente"].ToString(),
                            IdentificacionEntrenador = dr["IdentificacionEntrenador"].ToString(),
                            Nombre = dr["Nombre"].ToString()
                        };

                        lista.Add(entrenamiento);
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
        /// Obtiene una lista de todos los Entrenamientos de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        public List<Entrenamiento> ObtenerEntrenamientoTodos()
        {
            List<Entrenamiento> lista = new List<Entrenamiento>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Entrenamiento_Todos";

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        Entrenamiento entrenamiento = new Entrenamiento()
                        {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            IdentificacionCliente = dr["IdentificacionCliente"].ToString(),
                            IdentificacionEntrenador = dr["IdentificacionEntrenador"].ToString(),
                            Nombre = dr["Nombre"].ToString()
                        };

                        lista.Add(entrenamiento);
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
