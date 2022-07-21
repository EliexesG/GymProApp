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
    public class FacturaDetalleDAL : IFacturaDetalleDAL
    {
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

        /// <summary>
        /// Inserta un Detalle de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaDetalle"> Detalle de Factura a insertar </param>
        public void InsertarFacturaDetalle(FacturaDetalle pFacturaDetalle)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_FacturaDetalle";
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
        /// Obtiene una lista de los Detalles de Factura en relacion con el Codigo del Encabezado de Factura de la base de datos
        /// </summary>
        /// <param name="pCodigoFactura"> Codigo del Encabezado de Factura relacionado </param>
        /// <returns>Lista de entidades de tipo FacturaDetalle</returns>
        public List<FacturaDetalle> ObtenerFacturaDetalleCodigoFactura(int pCodigoFactura)
        {

            List<FacturaDetalle> lista = new List<FacturaDetalle>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_FacturaDetalle_CodigoFactura";
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
        /// Obtiene una lista de todos los Detalles de Factura de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo FacturaDetalle</returns>
        public List<FacturaDetalle> ObtenerFacturaDetalleTodas()
        {
            List<FacturaDetalle> lista = new List<FacturaDetalle>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_FacturaDetalle_Todas";

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
