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
    public class EjercicioDAL : IEjercicioDAL
    {
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

        /// <summary>
        /// Elimina un Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Ejercicio a eliminar</param>
        public void EliminarEjercicio(int pCodigo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Eliminar_Ejercicio";
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
        /// Inserta un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio">Ejercicio a insertar</param>
        public void InsertarEjercicio(Ejercicio pEjercicio)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_Ejercicio";
            comando.Parameters.AddWithValue("@Nombre", pEjercicio.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pEjercicio.Descripcion);
            comando.Parameters.AddWithValue("@CodigoTipo", pEjercicio.CodigoTipo);
            comando.Parameters.AddWithValue("@Imagen", pEjercicio.Imagen);
            comando.Parameters.AddWithValue("@Videa", pEjercicio.Video);

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
        /// Modifica un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio">Ejercicio a modificar</param>
        public void ModificarEjercicio(Ejercicio pEjercicio)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Modificar_Ejercicio";
            comando.Parameters.AddWithValue("@Codigo", pEjercicio.Codigo);
            comando.Parameters.AddWithValue("@Nombre", pEjercicio.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pEjercicio.Descripcion);
            comando.Parameters.AddWithValue("@CodigoTipo", pEjercicio.CodigoTipo);
            comando.Parameters.AddWithValue("@Imagen", pEjercicio.Imagen);
            comando.Parameters.AddWithValue("@Videa", pEjercicio.Video);

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
        /// Obtiene una lista de Ejercicios por Codigo del Tipo de Ejercicio de la base de datos
        /// </summary>
        /// <param name="pCodigoTipo">Codigo del Tipo de Ejercicio de los Ejercicios a buscar</param>
        /// <returns>Lista de Entidades de tipo Ejercicio</returns>
        public List<Ejercicio> ObtenerEjercicioCodigoTipo(int pCodigoTipo)
        {

            List<Ejercicio> lista = new List<Ejercicio>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Ejercicio_CodigoTipo";
            comando.Parameters.AddWithValue("@CodigoTipo", pCodigoTipo);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Ejercicio ejercicio = new Ejercicio()
                        {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            CodigoTipo = int.Parse(dr["CodigoTipo"].ToString()),
                            Imagen = (byte[])dr["Imagen"],
                            Video = (byte[])dr["Video"]
                        };

                        ejercicio._TipoEjercicio = TipoEjercicioDAL.GetInstance().ObtenerTipoEjercicioId(ejercicio.CodigoTipo);

                        lista.Add(ejercicio);
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
        /// Obtiene un Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Ejercicio a buscar</param>
        /// <returns>Entidad de tipo Ejercicio</returns>
        public Ejercicio ObtenerEjercicioId(int pCodigo)
        {

            Ejercicio ejercicio = null;

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Ejercicio_Id";
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
                            Imagen = (byte[])reader["Imagen"],
                            Video = (byte[])reader["Video"]
                        };

                        ejercicio._TipoEjercicio = TipoEjercicioDAL.GetInstance().ObtenerTipoEjercicioId(ejercicio.CodigoTipo);
                    }

                }

                return ejercicio;

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
        /// Obtiene una lista de todos los Ejercicios en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Ejercicio</returns>
        public List<Ejercicio> ObtenerEjercicioTodos()
        {

            List<Ejercicio> lista = new List<Ejercicio>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Ejercicio_Todos";

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        Ejercicio ejercicio = new Ejercicio()
                        {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            CodigoTipo = int.Parse(dr["CodigoTipo"].ToString()),
                            Imagen = (byte[])dr["Imagen"],
                            Video = (byte[])dr["Video"]
                        };

                        ejercicio._TipoEjercicio = TipoEjercicioDAL.GetInstance().ObtenerTipoEjercicioId(ejercicio.CodigoTipo);

                        lista.Add(ejercicio);
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
