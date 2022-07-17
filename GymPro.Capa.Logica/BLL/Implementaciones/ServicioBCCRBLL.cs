using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class ServicioBCCRBLL : IServicioBCCRBLL
    {
        private IServicioBCCRDAL oServicioBACDAL;

        public ServicioBCCRBLL()
        {
            oServicioBACDAL = ServicioBCCRDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Obtiene el precio de venta del dolar actualmente del BAC
        /// </summary>
        /// <returns></returns>
        public float ObtenerPrecioVentaDolar()
        {
            try
            {
                return oServicioBACDAL.ObtenerPrecioVentaDolar();
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
