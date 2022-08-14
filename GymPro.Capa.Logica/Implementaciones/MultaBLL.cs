using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Implementaciones
{

    public class MultaBLL : IMultaBLL
    {
        private IMultaDAL oMultaDAL;

        public MultaBLL()
        {
            oMultaDAL = new MultaDAL();
        }

        #region Acceso datos
        /// <summary>
        /// Obtiene la Multa a utilizar por la Facturacion, en caso de no existir la crea con un porcentaje base, 
        /// esto desde un JSON local
        /// </summary>
        /// <returns>Entidad de tipo Multa</returns>
        public Multa ObtenerMulta()
        {
            try
            {
                return oMultaDAL.ObtenerMulta();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// Modifica el porcentaje de la multa en el JSON local
        /// </summary>
        /// <param name="pMulta">Multa a modificar</param>
        public void ModificarMulta(Multa pMulta)
        {
            try
            {
                oMultaDAL.ModificarMulta(pMulta);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        #endregion
    }
}
