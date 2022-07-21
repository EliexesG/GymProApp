using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Datos.Persistencia;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class UsuarioDAL : IUsuarioDAL
    {
        private static UsuarioDAL Instancia;

        /// <summary>
        /// Retorna una instancia de tipo UsuarioDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static UsuarioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new UsuarioDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Elimina un usuario de la base de datos por su Identificacion
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario a eliminar </param>
        public void EliminarUsuario(string pIdentificacionUsuario)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Eliminar_Usuario";
            comando.Parameters.AddWithValue("@Identificacion", pIdentificacionUsuario);

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
        /// Inserta un Usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"> Usuario a insertar </param>
        public void InsertarUsuario(IUsuario pUsuario)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Insertar_Usuario";

            comando.Parameters.AddWithValue("@Identificacion", pUsuario.Identificacion);
            comando.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
            comando.Parameters.AddWithValue("@Apellido1", pUsuario.Apellido1);
            comando.Parameters.AddWithValue("@Apellido2", pUsuario.Apellido2);
            comando.Parameters.AddWithValue("@Fotografia", pUsuario.Fotografia);
            comando.Parameters.AddWithValue("@CodigoTipoUsuario", pUsuario.CodigoTipoUsuario);

            byte[] encriptacion = Encriptacion.EncriptarContrasenna(pUsuario.Contrasenna);

            comando.Parameters.AddWithValue("@Contrasenna", encriptacion);
            
            if(pUsuario is Cliente)
            {
                comando.Parameters.AddWithValue("@FechaNacimiento", ((Cliente)pUsuario).FechaNacimiento);
                comando.Parameters.AddWithValue("@Correo", ((Cliente)pUsuario).Correo);
                comando.Parameters.AddWithValue("@Telefono", ((Cliente)pUsuario).Telefono);
                comando.Parameters.AddWithValue("@Genero", ((int)((Cliente)pUsuario).Genero));
            }
            else
            {
                comando.Parameters.AddWithValue("@FechaNacimiento", DBNull.Value);
                comando.Parameters.AddWithValue("@Correo", DBNull.Value);
                comando.Parameters.AddWithValue("@Telefono", DBNull.Value);
                comando.Parameters.AddWithValue("@Genero", DBNull.Value);
            }

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
        /// Modifica un Usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"> Usuario a modificar </param>
        public void ModificarUsuario(IUsuario pUsuario)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Modificar_Usuario";

            comando.Parameters.AddWithValue("@Identificacion", pUsuario.Identificacion);
            comando.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
            comando.Parameters.AddWithValue("@Apellido1", pUsuario.Apellido1);
            comando.Parameters.AddWithValue("@Apellido2", pUsuario.Apellido2);
            comando.Parameters.AddWithValue("@Fotografia", pUsuario.Fotografia);
            comando.Parameters.AddWithValue("@CodigoTipoUsuario", pUsuario.CodigoTipoUsuario);

            byte[] encriptacion = Encriptacion.EncriptarContrasenna(pUsuario.Contrasenna);

            comando.Parameters.AddWithValue("@Contrasenna", encriptacion);

            if (pUsuario is Cliente)
            {
                comando.Parameters.AddWithValue("@FechaNacimiento", ((Cliente)pUsuario).FechaNacimiento);
                comando.Parameters.AddWithValue("@Correo", ((Cliente)pUsuario).Correo);
                comando.Parameters.AddWithValue("@Telefono", ((Cliente)pUsuario).Telefono);
                comando.Parameters.AddWithValue("@Genero", ((int)((Cliente)pUsuario).Genero));
            }
            else
            {
                comando.Parameters.AddWithValue("@FechaNacimiento", DBNull.Value);
                comando.Parameters.AddWithValue("@Correo", DBNull.Value);
                comando.Parameters.AddWithValue("@Telefono", DBNull.Value);
                comando.Parameters.AddWithValue("@Genero", DBNull.Value);
            }

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
        /// Obtiene el Usuario relacionado a la Identificacion de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario a buscar </param>
        /// <returns>Entidad de tipo Usuario</returns>
        public IUsuario ObtenerUsuarioIdentificacion(string pIdentificacionUsuario)
        {

            IUsuario usuario = null;

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Usuario_Identificacion";
            comando.Parameters.AddWithValue("@Identificacion", pIdentificacionUsuario);


            try
            {

                using (IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    IDataReader reader = db.ExecuteReader(comando);

                    while(reader.Read())
                    {

                        TipoUsuarioEnum tipo = (TipoUsuarioEnum)int.Parse(reader["CodigoTipoUsuario"].ToString());

                        usuario = Factories.FactoryUsuario.CrearUsuario(tipo);

                        usuario.Identificacion = reader["Identificacion"].ToString();
                        usuario.Nombre = reader["Nombre"].ToString();
                        usuario.Apellido1 = reader["Apellido1"].ToString();
                        usuario.Apellido2 = reader["Apellido2"].ToString();
                        usuario.Fotografia = (byte[])reader["Fotografia"];
                        usuario.CodigoTipoUsuario = int.Parse(reader["CodigoTipoUsuario"].ToString());
                        usuario.Contrasenna = Encriptacion.DesencriptarContrasenna((byte[])reader["Contrasenna"]);
                        usuario._TipoUsuario = TipoUsuarioDAL.GetInstance().ObtenerTipoUsuarioId(usuario.CodigoTipoUsuario);

                        if (usuario is Cliente)
                        {
                            ((Cliente)usuario).FechaNacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString());
                            ((Cliente)usuario).Correo = reader["Correo"].ToString();
                            ((Cliente)usuario).Telefono = reader["Telefono"].ToString();
                            ((Cliente)usuario).Genero = (Genero)int.Parse(reader["Genero"].ToString());
                            ((Cliente)usuario).Entrenamientos = EntrenamientoDAL.GetInstance().ObtenerEntrenamientoIdentificacionUsuarioCliente(usuario.Identificacion);
                            ((Cliente)usuario).HistorialExpedientesUsuario = ExpedienteUsuarioDAL.GetInstance().ObtenerExpedienteUsuarioIdentificacionUsuario(usuario.Identificacion);
                            ((Cliente)usuario).HistorialFacturasEncabezado = FacturaEncabezadoDAL.GetInstance().ObtenerFacturaEncabezadoIdentificacionUsuario(usuario.Identificacion);
                        }
                        else if(usuario is Instructor)
                        {
                            ((Instructor)usuario).Entrenamientos = EntrenamientoDAL.GetInstance().ObtenerEntrenamientoIdentificacionUsuarioEntrenador(usuario.Identificacion);
                        }
                    }

                }

                return usuario;

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
        /// Obtiene una lista de todos los Usuarios de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Usuario</returns>
        public List<IUsuario> ObtenerUsuarioTodos()
        {
            List<IUsuario> lista = new List<IUsuario>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SP_Obtener_Usuario_Todos";


            try
            {

                using(IDataBase db = FactoryDataBase.CreateDefaultDataBase())
                {
                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {

                        TipoUsuarioEnum tipo = (TipoUsuarioEnum)int.Parse(dr["CodigoTipoUsuario"].ToString());

                        IUsuario usuario = Factories.FactoryUsuario.CrearUsuario(tipo);

                        usuario.Identificacion = dr["Identificacion"].ToString();
                        usuario.Nombre = dr["Nombre"].ToString();
                        usuario.Apellido1 = dr["Apellido1"].ToString();
                        usuario.Apellido2 = dr["Apellido2"].ToString();
                        usuario.Fotografia = (byte[])dr["Fotografia"];
                        usuario.CodigoTipoUsuario = int.Parse(dr["CodigoTipoUsuario"].ToString());
                        usuario.Contrasenna = Encriptacion.DesencriptarContrasenna((byte[])dr["Contrasenna"]);
                        usuario._TipoUsuario = TipoUsuarioDAL.GetInstance().ObtenerTipoUsuarioId(usuario.CodigoTipoUsuario);

                        if (usuario is Cliente)
                        {
                            ((Cliente)usuario).FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                            ((Cliente)usuario).Correo = dr["Correo"].ToString();
                            ((Cliente)usuario).Telefono = dr["Telefono"].ToString();
                            ((Cliente)usuario).Genero = (Genero)int.Parse(dr["Genero"].ToString());
                            ((Cliente)usuario).Entrenamientos = EntrenamientoDAL.GetInstance().ObtenerEntrenamientoIdentificacionUsuarioCliente(usuario.Identificacion);
                            ((Cliente)usuario).HistorialExpedientesUsuario = ExpedienteUsuarioDAL.GetInstance().ObtenerExpedienteUsuarioIdentificacionUsuario(usuario.Identificacion);
                            ((Cliente)usuario).HistorialFacturasEncabezado = FacturaEncabezadoDAL.GetInstance().ObtenerFacturaEncabezadoIdentificacionUsuario(usuario.Identificacion);
                        }
                        else if (usuario is Instructor)
                        {
                            ((Instructor)usuario).Entrenamientos = EntrenamientoDAL.GetInstance().ObtenerEntrenamientoIdentificacionUsuarioEntrenador(usuario.Identificacion);
                        }

                        lista.Add(usuario);
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
