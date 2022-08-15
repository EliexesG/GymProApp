using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Implementaciones
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Encabezados de Factura de la base de datos (Esta incluye los metodos logicos del Gestor y metodos de acceso a datos)
    /// </summary>
    public class FacturaEncabezadoBLL : IFacturaEncabezadoBLLDatos, IFacturaEncabezadoBLLGestor
    {

        //Log4net
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private MultaDAL oMultaDAL = new MultaDAL();
        private IFacturaEncabezadoDAL oFacturaEncabezadoDAL;

        public FacturaEncabezadoBLL()
        {
            oFacturaEncabezadoDAL = FacturaEncabezadoDAL.GetInstance();
        }

        #region Logica
        /// <inheritdoc />
        public bool YaPagado(DateTime pFechaSiguientePago)
        {
            return pFechaSiguientePago >= DateTime.Now;
        }

        /// <inheritdoc />
        public bool EstaMoroso(DateTime pFechaSiguientePago)
        {
            return pFechaSiguientePago < DateTime.Now;
        }

        /// <inheritdoc />
        public DateTime SiguientePago(DateTime pFechaPagoActual)
        {
            return pFechaPagoActual.AddMonths(1);
        }

        /// <inheritdoc />
        public double CalcularMulta(double pMontoServicios)
        {
            return pMontoServicios * oMultaDAL.ObtenerMulta().PorcentajeMulta;
        }

        /// <inheritdoc />
        public double CalcularMontoTotal(double pMontoServicios, double pMontoMulta)
        {
            return pMontoServicios + pMontoMulta;
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <summary>
        /// Valida el numero de tarjeta utilizando el Algoritmo de Luhn (Modulo 10) si es incorrecta lanzara la excepcion
        /// </summary>
        /// <param name="pNumero">Numero de la tarjeta a validar</param>
        private void ValidarNumeroTarjeta(string pNumero)
        {

            try
            {
                long.Parse(pNumero);
            }
            catch (Exception)
            {
                _MyLogControlEventos.InfoFormat("Info {0}", "Se trato de insertar un numero de factura con caracteres no numericos");

                throw new Exception("El campo del número de tarjeta debe ser llenado solamente con números");
            }

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

            int sumaDigitos = multiplicacionProductos.Sum();

            if (sumaDigitos % 10 != 0)
            {
                _MyLogControlEventos.InfoFormat("Info {0}", "Se trato de insertar un numero de tarjeta no valido");

                throw new Exception("El número de la tarjeta no es válido, digite un número válido");
            }
        }

        /// <summary>
        /// Valida que la fecha de expiracion de la tarjeta no se haya vencido aun, si esta expirada lanzara la excepcion
        /// </summary>
        /// <param name="pMes">Mes de expiracion a validar</param>
        /// <param name="pAnno">Anno de expiracion a validar</param>
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
                _MyLogControlEventos.InfoFormat("Info {0}", "Se trato de insertar una fecha de expiracion ya expirada");

                throw new Exception("La tarjeta con la que se desea pagar ha expirado");
            }
        }

        /// <summary>
        /// Se valida que el codigo de seguridad sea numerico y compuesto de 3 digitos, si no entonces se lanzara la excepcion
        /// </summary>
        /// <param name="pCodigo">Codigo a validar</param>
        private void ValidarCodigoSeguridad(string pCodigo)
        {

            try
            {
                int.Parse(pCodigo);
            }
            catch (Exception)
            {
                _MyLogControlEventos.InfoFormat("Info {0}", "Se trato de insertar un numero de codigo de tarjeta con caracteres no numericos");

                throw new Exception("El campo del código debe ser llenado solamente con números");
            }

            if (pCodigo.Length != 3)
            {
                _MyLogControlEventos.InfoFormat("Info {0}", "Se trato de insertar un numero de codigo de tarjeta mayor a 3 digitos");

                throw new Exception("Código de seguridad incorrecto, debe ser un número de 3 dígitos");
            }
        }
        #endregion

        #region Acceso a datos
        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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
