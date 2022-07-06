using GymPro.Capa.Datos;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Actualiza un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio"></param>
        public void ActualizarTipoEjercicio(TipoEjercicio pTipoEjercicio)
        {
            try
            {
                oTipoEjercicioDAL.ActualizarTipoEjercicio(pTipoEjercicio);
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
        public void EliminarTipoEjercicioPorId(int id)
        {
            try
            {
                oTipoEjercicioDAL.EliminarTipoEjercicioPorId(id);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Inserta un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio"></param>
        public void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio)
        {
            try
            {
                oTipoEjercicioDAL.InsertarTipoEjercicio(pTipoEjercicio);
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
        public TipoEjercicio SeleccionarTipoEjercicioPorId(int id)
        {
            try
            {
                return oTipoEjercicioDAL.SeleccionarTipoEjercicioPorId(id);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna el tipo de ejercicio relacionado al id de ejercicio
        /// </summary>
        /// <returns></returns>
        public TipoEjercicio SeleccionarTipoEjercicioPorIdEjercicio(int pId)
        {
            try
            {
                return oTipoEjercicioDAL.SeleccionarTipoEjercicioPorIdEjercicio(pId);
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
                return oTipoEjercicioDAL.SeleccionarTodosTiposEjercicio();
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
