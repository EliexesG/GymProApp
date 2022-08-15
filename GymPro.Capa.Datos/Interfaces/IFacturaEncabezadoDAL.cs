using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para los Encabezados de Factura la base de datos
    /// </summary>
    public interface IFacturaEncabezadoDAL
    {
        /// <summary>
        /// Inserta un Encabezado de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"> Encabezado de Factura a insertar </param>
        void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);

        /// <summary>
        /// Modifica un Encabezado de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"> Encabezado de Factura a modificar </param>
        void ModificarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado);

        /// <summary>
        /// Elimina un Encabezado de Factura de la base de datos por Id
        /// </summary>
        /// <param name="pCodigo"> Codigo del Encabezado de Factura a eliminar</param>
        void EliminarFacturaEncabezado(int pCodigo);

        /// <summary>
        /// Obtiene una lista de todos los Encabezados de Factura en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo FacturaEncabezado</returns>
        List<FacturaEncabezado> ObtenerFacturaEncabezadoTodas();

        /// <summary>
        /// Obtiene un Encabezado de Factura por su Id
        /// </summary>
        /// <param name="pCodigo"> Codigo de Encabezado de Factura a buscar </param>
        /// <returns>Entidad de tipo FacturaEncabezado</returns>
        FacturaEncabezado ObtenerFacturaEncabezadoId(int pCodigo);

        /// <summary>
        /// Obtiene una lista de Encabezados de Facturas relacionados a la Identificacion de un Usuario de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario relacionado a los Encabezados de Factura a buscar </param>
        /// <returns>Lista de entidades de tipo FacturaEncabezado</returns>
        List<FacturaEncabezado> ObtenerFacturaEncabezadoIdentificacionUsuario(string pIdentificacionUsuario);
    }
}
