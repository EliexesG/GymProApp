using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Expedientes de Usuarios de la base de datos
    /// </summary>
    public interface IExpedienteUsuarioDAL
    {
        /// <summary>
        /// Inserta un Expediente de Usuario en la base de datos
        /// </summary>
        /// <param name="pExpediente"> Expediente de Usuario a insertar </param>
        void InsertarExpedienteUsuario(ExpedienteUsuario pExpediente);

        /// <summary>
        /// Modifica un Expediente de Usuario en la base de datos
        /// </summary>
        /// <param name="pExpediente"> El Expediente de Usuario a Modificar </param>
        void ModificarExpedienteUsuario(ExpedienteUsuario pExpediente);

        /// <summary>
        /// Elimina un Expediente de Usuario de la base de datos por sus Ids
        /// </summary>
        /// <param name="pFecha"> Fecha del Expediente Usuario a eliminar </param>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario relacionado al Expediente Usuario a Eliminar</param>
        void EliminarExpedienteUsuario(DateTime pFecha, string pIdentificacionUsuario);

        /// <summary>
        /// Obtiene una lista de todos los Expedientes de Usuario almacenados en la base de datos
        /// </summary>
        /// <returns>Lista de Entidades de tipo ExpedienteUsuario</returns>
        List<ExpedienteUsuario> ObtenerExpedienteUsuarioTodos();

        /// <summary>
        /// Obtiene un Expediente de Usuario especifico de la base de datos por medio de sus Ids
        /// </summary>
        /// <param name="pFecha"> Fecha del Expediente Usuario a buscar </param>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario relacionado al Expediente Usuario a buscar </param>
        /// <returns>Entidad de tipo ExpedienteUsuario</returns>
        ExpedienteUsuario ObtenerExpedienteUsuarioId(DateTime pFecha, string pIdentificacionUsuario);

        /// <summary>
        /// Obtiene una lista historial con todos los Expedientes de Usuario relacionados a la Identificacion de Usuario de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion  del Usuario relacionado a los Expedientes de Usuario a buscar </param>
        /// <returns>Lista de Entidades de tipo ExpedienteUsuario</returns>
        List<ExpedienteUsuario> ObtenerExpedienteUsuarioIdentificacionUsuario(string pIdentificacionUsuario);
    }
}