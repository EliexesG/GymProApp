using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Usuarios de la base de datos
    /// </summary>
    public interface IUsuarioDAL
    {
        /// <summary>
        /// Inserta un Usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"> Usuario a insertar </param>
        void InsertarUsuario(IUsuario pUsuario);

        /// <summary>
        /// Modifica un Usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"> Usuario a modificar </param>
        void ModificarUsuario(IUsuario pUsuario);

        /// <summary>
        /// Elimina un usuario de la base de datos por su Identificacion
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario a eliminar </param>
        void EliminarUsuario(string pIdentificacionUsuario);

        /// <summary>
        /// Activa un Usuario por su Identificacion en la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario">Identificacion del Usuario a activar</param>
        void ActivarUsuario(string pIdentificacionUsuario);

        /// <summary>
        /// Obtiene una lista de todos los Usuarios activos de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Usuario</returns>
        List<IUsuario> ObtenerUsuarioActivoTodos();

        /// <summary>
        /// Obtiene una lista de todos los Usuarios inactivos de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Usuario</returns>
        List<IUsuario> ObtenerUsuarioInactivoTodos();

        /// <summary>
        /// Obtiene el Usuario relacionado a la Identificacion de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario a buscar </param>
        /// <returns>Entidad de tipo Usuario</returns>
        IUsuario ObtenerUsuarioIdentificacion(string pIdentificacionUsuario);

    }
}
