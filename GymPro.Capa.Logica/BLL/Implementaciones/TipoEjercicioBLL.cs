using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    class TipoEjercicioBLL : ITipoEjercicioBLL
    {

        private ITipoEjercicioDAL oTipoEjercicio;

        public TipoEjercicioBLL()
        {
            oTipoEjercicio = TipoEjercicioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Inserta un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio"></param>
        public void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio)
        {
            try
            {
                oTipoEjercicio.InsertarTipoEjercicio(pTipoEjercicio);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Elimina un Tipo de Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarTipoEjercicioPorID(int pId)
        {
            try
            {
                oTipoEjercicio.EliminarTipoEjercicioPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Actualiza un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio"></param>
        public void ActualizarTipoEjercicio(TipoEjercicio pTipoEjercicio)
        {
            try
            {
                oTipoEjercicio.ActualizarTipoEjercicio(pTipoEjercicio);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna todos los Tipos de Ejercicio en la base de datos
        /// </summary>
        /// <returns></returns>
        public IList<TipoEjercicio> SeleccionarTodosTiposEjercicio()
        {
            try
            {
                return oTipoEjercicio.SeleccionarTodosTiposEjercicio();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna un Tipo de Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public TipoEjercicio SeleccionarTipoEjercicioPorID(int pId)
        {
            try
            {
                return oTipoEjercicio.SeleccionarTipoEjercicioPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
