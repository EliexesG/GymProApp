namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de llamadas hacia la API del Banco BCCR
    /// </summary>
    public interface IServicioVentaDolarBLL
    {
        /// <summary>
        /// Obtiene el precio de venta del dolar a la fecha actual
        /// </summary>
        /// <returns>Double que representa el precio del dolar en colones</returns>
        double ObtenerPrecioVentaDolar();
    }
}