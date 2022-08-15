using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Expedientes de Usuarios de la base de datos
    /// </summary>
    public interface IExpedienteUsuarioBLL
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

        /// <summary>
        /// Calcula el IMC (Indice de Masa Corporal) basado en las propiedades de Peso y Altura del expediente de usuario dado por parametro
        /// </summary>
        /// <param name="pExpedienteUsuario">Expediente de Usuario utilizado para calcular el IMC</param>
        /// <returns>double representando el IMC (Indice de Masa Corporal)</returns>
        double CalcularIMC(ExpedienteUsuario pExpedienteUsuario);

        /// <summary>
        /// Calcula el Metabolismo Basal  basado en las propiedades de Peso y Altura del expediente de usuario dado por parametro,
        /// ademas de la edad y genero del usuario (dependiendo del genero el resultado puede variar)
        /// </summary>
        /// <param name="pExpedienteUsuario">Expediente de Usuario utilizado para calcular el Metabolismo Basal</param>
        /// <param name="pEdad">Edad del usuario</param>
        /// <param name="pGenero">Genero del usuario</param>
        /// <returns>Double representando el Metabolismo Basal</returns>
        double CalcularMetabolismoBasal(ExpedienteUsuario pExpedienteUsuario, int pEdad, Genero pGenero);
    }
}
