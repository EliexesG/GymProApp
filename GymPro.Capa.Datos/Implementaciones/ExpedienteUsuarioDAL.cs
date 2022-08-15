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
    /// Clase de acceso a datos para los Expedientes de Usuarios de la base de datos
    /// </summary>
    public class ExpedienteUsuarioDAL : IExpedienteUsuarioDAL
    {
        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private static ExpedienteUsuarioDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo ExpedienteUsuarioDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static ExpedienteUsuarioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ExpedienteUsuarioDAL();
            }

            return Instancia;
        }

        /// <inheritdoc />
        public void EliminarExpedienteUsuario(DateTime pFecha, string pIdentificacionUsuario)
        {

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Eliminar_ExpedienteUsuario"
            };
            comando.Parameters.AddWithValue("@Fecha", pFecha);
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pIdentificacionUsuario);

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
        public void InsertarExpedienteUsuario(ExpedienteUsuario pExpediente)
        {

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Insertar_ExpedienteUsuario"
            };
            comando.Parameters.AddWithValue("@Fecha", pExpediente.Fecha.Date);
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pExpediente.IdentificacionUsuario);
            comando.Parameters.AddWithValue("@Peso", pExpediente.Peso);
            comando.Parameters.AddWithValue("@Altura", pExpediente.Altura);
            comando.Parameters.AddWithValue("@IMC", pExpediente.IMC);
            comando.Parameters.AddWithValue("@MetabolismoBasal", pExpediente.MetabolismoBasal);

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
        public void ModificarExpedienteUsuario(ExpedienteUsuario pExpediente)
        {

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Modificar_ExpedienteUsuario"
            };
            comando.Parameters.AddWithValue("@Fecha", pExpediente.Fecha.Date);
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pExpediente.IdentificacionUsuario);
            comando.Parameters.AddWithValue("@Peso", pExpediente.Peso);
            comando.Parameters.AddWithValue("@Altura", pExpediente.Altura);
            comando.Parameters.AddWithValue("@IMC", pExpediente.IMC);
            comando.Parameters.AddWithValue("@MetabolismoBasal", pExpediente.MetabolismoBasal);

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
        public ExpedienteUsuario ObtenerExpedienteUsuarioId(DateTime pFecha, string pIdentificacionUsuario)
        {
            ExpedienteUsuario expediente = null;

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_ExpedienteUsuario_Id"
            };
            comando.Parameters.AddWithValue("@Fecha", pFecha.Date);
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pIdentificacionUsuario);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    IDataReader reader = db.ExecuteReader(comando);

                    while(reader.Read())
                    {
                        expediente = new ExpedienteUsuario()
                        {
                            Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                            IdentificacionUsuario = reader["IdentificacionUsuario"].ToString(),
                            Peso = double.Parse(reader["Peso"].ToString()),
                            Altura = int.Parse(reader["Altura"].ToString()),
                            IMC = double.Parse(reader["IMC"].ToString()),
                            MetabolismoBasal = double.Parse(reader["MetabolismoBasal"].ToString())
                        };
                    }

                }

                return expediente;

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
        public List<ExpedienteUsuario> ObtenerExpedienteUsuarioIdentificacionUsuario(string pIdentificacionUsuario)
        {
            List<ExpedienteUsuario> lista = new List<ExpedienteUsuario>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_ExpedienteUsuario_IdentificacionUsuario"
            };
            comando.Parameters.AddWithValue("@IdentificacionUsuario", pIdentificacionUsuario);

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ExpedienteUsuario expediente = new ExpedienteUsuario()
                        {
                            Fecha = DateTime.Parse(dr["Fecha"].ToString()),
                            IdentificacionUsuario = dr["IdentificacionUsuario"].ToString(),
                            Peso = double.Parse(dr["Peso"].ToString()),
                            Altura = int.Parse(dr["Altura"].ToString()),
                            IMC = double.Parse(dr["IMC"].ToString()),
                            MetabolismoBasal = double.Parse(dr["MetabolismoBasal"].ToString())
                        };

                        lista.Add(expediente);
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
        public List<ExpedienteUsuario> ObtenerExpedienteUsuarioTodos()
        {
            List<ExpedienteUsuario> lista = new List<ExpedienteUsuario>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "SP_Obtener_ExpedienteUsuario_Todos"
            };

            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ExpedienteUsuario expediente = new ExpedienteUsuario()
                        {
                            Fecha = DateTime.Parse(dr["Fecha"].ToString()),
                            IdentificacionUsuario = dr["IdentificacionUsuario"].ToString(),
                            Peso = double.Parse(dr["Peso"].ToString()),
                            Altura = int.Parse(dr["Altura"].ToString()),
                            IMC = double.Parse(dr["IMC"].ToString()),
                            MetabolismoBasal = double.Parse(dr["MetabolismoBasal"].ToString())
                        };

                        lista.Add(expediente);
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
