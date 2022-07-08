﻿using GymPro.Capa.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class ServicioBACDAL : IServicioBACDAL
    {
        private static ServicioBACDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo SesrvicioBACDAL
        /// </summary>
        /// <returns></returns>
        public static ServicioBACDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ServicioBACDAL();
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
