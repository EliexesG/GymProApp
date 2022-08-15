using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Tipos de Ejercicio de la base de datos
    /// </summary>
    public interface ITipoEjercicioDAL
    {
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
        /// Elimina un Tipo de Ejercicio de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Tipo de Ejercicio a eliminar</param>
        void EliminarTipoEjercicio(int pCodigo);

        /// <summary>
        /// Obtiene una lista de todos los Tipos de Ejercicio de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de TipoEjercicio</returns>
        List<TipoEjercicio> ObtenerTipoEjercicioTodos();

        /// <summary>
        /// Obtiene un Tipo de Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Tipo de Ejercicio a buscar</param>
        /// <returns>Entidad de TipoEjercicio</returns>
        TipoEjercicio ObtenerTipoEjercicioId(int pCodigo);
    }
}
