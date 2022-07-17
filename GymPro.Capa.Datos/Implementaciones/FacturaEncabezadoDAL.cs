﻿using GymPro.Capa.Datos.Interfaces;
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
    public class FacturaEncabezadoDAL : IFacturaEncabezadoDAL
    {
        private static FacturaEncabezadoDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo FacturaEncabezadoDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static FacturaEncabezadoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new FacturaEncabezadoDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Elimina un Encabezado de Factura de la base de datos por Id
        /// </summary>
        /// <param name="pCodigo"> Codigo del Encabezado de Factura a eliminar</param>
        public void EliminarFacturaEncabezado(int pCodigo)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Eliminar_FacturaEncabezado";
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
        /// Inserta un Encabezado de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"> Encabezado de Factura a insertar </param>
        public void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_FacturaEncabezado";
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pFacturaEncabezado.IdentificacionUsuario);
            comando.Parameters.AddWithValue("@CodigoQR", pFacturaEncabezado.CodigoQR);
            comando.Parameters.AddWithValue("@FechaPago", pFacturaEncabezado.FechaPago.Date);
            comando.Parameters.AddWithValue("@FechaProximoPago", pFacturaEncabezado.FechaProximoPago.Date);
            comando.Parameters.AddWithValue("@MontoTotal", pFacturaEncabezado.MontoTotal);
            comando.Parameters.AddWithValue("@MontoMulta", pFacturaEncabezado.MontoMulta);

            try
            {

                using(IDataBase db = FactoryDataBase.CreateDefaultDataBase())
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
        /// Modifica un Encabezado de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"> Encabezado de Factura a modificar </param>
        public void ModificarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Modificar_FacturaEncabezado";
            comando.Parameters.AddWithValue("@Codigo", pFacturaEncabezado.Codigo);
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pFacturaEncabezado.IdentificacionUsuario);
            comando.Parameters.AddWithValue("@CodigoQR", pFacturaEncabezado.CodigoQR);
            comando.Parameters.AddWithValue("@FechaPago", pFacturaEncabezado.FechaPago.Date);
            comando.Parameters.AddWithValue("@FechaProximoPago", pFacturaEncabezado.FechaProximoPago.Date);
            comando.Parameters.AddWithValue("@MontoTotal", pFacturaEncabezado.MontoTotal);
            comando.Parameters.AddWithValue("@MontoMulta", pFacturaEncabezado.MontoMulta);

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
        /// Obtiene un Encabezado de Factura por su Id
        /// </summary>
        /// <param name="pCodigo"> Codigo de Encabezado de Factura a buscar </param>
        /// <returns></returns>
        public FacturaEncabezado ObtenerFacturaEncabezadoId(int pCodigo)
        {
            FacturaEncabezado facturaEncabezado = null;

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_FacturaEncabezado_Id";
            comando.Parameters.AddWithValue("@Codigo", pCodigo);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    IDataReader reader = db.ExecuteReader(comando);

                    while(reader.Read())
                    {
                        facturaEncabezado = new FacturaEncabezado()
                        {
                            Codigo = int.Parse(reader["Codigo"].ToString()),
                            IdentificacionUsuario = reader["IdentificacionUsuario"].ToString(),
                            CodigoQR = (byte[])reader["CodigoQR"],
                            FechaPago = DateTime.Parse(reader["FechaPago"].ToString()),
                            FechaProximoPago = DateTime.Parse(reader["FechaProximoPago"].ToString()),
                            MontoTotal = float.Parse(reader["MontoTotal"].ToString()),
                            MontoMulta = float.Parse(reader["MontoMulta"].ToString())
                        };

                    }

                }

                return facturaEncabezado;

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
        /// Obtiene una lista de Encabezados de Facturas relacionados a la Identificacion de un Usuario de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario relacionado a los Encabezados de Factura a buscar </param>
        /// <returns>Lista de entidades de tipo FacturaEncabezado</returns>
        public List<FacturaEncabezado> ObtenerFacturaEncabezadoIdentificacionUsuario(string pIdentificacionUsuario)
        {
            List<FacturaEncabezado> lista = new List<FacturaEncabezado>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_FacturaEncabezado_IdentificacionUsuario";
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pIdentificacionUsuario)

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        FacturaEncabezado facturaEncabezado = new FacturaEncabezado()
                        {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            IdentificacionUsuario = dr["IdentificacionUsuario"].ToString(),
                            CodigoQR = (byte[])dr["CodigoQR"],
                            FechaPago = DateTime.Parse(dr["FechaPago"].ToString()),
                            FechaProximoPago = DateTime.Parse(dr["FechaProximoPago"].ToString()),
                            MontoTotal = float.Parse(dr["MontoTotal"].ToString()),
                            MontoMulta = float.Parse(dr["MontoMulta"].ToString())
                        };

                        lista.Add(facturaEncabezado);

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
        /// Obtiene una lista de todos los Encabezados de Factura en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo FacturaEncabezado</returns>
        public List<FacturaEncabezado> ObtenerFacturaEncabezadoTodas()
        {
            List<FacturaEncabezado> lista = new List<FacturaEncabezado>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_FacturaEncabezado_Todas";

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        FacturaEncabezado facturaEncabezado = new FacturaEncabezado() {
                            Codigo = int.Parse(dr["Codigo"].ToString()),
                            IdentificacionUsuario = dr["IdentificacionUsuario"].ToString(),
                            CodigoQR = (byte[])dr["CodigoQR"],
                            FechaPago = DateTime.Parse(dr["FechaPago"].ToString()),
                            FechaProximoPago = DateTime.Parse(dr["FechaProximoPago"].ToString()),
                            MontoTotal = float.Parse(dr["MontoTotal"].ToString()),
                            MontoMulta = float.Parse(dr["MontoMulta"].ToString())
                        };

                        lista.Add(facturaEncabezado);

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
