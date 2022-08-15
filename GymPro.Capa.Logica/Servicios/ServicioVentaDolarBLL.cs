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
    /// <summary>
    /// Clase de llamadas hacia la API del Banco BCCR
    /// </summary>
    public class ServicioVentaDolarBLL : IServicioVentaDolarBLL
    {

        private IServicioVentaDolarDAL oServicioVentaDolarDAL;

        public ServicioVentaDolarBLL()
        {
            oServicioVentaDolarDAL = ServicioVentaDolarDAL.GetInstance();
        }

        /// <inheritdoc />
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
