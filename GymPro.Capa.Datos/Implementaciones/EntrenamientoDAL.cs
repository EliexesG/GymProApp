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
    /// Clase de acceso a datos para los Entrenamientos de la base de datos
    /// </summary>
    public class EntrenamientoDAL : IEntrenamientoDAL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

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

        /// <inheritdoc />
        public void EliminarEntrenamiento(int pCodigo)
        {

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Eliminar_Entrenamiento"
            };
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
        public void InsertarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Insertar_Entrenamiento"
            };
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
        public void ModificarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Modificar_Entrenamiento"
            };
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
        public Entrenamiento ObtenerEntrenamientoId(int pCodigo)
        {
            Entrenamiento entrenamiento = null;

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_Entrenamiento_Id"
            };
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

                        entrenamiento.EjerciciosEnEntrenamiento = EjercicioEnEntrenamientoDAL.GetInstance().
                            ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(entrenamiento.Codigo);
                        entrenamiento.DiasEntrenamiento = DiaEntrenamientoDAL.
                            GetInstance().ObtenerDiaEntrenamientoCodigoEntrenamiento(entrenamiento.Codigo);
                    }

                    return entrenamiento;
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
        public List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioCliente(string pIdentificacionUsuario)
        {

            List<Entrenamiento> lista = new List<Entrenamiento>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_Entrenamiento_IdentificacionUsuario_Cliente"
            };
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

                        entrenamiento.EjerciciosEnEntrenamiento = EjercicioEnEntrenamientoDAL.GetInstance().
                            ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(entrenamiento.Codigo);
                        entrenamiento.DiasEntrenamiento = DiaEntrenamientoDAL.
                            GetInstance().ObtenerDiaEntrenamientoCodigoEntrenamiento(entrenamiento.Codigo);

                        lista.Add(entrenamiento);
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
        public List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioEntrenador(string pIdentificacionUsuario)
        {
            List<Entrenamiento> lista = new List<Entrenamiento>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_Entrenamiento_IdentificacionUsuario_Entrenador"
            };
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

                        entrenamiento.EjerciciosEnEntrenamiento = EjercicioEnEntrenamientoDAL.GetInstance().
                            ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(entrenamiento.Codigo);
                        entrenamiento.DiasEntrenamiento = DiaEntrenamientoDAL.
                            GetInstance().ObtenerDiaEntrenamientoCodigoEntrenamiento(entrenamiento.Codigo);

                        lista.Add(entrenamiento);
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
        public List<Entrenamiento> ObtenerEntrenamientoTodos()
        {
            List<Entrenamiento> lista = new List<Entrenamiento>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_Entrenamiento_Todos"
            };

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

                        entrenamiento.EjerciciosEnEntrenamiento = EjercicioEnEntrenamientoDAL.GetInstance().
                            ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(entrenamiento.Codigo);
                        entrenamiento.DiasEntrenamiento = DiaEntrenamientoDAL.
                            GetInstance().ObtenerDiaEntrenamientoCodigoEntrenamiento(entrenamiento.Codigo);

                        lista.Add(entrenamiento);
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
