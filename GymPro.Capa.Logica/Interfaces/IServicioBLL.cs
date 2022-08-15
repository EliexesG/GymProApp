using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Servicios de la base de datos
    /// </summary>
    public interface IServicioBLL
    {
        /// <summary>
        /// Calcula el monto de un servicio utilizado la API del BCCR para obtener la venta de dolares en colones (Esto porque el costo de los servicios
        /// en la base de datos esta en dolares)
        /// </summary>
        /// <param name="pServicio"></param>
        /// <returns></returns>
        double CalcularCostoServicio(Servicio pServicio);

        /// <summary>
        /// Obtiene un Servicio de la base de datos por su Id
        /// </summary>
        /// <param name="pCodigo"> Codigo del servicio a buscar </param>
        /// <returns>Entidad de tipo Servicio</returns>
        Servicio ObtenerServicioId(int pCodigo);

        /// <summary>
        /// Obtiene una lista de todos los servicios de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Servicio</returns>
        List<Servicio> ObtenerServicioTodos();
    }
}