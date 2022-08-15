using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Ejercicios de la base de datos
    /// </summary>
    public interface IEjercicioDAL
    {
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
        /// Elimina un Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Ejercicio a eliminar</param>
        void EliminarEjercicio(int pCodigo);

        /// <summary>
        /// Obtiene una lista de todos los Ejercicios en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Ejercicio</returns>
        List<Ejercicio> ObtenerEjercicioTodos();

        /// <summary>
        /// Obtiene un Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Ejercicio a buscar</param>
        /// <returns>Entidad de tipo Ejercicio</returns>
        Ejercicio ObtenerEjercicioId(int pCodigo);

        /// <summary>
        /// Obtiene una lista de Ejercicios por Codigo del Tipo de Ejercicio de la base de datos
        /// </summary>
        /// <param name="pCodigoTipo">Codigo del Tipo de Ejercicio de los Ejercicios a buscar</param>
        /// <returns>Lista de Entidades de tipo Ejercicio</returns>
        List<Ejercicio> ObtenerEjercicioCodigoTipo(int pCodigoTipo);
    }
}
