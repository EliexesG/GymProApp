using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Interfaces;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class UsuarioBLL : IUsuarioBLL
    {

        private IUsuarioDAL oUsuarioDAL;

        public UsuarioBLL()
        {
            oUsuarioDAL = UsuarioDAL.GetInstance();
        }

        #region Logica
        public int CalcularEdadUsuario(DateTime pFechaNacimiento)
        {
            try
            {

                DateTime fechaActual = DateTime.Now;

                return DateTime.Today.AddTicks(-pFechaNacimiento.Ticks).Year - 1; ;

            }
            catch(Exception er)
            {
                throw er;
            }
        }
        #endregion

        #region Acceso a datos
        /// <summary>
        /// Elimina un usuario de la base de datos por su Identificacion
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario a eliminar </param>
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

        /// <summary>
        /// Inserta un Usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"> Usuario a insertar </param>
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

        /// <summary>
        /// Modifica un Usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"> Usuario a modificar </param>
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

        /// <summary>
        /// Obtiene el Usuario relacionado a la Identificacion de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario a buscar </param>
        /// <returns>Entidad de tipo Usuario</returns>
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

        /// <summary>
        /// Obtiene una lista de todos los Usuarios activos de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Usuario</returns>
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

        /// <summary>
        /// Obtiene una lista de todos los Usuarios inactivos de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Usuario</returns>
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

        /// <summary>
        /// Activa un Usuario por su Identificacion en la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario">Identificacion del Usuario a activar</param>
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
        #endregion

    }
}
