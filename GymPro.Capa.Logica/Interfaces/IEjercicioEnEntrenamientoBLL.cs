using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Ejercicios en Entrenamiento de la base de datos
    /// </summary>
    public interface IEjercicioEnEntrenamientoBLL
    {
        /// <summary>
        /// Elimina un Ejercicio de Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento">Codigo del entrenamiento relacionado al ejercicio a eliminar</param>
        /// <param name="pCodigoEjercicio">Codigo del ejercicio de Entrenamiento a eliminar</param>
        void EliminarEjercicioEnEntrenamiento(int pCodigoEntrenamiento, int pCodigoEjercicio);

        /// <summary>
        /// Insertar un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEjercicioEnEntrenamiento">Ejercicio en Entrenamiento a eliminar</param>
        void InsertarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento);

        /// <summary>
        /// Modificar un Ejercicio en Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEjercicioEnEntrenamiento">Ejercicio en Entrenamiento a modificar</param>
        void ModificarEjercicioEnEntrenamiento(EjercicioEnEntrenamiento pEjercicioEnEntrenamiento);

        /// <summary>
        /// Retorna una lista de todos los Ejercicios en Entrenamiento de la base de datos pertenecientes a ese codigo de Ejercicio
        /// </summary>
        /// <param name="pCodigoEjercicio">Codigo de Ejercicio de los Ejercicios en Entrenamientos a buscar</param>
        /// <returns>Lista de entidades de tipo EjercicioEnEntrenamiento</returns>
        List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoCodigoEjercicio(int pCodigoEjercicio);

        /// <summary>
        /// Obtiene una lista de Ejercicios en Entrenamiento relacionados al Codigo de Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento">Codigo de Entrenamiento relacionado a los Ejercicios en Entrenamiento a buscar</param>
        /// <returns>Lista de entidades de tipo EjericicioEnEntrenamiento</returns>
        List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento);

        /// <summary>
        /// Obtiene un Ejercicio en Entrenamiento relacionado a sus Ids de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento"> Codigo del entrenamiento relacionado al ejercicio a buscar</param>
        /// <param name="pCodigoEjercicio">Codigo del ejercicio de Entrenamiento a buscar</param>
        /// <returns>Entidad de tipo EjercicioEnEntrenamiento</returns>
        EjercicioEnEntrenamiento ObtenerEjercicioEnEntrenamientoId(int pCodigoEntrenamiento, int pCodigoEjercicio);

        /// <summary>
        /// Retorna una lista de todos los Ejercicios en Entrenamiento en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo EjercicioEnEntrenamiento</returns>
        List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoTodos();
    }
}