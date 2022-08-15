using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Ejercicios de la base de datos
    /// </summary>
    public interface IEjercicioBLL
    {
        /// <summary>
        /// Elimina un Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Ejercicio a eliminar</param>
        void EliminarEjercicio(int pCodigo);

        /// <summary>
        /// Inserta un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio">Ejercicio a insertar</param>
        void InsertarEjercicio(Ejercicio pEjercicio);

        /// <summary>
        /// Modifica un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio">Ejercicio a modificar</param>
        void ModificarEjercicio(Ejercicio pEjercicio);

        /// <summary>
        /// Obtiene una lista de Ejercicios por Codigo del Tipo de Ejercicio de la base de datos
        /// </summary>
        /// <param name="pCodigoTipo">Codigo del Tipo de Ejercicio de los Ejercicios a buscar</param>
        /// <returns>Lista de Entidades de tipo Ejercicio</returns>
        List<Ejercicio> ObtenerEjercicioCodigoTipo(int pCodigoTipo);

        /// <summary>
        /// Obtener una lista de Ejercicios que NO estan en el entrenamiento referenciado por codigo de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del entrenamiento</param>
        /// <returns>Lista de entidades de tipo Ejercicio</returns>
        List<Ejercicio> ObtenerEjercicioDisponibleCodigoEntrenamiento(int pCodigo);

        /// <summary>
        /// Obtener una lista de Ejercicios que NO estan en el entrenamiento referenciado por codigo de entrenamiento y el tipo de ejercicio de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del entrenamiento</param>
        /// <param name="pTipoEjercicio">Codigo del tipo de ejercicio</param>
        /// <returns>Lista de entidades de tipo Ejercicio</returns>
        List<Ejercicio> ObtenerEjercicioDisponibleCodigoEntrenamientoYTipoEjercicio(int pCodigoEntrenamiento, int pTipoEjercicio);

        /// <summary>
        /// Obtiene un Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Ejercicio a buscar</param>
        /// <returns>Entidad de tipo Ejercicio</returns>
        Ejercicio ObtenerEjercicioId(int pCodigo);

        /// <summary>
        /// Obtiene una lista de todos los Ejercicios en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Ejercicio</returns>
        List<Ejercicio> ObtenerEjercicioTodos();
    }
}