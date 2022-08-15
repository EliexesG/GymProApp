using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Gestor con los metodos logicos utilizados para realizar los diferentes calculos para los Encabezados de Factura
    /// </summary>
    public interface IFacturaEncabezadoBLLGestor
    {
        /// <summary>
        /// Calcula el monto total en base a la lista de servicios dada (cada servicio tiene su monto, estos seran calculados y sumados), recalcar 
        /// que este metodo hace una llamada al BLL de DetalleFactura
        /// </summary>
        /// <param name="pServicios">Lista de entidades de tipo Servicio cuyos montos seran calculados y sumados</param>
        /// <returns>Double representando el total a pagar por los servicios</returns>
        double CalcularMontoServicios(List<Servicio> pServicios);

        /// <summary>
        /// Calcula una suma entre el monto de sercicios y el monto de la multa para dar el total a pagar
        /// </summary>
        /// <param name="pMontoServicios">Monto de servicios a utilizar</param>
        /// <param name="pMontoMulta">Monto de la multa a utilizar (puede ser 0 si no tiene)</param>
        /// <returns>Double representando el total a pagar</returns>
        double CalcularMontoTotal(double pMontoServicios, double pMontoMulta);

        /// <summary>
        /// Calcula la multa en base al monto de servicios, haciendo una llamada al BLL de Multa para utilizar el porcentaje guardado
        /// </summary>
        /// <param name="pMontoServicios">Monto de servicios a utilizar</param>
        /// <returns>Double representando el total de la multa</returns>
        double CalcularMulta(double pMontoServicios);

        /// <summary>
        /// Calcula en base a la fecha dada por parametro y la fecha actual si el usuaro esta moroso (Cuando se esta moroso quiere decir que se paso de la fecha
        /// limite para pagar)
        /// </summary>
        /// <param name="pFechaSiguientePago">Fecha del proximo pago de la ultima facturacion</param>
        /// <returns>Bool que indica si esta moroso o no</returns>
        bool EstaMoroso(DateTime pFechaSiguientePago);

        /// <summary>
        /// Codifica en base al codigo de factura, un codigo QR que lo represente
        /// </summary>
        /// <param name="codigo">Codigo numerico que representa el codigo de la Factura</param>
        /// <returns>Codigo QR en Array de bytes</returns>
        byte[] ObtenerCodigoQR(int codigo);

        /// <summary>
        /// Verifica cual es el siguiente codigo a utilizar en la siguiente Factura que se cree
        /// </summary>
        /// <returns>Integer representando el codigo de la siguiente Factura</returns>
        int SiguienteCodigo();

        /// <summary>
        /// Calcula el siguiente pago (mensual) en base a la fecha del pago actual
        /// </summary>
        /// <param name="pFechaPagoActual">Fecha del pago actual a utilizar</param>
        /// <returns>Fecha con el siguiente pago</returns>
        DateTime SiguientePago(DateTime pFechaPagoActual);

        /// <summary>
        /// Valida todos los datos de la Tarjeta, para asi verificar que sea correcta, si no es valida este metodo tirara las Excepciones 
        /// que lo indiquen
        /// </summary>
        /// <param name="pTarjeta">Tarjeta a validar</param>
        void ValidarTarjeta(Tarjeta pTarjeta);

        /// <summary>
        /// En base a la fecha del proximo pago de la ultima factura del usuario y la fecha actual, verifica que todavia no debe pagar (si la fecha actual es menor
        /// a la del siguiente pago)
        /// </summary>
        /// <param name="pFechaSiguientePago">Fecha del siguiente pago a verificar</param>
        /// <returns>Bool que indica si la mensualidad esta paga o no</returns>
        bool YaPagado(DateTime pFechaSiguientePago);
    }
}