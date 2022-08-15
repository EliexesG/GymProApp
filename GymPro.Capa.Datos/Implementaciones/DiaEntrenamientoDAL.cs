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
    /// Clase de acceso a datos para los Dias de Entrenamientos de la base de datos
    /// </summary>
    public class DiaEntrenamientoDAL : IDiaEntrenamientoDAL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static DiaEntrenamientoDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo DiaEntrenamientoDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static DiaEntrenamientoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new DiaEntrenamientoDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public void EliminarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Eliminar_DiaEntrenamiento";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pDiaEntrenamiento.CodigoEntrenamiento);
            comando.Parameters.AddWithValue("@Dia", pDiaEntrenamiento.Dia);

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
        public void InsertarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_DiaEntrenamiento";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pDiaEntrenamiento.CodigoEntrenamiento);
            comando.Parameters.AddWithValue("@Dia", pDiaEntrenamiento.Dia);

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
        public List<DiaEntrenamiento> ObtenerDiaEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento)
        {
            List<DiaEntrenamiento> lista = new List<DiaEntrenamiento>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_DiaEntrenamiento_CodigoEntrenamiento";
            comando.Parameters.AddWithValue("@CodigoEntrenamiento", pCodigoEntrenamiento);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DiaEntrenamiento diaEntrenamiento = new DiaEntrenamiento()
                        {
                            CodigoEntrenamiento = int.Parse(dr["CodigoEntrenamiento"].ToString()),
                            Dia = int.Parse(dr["Dia"].ToString())
                        };

                        lista.Add(diaEntrenamiento);
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
        public List<DiaEntrenamiento> ObtenerDiaEntrenamientoTodos()
        {

            List<DiaEntrenamiento> lista = new List<DiaEntrenamiento>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_DiaEntrenamiento_Todos";

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        DiaEntrenamiento diaEntrenamiento = new DiaEntrenamiento()
                        {
                            CodigoEntrenamiento = int.Parse(dr["CodigoEntrenamiento"].ToString()),
                            Dia = int.Parse(dr["Dia"].ToString())
                        };

                        lista.Add(diaEntrenamiento);
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
