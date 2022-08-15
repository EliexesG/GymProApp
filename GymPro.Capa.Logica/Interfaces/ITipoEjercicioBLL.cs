using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Tipos de Ejercicios de la base de datos
    /// </summary>
    public interface ITipoEjercicioBLL
    {
        /// <summary>
        /// Elimina un Tipo de Ejercicio de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Tipo de Ejercicio a eliminar</param>
        void EliminarTipoEjercicio(int pCodigo);

        /// <summary>
        /// Inserta un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio">Tipo de Ejercicio a insertar</param>
        void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio);

        /// <summary>
        /// Modifica un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio">Tipo de Ejercicio a modificar</param>
        void ModificarTipoEjercicio(TipoEjercicio pTipoEjercicio);

        /// <summary>
        /// Obtiene un Tipo de Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Tipo de Ejercicio a buscar</param>
        /// <returns>Entidad de TipoEjercicio</returns>
        TipoEjercicio ObtenerTipoEjercicioId(int pCodigo);

        /// <summary>
        /// Obtiene una lista de todos los Tipos de Ejercicio de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de TipoEjercicio</returns>
        List<TipoEjercicio> ObtenerTipoEjercicioTodos();
    }
}