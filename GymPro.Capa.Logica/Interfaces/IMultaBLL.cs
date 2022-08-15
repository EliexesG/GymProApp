using GymPro.Capa.Entidades.Implementaciones;

namespace GymPro.Capa.Logica.Interfaces
{
    /// <summary>
    /// Clase de acceso a datos para el Porcentaje de Multa de un JSON local
    /// </summary>
    public interface IMultaBLL
    {
        /// <summary>
        /// Modifica el porcentaje de la multa en el JSON local
        /// </summary>
        /// <param name="pMulta">Multa a modificar</param>
        void ModificarMulta(Multa pMulta);

        /// <summary>
        /// Obtiene la Multa a utilizar por la Facturacion, en caso de no existir la crea con un porcentaje base (17%), 
        /// esto desde un JSON local
        /// </summary>
        /// <returns>Entidad de tipo Multa</returns>
        Multa ObtenerMulta();
    }
}