using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Expedientes de Usuarios de la base de datos
    /// </summary>
    public interface IServicioDAL
    {
        /// <summary>
        /// Obtiene una lista de todos los servicios de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Servicio</returns>
        List<Servicio> ObtenerServicioTodos();

        /// <summary>
        /// Obtiene un Servicio de la base de datos por su Id
        /// </summary>
        /// <param name="pCodigo"> Codigo del servicio a buscar </param>
        /// <returns>Entidad de tipo Servicio</returns>
        Servicio ObtenerServicioId(int pCodigo);
    }
}
