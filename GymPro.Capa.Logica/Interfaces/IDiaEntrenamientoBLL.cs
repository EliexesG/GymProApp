using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Dias de Entrenamiento de la base de datos
    /// </summary>
    public interface IDiaEntrenamientoBLL
    {
        /// <summary>
        /// Elimina un Dia de un Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pDiaEntrenamiento"> Dia de Entrenamiento a eliminar </param>
        void EliminarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento);

        /// <summary>
        /// Inserta un Dia de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pDiaEntrenamiento"> Dia de Entrenamiento a insertar </param>
        void InsertarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento);

        /// <summary>
        /// Obtiene los días disponibles que no estén asignados al entrenamiento de la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Lista de Dias</returns>
        List<Dia> ObtenerDiaDisponibleSobreCodigoEntrenamiento(int pCodigoEntrenamiento);

        /// <summary>
        /// Obtiene una lista de Dias de Entrenamiento de la base de datos relacionados al Codigo de Entrenamiento
        /// </summary>
        /// <param name="pCodigoEntrenamiento"> Codigo de Entrenamiento relacionado a los Dias de Entrenamiento a buscar </param>
        /// <returns>Lista de entidades de tipo DiaEntrenamiento</returns>
        List<DiaEntrenamiento> ObtenerDiaEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento);

        /// <summary>
        /// Obtiene una lista de todos los Dias de Entrenamiento de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo DiaEntrenamiento</returns>
        List<DiaEntrenamiento> ObtenerDiaEntrenamientoTodos();
    }
}