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
    /// <summary>
    /// Clase de acceso a datos para el Porcentaje de Multa de un JSON local
    /// </summary>
    public class MultaBLL : IMultaBLL
    {
        private IMultaDAL oMultaDAL;

        public MultaBLL()
        {
            oMultaDAL = new MultaDAL();
        }

        #region Acceso datos
        /// <inheritdoc />
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

        /// <inheritdoc />
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
