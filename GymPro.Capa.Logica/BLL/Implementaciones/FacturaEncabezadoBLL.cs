using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class FacturaEncabezadoBLL : IFacturaEncabezadoBLL
    {
        private IFacturaEncabezadoDAL oFacturaEncabezadoDAL;

        public FacturaEncabezadoBLL()
        {
            oFacturaEncabezadoDAL = FacturaEncabezadoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Inserta una factura encabezado en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"></param>
        public void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado)
        {
            try
            {
                oFacturaEncabezadoDAL.InsertarFacturaEncabezado(pFacturaEncabezado);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Elimina una factura encabezado de la base de datos por su id
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarFacturaEncabezadoPorID(int pId)
        {
            try
            {
                oFacturaEncabezadoDAL.EliminarFacturaEncabezadoPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Actualiza una factura encabezado en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"></param>
        public void ActualizarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado)
        {
            try
            {
                oFacturaEncabezadoDAL.ActualizarFacturaEncabezado(pFacturaEncabezado);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Selecciona todas las factura encabezado de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<FacturaEncabezado> SeleccionarTodasFacturasEncabezado()
        {
            try
            {
                return oFacturaEncabezadoDAL.SeleccionarTodasFacturasEncabezado();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Selecciona todas las facturas encabezado de la base de datos en base a la id de usuario
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public List<FacturaEncabezado> SeleccionarFacturasEncabezadoIDUsaurio(string pIdUsuario)
        {
            try
            {
                return oFacturaEncabezadoDAL.SeleccionarFacturasEncabezadoIDUsaurio(pIdUsuario);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
