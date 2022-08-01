using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    class FacturaEncabezadoBLL : IFacturaEncabezadoBLL
    {

        private const double PorcentajeMulta = 1.17D;

        private IFacturaEncabezadoDAL oFacturaEncabezadoDAL;

        public FacturaEncabezadoBLL()
        {
            oFacturaEncabezadoDAL = FacturaEncabezadoDAL.GetInstance();
        }

        #region Logica
        public bool EstaMoroso(DateTime pFechaSiguientePago)
        {
            return pFechaSiguientePago >= DateTime.Now;
        }

        public DateTime SiguientePago(DateTime pFechaPagoActual)
        {
            return pFechaPagoActual.AddMonths(1);
        }

        public double CalcularMulta(double pMontoServicios)
        {
            return pMontoServicios * PorcentajeMulta;
        }

        public double CalcularMontoTotal(double pMontoServicios, double pMontoMulta)
        {
            return pMontoServicios + pMontoMulta;
        }

        public int SiguienteCodigo()
        {
            try
            {
                return this.ObtenerFacturaEncabezadoTodas().Max(encabezado => encabezado.Codigo) + 1;
            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion

        #region Acceso a datos
        /// <summary>
        /// Elimina un Encabezado de Factura de la base de datos por Id
        /// </summary>
        /// <param name="pCodigo"> Codigo del Encabezado de Factura a eliminar</param>
        public void EliminarFacturaEncabezado(int pCodigo)
        {
            try
            {

                oFacturaEncabezadoDAL.EliminarFacturaEncabezado(pCodigo);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Inserta un Encabezado de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"> Encabezado de Factura a insertar </param>
        public void InsertarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado)
        {
            try
            {

                oFacturaEncabezadoDAL.InsertarFacturaEncabezado(pFacturaEncabezado);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Modifica un Encabezado de Factura en la base de datos
        /// </summary>
        /// <param name="pFacturaEncabezado"> Encabezado de Factura a modificar </param>
        public void ModificarFacturaEncabezado(FacturaEncabezado pFacturaEncabezado)
        {
            try
            {

                oFacturaEncabezadoDAL.ModificarFacturaEncabezado(pFacturaEncabezado);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtiene un Encabezado de Factura por su Id
        /// </summary>
        /// <param name="pCodigo"> Codigo de Encabezado de Factura a buscar </param>
        /// <returns></returns>
        public FacturaEncabezado ObtenerFacturaEncabezadoId(int pCodigo)
        {
            try
            {

                return oFacturaEncabezadoDAL.ObtenerFacturaEncabezadoId(pCodigo);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtiene una lista de Encabezados de Facturas relacionados a la Identificacion de un Usuario de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario relacionado a los Encabezados de Factura a buscar </param>
        /// <returns>Lista de entidades de tipo FacturaEncabezado</returns>
        public List<FacturaEncabezado> ObtenerFacturaEncabezadoIdentificacionUsuario(string pIdentificacionUsuario)
        {
            try
            {

                return oFacturaEncabezadoDAL.ObtenerFacturaEncabezadoIdentificacionUsuario(pIdentificacionUsuario).
                    OrderBy(factura => factura.FechaPago).ToList();

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtiene una lista de todos los Encabezados de Factura en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo FacturaEncabezado</returns>
        public List<FacturaEncabezado> ObtenerFacturaEncabezadoTodas()
        {
            try
            {

                return oFacturaEncabezadoDAL.ObtenerFacturaEncabezadoTodas().
                    OrderBy(factura => factura.FechaPago).ToList();

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion

    }
}
