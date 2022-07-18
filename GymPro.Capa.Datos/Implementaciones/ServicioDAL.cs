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
    public class ServicioDAL : IServicioDAL
    {
        private static ServicioDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo ServicioDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static ServicioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ServicioDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Obtiene un Servicio de la base de datos por su Id
        /// </summary>
        /// <param name="pCodigo"> Codigo del servicio a buscar </param>
        /// <returns>Entidad de tipo Servicio</returns>
        public Servicio ObtenerServicioId(int pCodigo)
        {

            Servicio servicio = null;

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Servicio_Id";
            comando.Parameters.AddWithValue("@Codigo", pCodigo);

            try
            {

                using(IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    IDataReader reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        servicio = new Servicio()
                        {
                            Codigo = int.Parse(reader["Codigo"].ToString()),
                            Descripcion = reader["Descripcion"].ToString(),
                            Monto = float.Parse(reader["Monto"].ToString())
                        };
                    }

                }

                return servicio;
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
        /// Obtiene una lista de todos los servicios de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Servicio</returns>
        public List<Servicio> ObtenerServicioTodos()
        {

            List<Servicio> lista = new List<Servicio>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Servicio_Todos";

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        Servicio servicio = new Servicio()
                        {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            Descripcion = dr["Descripcion"].ToString(),
                            Monto = float.Parse(dr["Monto"].ToString())
                        };

                        lista.Add(servicio);
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
