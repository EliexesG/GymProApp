using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    /// <summary>
    /// Clase unicamente de acceso a datos para los Encabezados de Factura de la base de datos
    /// </summary>
    public interface IFacturaEncabezadoBLLDatos
    {
        /// <summary>
        /// Elimina un Encabezado de Factura de la base de datos por Id
        /// </summary>
        /// <param name="pCodigo"> Codigo del Encabezado de Factura a eliminar</param>
        void EliminarFacturaEncabezado(int pCodigo);

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

        /// <summary>
        /// Obtiene una lista de todos los Encabezados de Factura en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo FacturaEncabezado</returns>
        List<FacturaEncabezado> ObtenerFacturaEncabezadoTodas();

        /// <summary>
        /// Obtiene el ultimo Encabezado de Factura agregado en base a la identificacion del Usuario de la base de datos
        /// </summary>
        /// <param name="pIdentificacion">Identifiacion del usuario relacionado al Encabezado de Factura a buscar</param>
        /// <returns>Entidad de tipo FacturaEncabezado</returns>
        FacturaEncabezado ObtenerUltimaFacturaEncabezadoIdentificacionUsuario(string pIdentificacion);
    }
}