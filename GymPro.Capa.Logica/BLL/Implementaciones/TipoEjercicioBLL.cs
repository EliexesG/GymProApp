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
    public class TipoEjercicioBLL : ITipoEjercicioBLL
    {
        private ITipoEjercicioDAL oTipoEjercicioDAL;

        public TipoEjercicioBLL()
        {
            oTipoEjercicioDAL = TipoEjercicioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Elimina un Tipo de Ejercicio de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Tipo de Ejercicio a eliminar</param>
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

        /// <summary>
        /// Inserta un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio">Tipo de Ejercicio a insertar</param>
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

        /// <summary>
        /// Modifica un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio">Tipo de Ejercicio a modificar</param>
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

        /// <summary>
        /// Obtiene un Tipo de Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Tipo de Ejercicio a buscar</param>
        /// <returns>Entidad de TipoEjercicio</returns>
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

        /// <summary>
        /// Obtiene una lista de todos los Tipos de Ejercicio de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de TipoEjercicio</returns>
        public List<TipoEjercicio> ObtenerTipoEjercicioTodos()
        {
            try
            {

                return oTipoEjercicioDAL.ObtenerTipoEjercicioTodos();

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
