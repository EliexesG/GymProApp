using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Dias de Entrenamientos de la base de datos
    /// </summary>
    public interface IDiaEntrenamientoDAL
    {
        /// <summary>
        /// Inserta un Dia de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pDiaEntrenamiento"> Dia de Entrenamiento a insertar </param>
        void InsertarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento);

        /// <summary>
        /// Elimina un Dia de un Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pDiaEntrenamiento"> Dia de Entrenamiento a eliminar </param>
        void EliminarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento);

        /// <summary>
        /// Obtiene una lista de todos los Dias de Entrenamiento de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo DiaEntrenamiento</returns>
        List<DiaEntrenamiento> ObtenerDiaEntrenamientoTodos();

        /// <summary>
        /// Obtiene una lista de Dias de Entrenamiento de la base de datos relacionados al Codigo de Entrenamiento
        /// </summary>
        /// <param name="pCodigoEntrenamiento"> Codigo de Entrenamiento relacionado a los Dias de Entrenamiento a buscar </param>
        /// <returns>Lista de entidades de tipo DiaEntrenamiento</returns>
        List<DiaEntrenamiento> ObtenerDiaEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento);
    }
}
