using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class FacturaEncabezadoBLL : IFacturaEncabezadoBLLDatos, IFacturaEncabezadoBLLGestor
    {


        private MultaDAL oMultaDAL = new MultaDAL();
        private IFacturaEncabezadoDAL oFacturaEncabezadoDAL;

        public FacturaEncabezadoBLL()
        {
            oFacturaEncabezadoDAL = FacturaEncabezadoDAL.GetInstance();
        }

        #region Logica
        public bool YaPagado(DateTime pFechaSiguientePago)
        {
            return pFechaSiguientePago >= DateTime.Now;
        }

        public bool EstaMoroso(DateTime pFechaSiguientePago)
        {
            return pFechaSiguientePago < DateTime.Now;
        }

        public DateTime SiguientePago(DateTime pFechaPagoActual)
        {
            return pFechaPagoActual.AddMonths(1);
        }

        public double CalcularMulta(double pMontoServicios)
        {
            return pMontoServicios * oMultaDAL.ObtenerMulta().PorcentajeMulta;
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

        public double CalcularMontoServicios(List<Servicio> pServicios)
        {
            try
            {
                return new FacturaDetalleBLL().CalcularMontoServicios(pServicios);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public byte[] ObtenerCodigoQR(int codigo)
        {
            try
            {
                return CodigoQR.ObtenerCodigoQR(codigo);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public void ValidarTarjeta(Tarjeta pTarjeta)
        {
            try
            {

                ValidarNumeroTarjeta(pTarjeta.Numero);
                ValidarFechaExpiracion(pTarjeta.MesExpiracion, pTarjeta.AnnoExpiracion);
                ValidarCodigoSeguridad(pTarjeta.CodigoSeguridad);

            }
            catch(Exception er)
            {
                throw er;
            }
        }

        private void ValidarNumeroTarjeta(string pNumero)
        {

            try
            {
                long.Parse(pNumero);
            }
            catch (Exception)
            {
                throw new Exception("El campo del número de tarjeta debe ser llenado solamente con números");
            }

            int sumaDigitos = 0;
            int pesoActual = 2;

            List<int> multiplicacionProductos = new List<int>();

            foreach(char numero in pNumero)
            {
                int numeroActual = (int)char.GetNumericValue(numero);

                int resultadoMult = numeroActual * pesoActual;

                if(resultadoMult > 9)
                {
                    int num1 = int.Parse(resultadoMult.ToString()[0].ToString());
                    int num2 = int.Parse(resultadoMult.ToString()[1].ToString());

                    resultadoMult = num1 + num2;
                }

                multiplicacionProductos.Add(resultadoMult);

                pesoActual = pesoActual == 2 ? 1 : 2;
            }

            sumaDigitos = multiplicacionProductos.Sum();

            if(sumaDigitos % 10 != 0)
            {
                throw new Exception("El número de la tarjeta no es válido, digite un número válido");
            }
        }

        private void ValidarFechaExpiracion(int pMes, int pAnno)
        {

            int mesActual = DateTime.Now.Month;
            int annoActual = DateTime.Now.Year;
            bool expiro = false;

            if(annoActual > pAnno)
            {
                expiro = true;
            }
            else if (annoActual == pAnno && mesActual >= pMes)
            {
                expiro = true;
            }

            if (expiro)
            {
                throw new Exception("La tarjeta con la que se desea pagar ha expirado");
            }
        }

        private void ValidarCodigoSeguridad(string pCodigo)
        {

            try
            {
                int.Parse(pCodigo);
            }
            catch (Exception)
            {
                throw new Exception("El campo del código debe ser llenado solamente con números");
            }

            if (pCodigo.Length != 3)
            {
                throw new Exception("Código de seguridad incorrecto, debe ser un número de 3 dígitos");
            }
        }
        #endregion

        #region Acceso a datos
        public FacturaEncabezado ObtenerUltimaFacturaEncabezadoIdentificacionUsuario(string pIdentificacion)
        {
            try
            {

                return oFacturaEncabezadoDAL.ObtenerFacturaEncabezadoIdentificacionUsuario(pIdentificacion).Last();

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
