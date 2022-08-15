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
    /// Clase de acceso a datos para los Ejercicios de la base de datos
    /// </summary>
    public class EjercicioDAL : IEjercicioDAL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static EjercicioDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo EjercicioDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static EjercicioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new EjercicioDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public void EliminarEjercicio(int pCodigo)
        {
            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Eliminar_Ejercicio"
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
        public void InsertarEjercicio(Ejercicio pEjercicio)
        {
            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Insertar_Ejercicio"
            };
            comando.Parameters.AddWithValue("@Nombre", pEjercicio.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pEjercicio.Descripcion);
            comando.Parameters.AddWithValue("@CodigoTipo", pEjercicio.CodigoTipo);
            comando.Parameters.AddWithValue("@Multimedia", pEjercicio.Multimedia);

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
        public void ModificarEjercicio(Ejercicio pEjercicio)
        {
            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Modificar_Ejercicio"
            };
            comando.Parameters.AddWithValue("@Codigo", pEjercicio.Codigo);
            comando.Parameters.AddWithValue("@Nombre", pEjercicio.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pEjercicio.Descripcion);
            comando.Parameters.AddWithValue("@CodigoTipo", pEjercicio.CodigoTipo);
            comando.Parameters.AddWithValue("@Multimedia", pEjercicio.Multimedia);

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
        public List<Ejercicio> ObtenerEjercicioCodigoTipo(int pCodigoTipo)
        {

            List<Ejercicio> lista = new List<Ejercicio>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_Ejercicio_CodigoTipo"
            };
            comando.Parameters.AddWithValue("@CodigoTipo", pCodigoTipo);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    IDataReader reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Ejercicio ejercicio = new Ejercicio()
                        {
                            Codigo = int.Parse(reader["Codigo"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            CodigoTipo = int.Parse(reader["CodigoTipo"].ToString()),
                            Multimedia = (byte[])reader["Multimedia"]
                        };

                        ejercicio._TipoEjercicio = TipoEjercicioDAL.GetInstance().ObtenerTipoEjercicioId(ejercicio.CodigoTipo);

                        lista.Add(ejercicio);
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
        public Ejercicio ObtenerEjercicioId(int pCodigo)
        {

            Ejercicio ejercicio = null;

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_Ejercicio_Id"
            };
            comando.Parameters.AddWithValue("@Codigo", pCodigo);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    IDataReader reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        ejercicio = new Ejercicio()
                        {
                            Codigo = int.Parse(reader["Codigo"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            CodigoTipo = int.Parse(reader["CodigoTipo"].ToString()),
                            Multimedia = (byte[])reader["Multimedia"]
                        };

                        ejercicio._TipoEjercicio = TipoEjercicioDAL.GetInstance().ObtenerTipoEjercicioId(ejercicio.CodigoTipo);
                    }

                }

                return ejercicio;

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
        public List<Ejercicio> ObtenerEjercicioTodos()
        {

            List<Ejercicio> lista = new List<Ejercicio>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_Ejercicio_Todos"
            };

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    IDataReader reader = db.ExecuteReader(comando);

                    while(reader.Read())
                    {
                        Ejercicio ejercicio = new Ejercicio()
                        {
                            Codigo = int.Parse(reader["Codigo"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            CodigoTipo = int.Parse(reader["CodigoTipo"].ToString()),
                            Multimedia = (byte[])reader["Multimedia"]
                        };

                        ejercicio._TipoEjercicio = TipoEjercicioDAL.GetInstance().ObtenerTipoEjercicioId(ejercicio.CodigoTipo);

                        lista.Add(ejercicio);
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
