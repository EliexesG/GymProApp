using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.Implementaciones
{
    /// <summary>
    /// Clase de logica y acceso a datos para los Tipos de Ejercicios de la base de datos
    /// </summary>
    public class TipoEjercicioBLL : ITipoEjercicioBLL
    {
        private ITipoEjercicioDAL oTipoEjercicioDAL;

        public TipoEjercicioBLL()
        {
            oTipoEjercicioDAL = TipoEjercicioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <inheritdoc />
        public void EliminarTipoEjercicio(int pCodigo)
        {
            try
            {

                oTipoEjercicioDAL.EliminarTipoEjercicio(pCodigo);

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
        public void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio)
        {
            try
            {

                oTipoEjercicioDAL.InsertarTipoEjercicio(pTipoEjercicio);

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
        public void ModificarTipoEjercicio(TipoEjercicio pTipoEjercicio)
        {
            try
            {

                oTipoEjercicioDAL.ModificarTipoEjercicio(pTipoEjercicio);

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
        public TipoEjercicio ObtenerTipoEjercicioId(int pCodigo)
        {

            try
            {

                return oTipoEjercicioDAL.ObtenerTipoEjercicioId(pCodigo);

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
        public List<TipoEjercicio> ObtenerTipoEjercicioTodos()
        {
            try
            {

                return oTipoEjercicioDAL.ObtenerTipoEjercicioTodos().OrderBy(tipo => tipo.Nombre).ToList();

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
