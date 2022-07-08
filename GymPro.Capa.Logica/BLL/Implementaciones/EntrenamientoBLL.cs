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
    class EntrenamientoBLL : IEntrenamientoBLL
    {
        private IEntrenamientoDAL oEntrenamientoDAL;

        public EntrenamientoBLL()
        {
            oEntrenamientoDAL = EntrenamientoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Inserta un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento"></param>
        public void InsertarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            try
            {
                oEntrenamientoDAL.InsertarEntrenamiento(pEntrenamiento);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Elimina un entrenamiento de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarEntrenamientoPorID(int pId)
        {
            try
            {
                oEntrenamientoDAL.EliminarEntrenamientoPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Actualiza un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento"></param>
        public void ActualizarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            try
            {
                oEntrenamientoDAL.ActualizarEntrenamiento(pEntrenamiento);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna todos los entrenamientos de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Entrenamiento> SeleccionarTodosEntrenamientos()
        {
            try
            {
                return oEntrenamientoDAL.SeleccionarTodosEntrenamientos();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna un entrenamiento por su Id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Entrenamiento SeleccionarEntrenamientoPorID(int pId)
        {
            try
            {
                return oEntrenamientoDAL.SeleccionarEntrenamientoPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna una lista de entrenamientos según la Id del usuario de la base de datos
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public List<Entrenamiento> SeleccionarEntrenamientosPorIDUsuario(string pIdUsuario)
        {
            try
            {
                return oEntrenamientoDAL.SeleccionarEntrenamientosPorIDUsuario(pIdUsuario);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
