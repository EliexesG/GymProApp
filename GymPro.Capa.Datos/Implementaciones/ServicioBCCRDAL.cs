using GymPro.Capa.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class ServicioBCCRDAL : IServicioBCCRDAL
    {
        private static ServicioBCCRDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo SesrvicioBCCRDAL
        /// </summary>
        /// <returns></returns>
        public static ServicioBCCRDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ServicioBCCRDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Obtiene el precio de venta del dolar actualmente del BAC
        /// </summary>
        /// <returns></returns>
        public float ObtenerPrecioVentaDolar()
        {
            return default;
        }
    }
}
