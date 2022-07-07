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
    public class EntrenamientoBLL : IEntrenamientoBLL
    {

        private IEntrenamientoDAL oEntrenamientoDAL;

        public EntrenamientoBLL()
        {
            oEntrenamientoDAL = EntrenamientoDAL.GetInstance();
        }

        /// <summary>
        /// Actualizar el entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento"></param>
        public void ActualizarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            try
            {
                oEntrenamientoDAL.ActualizarEntrenamiento(pEntrenamiento);
            }
            catch(Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Eliminar un dia del entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pDia"></param>
        public void EliminarDiaDeEntrenamiento(int pId, Dia pDia)
        {
            try
            {
                oEntrenamientoDAL.EliminarDiaDeEntrenamiento(pId, pDia);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Eliminar un entrenamiento por id de la base de datos
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
        /// Insertar un dia en el entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pDia"></param>
        public void InsertarDiaEnEntrenamiento(int pId, Dia pDia)
        {
            try
            {
                oEntrenamientoDAL.InsertarDiaEnEntrenamiento(pId, pDia);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Insertar un entrenamiento perteneciente a un usuario en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pEntrenamiento"></param>
        public void InsertarEntrenamientoDeUsuario(string pId, Entrenamiento pEntrenamiento)
        {
            try
            {
                oEntrenamientoDAL.InsertarEntrenamientoDeUsuario(pId, pEntrenamiento);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtener los dias de entrenamiento de un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Dia> ObtenerDiasDeEntrenamientoPorID(int pId)
        {
            try
            {
                return oEntrenamientoDAL.ObtenerDiasDeEntrenamientoPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtener un entrenamiento por su id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Entrenamiento ObtenerEntrenamientoPorID(int pId)
        {
            try
            {
                return oEntrenamientoDAL.ObtenerEntrenamientoPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtener todos los entrenamientos pertenecientes a un usuario de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerEntrenamientosIdUsuario(string pId)
        {
            try
            {
                return oEntrenamientoDAL.ObtenerEntrenamientosIdUsuario(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtener todos los entrenamientos existentes
        /// </summary>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerTodosEntrenamientos()
        {
            try
            {
                return oEntrenamientoDAL.ObtenerTodosEntrenamientos();
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
