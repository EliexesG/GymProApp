using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Implementaciones
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Usuarios de la base de datos
    /// </summary>
    public class UsuarioBLL : IUsuarioBLL
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private IUsuarioDAL oUsuarioDAL;

        public UsuarioBLL()
        {
            oUsuarioDAL = UsuarioDAL.GetInstance();
        }

        #region Logica
        /// <inheritdoc />
        public int CalcularEdadUsuario(DateTime pFechaNacimiento)
        {
            try
            {

                DateTime fechaActual = DateTime.Now;

                return DateTime.Today.AddTicks(-pFechaNacimiento.Ticks).Year - 1; ;

            }
            catch(Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());

                throw er;
            }
        }
        #endregion

        #region Acceso a datos
        /// <inheritdoc />
        public void EliminarUsuario(string pIdentificacionUsuario)
        {

            try
            {

                oUsuarioDAL.EliminarUsuario(pIdentificacionUsuario);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <inheritdoc />
        public void InsertarUsuario(IUsuario pUsuario)
        {

            try
            {

                oUsuarioDAL.InsertarUsuario(pUsuario);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <inheritdoc />
        public void ModificarUsuario(IUsuario pUsuario)
        {

            try
            {

                oUsuarioDAL.ModificarUsuario(pUsuario);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <inheritdoc />
        public IUsuario ObtenerUsuarioIdentificacion(string pIdentificacionUsuario)
        {

            try
            {

                return oUsuarioDAL.ObtenerUsuarioIdentificacion(pIdentificacionUsuario);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <inheritdoc />
        public List<IUsuario> ObtenerUsuarioActivoTodos()
        {
            try
            {

                return oUsuarioDAL.ObtenerUsuarioActivoTodos().OrderBy(usuario => usuario.Nombre).ThenBy(usuario => usuario.Apellido1).ToList();

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <inheritdoc />
        public List<IUsuario> ObtenerUsuarioInactivoTodos()
        {
            try
            {

                return oUsuarioDAL.ObtenerUsuarioInactivoTodos().OrderBy(usuario => usuario.Nombre).ThenBy(usuario => usuario.Apellido1).ToList();

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <inheritdoc />
        public void ActivarUsuario(string pIdentificacionUsuario)
        {
            try
            {

                oUsuarioDAL.ActivarUsuario(pIdentificacionUsuario);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <inheritdoc />
        public List<Cliente> ObtenerUsuariosCliente()
        {
            try
            {

                List<IUsuario> listaClientes = ObtenerUsuarioActivoTodos().FindAll(usuario => usuario is Cliente).ToList();

                return listaClientes.ConvertAll(cliente => cliente as Cliente).ToList();

            }
            catch (SqlException sqlError)
            {
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
        public List<Instructor> ObtenerUsuariosInstructor()
        {
            try
            {

                List<IUsuario> listaInstructores = ObtenerUsuarioActivoTodos().FindAll(usuario => usuario is Instructor).ToList();

                return listaInstructores.ConvertAll(cliente => cliente as Instructor).ToList();

            }
            catch (SqlException sqlError)
            {
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
        #endregion

    }
}
