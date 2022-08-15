using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using GymPro.Capa.Logica.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Implementaciones
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Servicios de la base de datos
    /// </summary>
    public class ServicioBLL : IServicioBLL
    {
        private IServicioDAL oServicioDAL;

        public ServicioBLL()
        {
            oServicioDAL = ServicioDAL.GetInstance();
        }

        #region Logica
        /// <inheritdoc />
        public double CalcularCostoServicio(Servicio pServicio)
        {
            try
            {
                return (new ServicioVentaDolarBLL().ObtenerPrecioVentaDolar()) * pServicio.Monto;
            }
            catch(Exception er)
            {
                throw er;
            }
        }
        #endregion
        /// <inheritdoc />
        #region Acceso a datos

        public Servicio ObtenerServicioId(int pCodigo)
        {
            try
            {

                return oServicioDAL.ObtenerServicioId(pCodigo);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <inheritdoc />
        public List<Servicio> ObtenerServicioTodos()
        {
            try
            {

                return oServicioDAL.ObtenerServicioTodos().OrderBy(servicio => servicio.Descripcion).ToList();

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
