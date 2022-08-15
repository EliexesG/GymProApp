using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Ejercicios en Entrenamientos de la base de datos
    /// </summary>
    public interface IEjercicioEnEntrenamientoDAL
    {
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
        /// Elimina un Ejercicio de Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento">Codigo del entrenamiento relacionado al ejercicio a eliminar</param>
        /// <param name="pCodigoEjercicio">Codigo del ejercicio de Entrenamiento a eliminar</param>
        void EliminarEjercicioEnEntrenamiento(int pCodigoEntrenamiento, int pCodigoEjercicio);

        /// <summary>
        /// Retorna una lista de todos los Ejercicios en Entrenamiento en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo EjercicioEnEntrenamiento</returns>
        List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoTodos();

        /// <summary>
        /// Obtiene un Ejercicio en Entrenamiento relacionado a sus Ids de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento"> Codigo del entrenamiento relacionado al ejercicio a buscar</param>
        /// <param name="pCodigoEjercicio">Codigo del ejercicio de Entrenamiento a buscar</param>
        /// <returns>Entidad de tipo EjercicioEnEntrenamiento</returns>
        EjercicioEnEntrenamiento ObtenerEjercicioEnEntrenamientoId(int pCodigoEntrenamiento, int pCodigoEjercicio);

        /// <summary>
        /// Obtiene una lista de Ejercicios en Entrenamiento relacionados al Codigo de Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigoEntrenamiento">Codigo de Entrenamiento relacionado a los Ejercicios en Entrenamiento a buscar</param>
        /// <returns>Lista de entidades de tipo EjericicioEnEntrenamiento</returns>
        List<EjercicioEnEntrenamiento> ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento);
    }
}
