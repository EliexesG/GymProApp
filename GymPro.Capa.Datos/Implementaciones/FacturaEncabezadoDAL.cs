using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class FacturaEncabezadoDAL : IFacturaEncabezadoDAL
    {
        private static FacturaEncabezadoDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo FacturaEncabezadoDAL
        /// </summary>
        /// <returns></returns>
        public static FacturaEncabezadoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new FacturaEncabezadoDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Inserta una factura encabezado en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"></param>
        public void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado)
        {

        }

        /// <summary>
        /// Elimina una factura encabezado de la base de datos por su id
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarFacturaEncabezadoPorID(int pId)
        {

        }

        /// <summary>
        /// Actualiza una factura encabezado en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"></param>
        public void ActualizarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado)
        {

        }

        /// <summary>
        /// Selecciona todas las factura encabezado de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<FacturaEncabezado> SeleccionarTodasFacturasEncabezado()
        {
            return default;
        }

        /// <summary>
        /// Selecciona todas las facturas encabezado de la base de datos en base a la id de usuario
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public List<FacturaEncabezado> SeleccionarFacturasEncabezadoIDUsaurio(string pIdUsuario)
        {
            return default;
        }
    }
}
