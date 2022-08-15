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
    /// Clase de acceso a datos para los Tipos de Usuarios de la base de datos
    /// </summary>
    public class TipoUsuarioDAL : ITipoUsuarioDAL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static TipoUsuarioDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo TipoUsuarioDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static TipoUsuarioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new TipoUsuarioDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public TipoUsuario ObtenerTipoUsuarioId(int pCodigo)
        {
            TipoUsuario tipoUsuario = null;

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_TipoUsuario_Id"
            };
            comando.Parameters.AddWithValue("@Codigo", pCodigo);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    IDataReader reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        tipoUsuario = new TipoUsuario()
                        {
                            Codigo = int.Parse(reader["Codigo"].ToString()),
                            Descripcion = reader["Descripcion"].ToString()
                        };
                    }

                }

                return tipoUsuario;

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
        public List<TipoUsuario> ObtenerTipoUsuarioTodos()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_TipoUsuario_Todos"
            };

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        TipoUsuario tipoEjercicio = new TipoUsuario()
                        {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            Descripcion = dr["Descripcion"].ToString()
                        };

                        lista.Add(tipoEjercicio);
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
