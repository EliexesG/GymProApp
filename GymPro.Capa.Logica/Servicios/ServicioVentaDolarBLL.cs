using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Datos.Servicios;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Servicios
{
    public class ServicioVentaDolarBLL : IServicioVentaDolarBLL
    {

        private IServicioVentaDolarDAL oServicioVentaDolarDAL;

        public ServicioVentaDolarBLL()
        {
            oServicioVentaDolarDAL = ServicioVentaDolarDAL.GetInstance();
        }

        /// <summary>
        /// Obtiene el precio de venta del dolar a la fecha actual
        /// </summary>
        /// <returns>Double que representa el precio del dolar en colones</returns>
        public double ObtenerPrecioVentaDolar()
        {
            try
            {
                return oServicioVentaDolarDAL.ObtenerPrecioVentaDolar();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

    }
}
