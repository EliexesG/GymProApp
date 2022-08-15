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
    /// Clase de acceso a datos para los Detalles de Facturas de la base de datos
    /// </summary>
    public class FacturaDetalleDAL : IFacturaDetalleDAL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static FacturaDetalleDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo FacturaDetalleDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static FacturaDetalleDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new FacturaDetalleDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle)
        {

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Insertar_FacturaDetalle"
            };
            comando.Parameters.AddWithValue("@CodigoFactura", pFacturaDetalle.CodigoFactura);
            comando.Parameters.AddWithValue("@CodigoServicio", pFacturaDetalle.CodigoServicio);

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
        public List<FacturaDetalle> ObtenerFacturaDetalleCodigoFactura(int pCodigoFactura)
        {

            List<FacturaDetalle> lista = new List<FacturaDetalle>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_FacturaDetalle_CodigoFactura"
            };
            comando.Parameters.AddWithValue("@CodigoFactura", pCodigoFactura);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        FacturaDetalle facturaDetalle = new FacturaDetalle()
                        {
                            CodigoFactura = int.Parse(dr["CodigoFactura"].ToString()),
                            CodigoServicio = int.Parse(dr["CodigoServicio"].ToString())
                        };

                        facturaDetalle._Servicio = ServicioDAL.GetInstance().ObtenerServicioId(facturaDetalle.CodigoServicio);

                        lista.Add(facturaDetalle);
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
        public List<FacturaDetalle> ObtenerFacturaDetalleTodas()
        {
            List<FacturaDetalle> lista = new List<FacturaDetalle>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_FacturaDetalle_Todas"
            };

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        FacturaDetalle facturaDetalle = new FacturaDetalle()
                        {
                            CodigoFactura = int.Parse(dr["CodigoFactura"].ToString()),
                            CodigoServicio = int.Parse(dr["CodigoServicio"].ToString())
                        };

                        facturaDetalle._Servicio = ServicioDAL.GetInstance().ObtenerServicioId(facturaDetalle.CodigoServicio);

                        lista.Add(facturaDetalle);
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
