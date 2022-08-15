using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para el Control de Ingreso y Egresos de la base de datos
    /// </summary>
    public interface IControlIngresoEgresoBLL
    {
        /// <summary>
        /// Inserta la Hora de Inicio de un Control de Ingreso y Egreso en la base de datos
        /// </summary>
        /// <param name="pControlIngresoEgreso">Control de Ingreso y Egreso a insertar</param>
        void InsertarIngreso(ControlIngresoEgreso pControlIngresoEgreso);

        /// <summary>
        /// Modifica un Control de Ingreso y Egreso con la Hora de Salida en la base de datos
        /// </summary>
        /// <param name="pControlIngresoEgreso">Control de Ingreso y Egreso a insertar</param>
        void ModificarEgreso(ControlIngresoEgreso pControlIngresoEgreso);

        /// <summary>
        /// Obtiene una lista de los Controles de Ingreso y Egreso de un Usuario de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario">Identificacion del Usuario relacionado a los Controles de Ingreso y Egreso a buscar</param>
        /// <returns>Lista de entidades de tipo ControlIngresoEgreso</returns>
        List<ControlIngresoEgreso> ObtenerControlIngresoEgresoIdentificacionUsuario(string pIdentificacionUsuario);

        /// <summary>
        /// Obtiene una lista de todos los Controles de Ingreso y Egreso de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo ControlIngresoEgreso</returns>
        List<ControlIngresoEgreso> ObtenerControlIngresoEgresoTodos();

        /// <summary>
        /// Obtiene el ultimo Control de Ingreso y Egreso de un Usuario de la base de daots
        /// </summary>
        /// <param name="pIdentificacionUsuario">Identificacion del Usuario relacionado al Control de Ingreso y Egreso a buscar</param>
        /// <returns>Entidad de tipo ControlIngresoEgreso</returns>
        ControlIngresoEgreso ObtenerControlIngresoEgresoUltimoIdentificacionUsuario(string pIdentificacionUsuario);
    }
}