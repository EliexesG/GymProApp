using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class ServicioBLL : IServicioBLL
    {
        private IServicioDAL oServicioDAL;

        public ServicioBLL()
        {
            oServicioDAL = ServicioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Obtiene un Servicio de la base de datos por su Id
        /// </summary>
        /// <param name="pCodigo"> Codigo del servicio a buscar </param>
        /// <returns>Entidad de tipo Servicio</returns>
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

        /// <summary>
        /// Obtiene una lista de todos los servicios de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Servicio</returns>
        public List<Servicio> ObtenerServicioTodos()
        {
            try
            {

                return oServicioDAL.ObtenerServicioTodos();

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
