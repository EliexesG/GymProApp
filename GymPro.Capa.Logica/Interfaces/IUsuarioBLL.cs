using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Usuarios de la base de datos
    /// </summary>
    public interface IUsuarioBLL
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

        /// <summary>
        /// Calcula la edad actual en base a la fecha de nacimiento del Usuario y la fecha actual
        /// </summary>
        /// <param name="pFechaNacimiento">Fecha de nacimiento a utilizar</param>
        /// <returns>Integer que representa la edad del Usuario</returns>
        int CalcularEdadUsuario(DateTime pFechaNacimiento);

        /// <summary>
        /// Obtener la lista de los Clientes en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Cliente</returns>
        List<Cliente> ObtenerUsuariosCliente();

        /// <summary>
        /// Obtener la lista de los Instructores en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Instructor</returns>
        List<Instructor> ObtenerUsuariosInstructor();
    }
}