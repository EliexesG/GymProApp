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
        /// Insertar Entrenamiento en la base de datos perteneciente a un usuario
        /// </summary>
        /// <param name="pEntrenamineto"></param>
        /// <param name="ppId"></param>
        public void InsertarEntrenamientoUsuario(Entrenamiento pEntrenamineto, string ppId)
        {
            try
            {
                oEntrenamientoDAL.InsertarEntrenamientoUsuario(pEntrenamineto, ppId);
            }
            catch(Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Actualizar un Entrenamiento en la base de datos
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
        /// Eliminar un Entrenamiento por pId en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarEntrenamientoPorId(int pId)
        {
            try
            {
                oEntrenamientoDAL.EliminarEntrenamientoPorId(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna una lista con todos los entrenamientos de un usuario en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerTodosEntrenamientosUsuario(string pId)
        {
            try
            {
                return oEntrenamientoDAL.ObtenerTodosEntrenamientosUsuario(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna entrenamiento por pId de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Entrenamiento ObtenerEntrenamientoPorId(int pId)
        {
            try
            {
                return oEntrenamientoDAL.ObtenerEntrenamientoPorId(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Insertar dia de entrenamiento a un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="dia"></param>
        public void InsertarDiaEntrenamiento(int pIdEntrenamiento, Dia dia)
        {
            try
            {
                oEntrenamientoDAL.InsertarDiaEntrenamiento(pIdEntrenamiento, dia);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Eliminar dia de entrenamiento de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="dia"></param>
        public void EliminarDiaEntrenamiento(int pIdEntrenamiento, Dia dia)
        {
            try
            {
                oEntrenamientoDAL.EliminarDiaEntrenamiento(pIdEntrenamiento, dia);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna los dias ligados al entrenamiento por pId desde la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Dia> ObtenerDiasEntrenamientoPorId(int pId)
        {
            try
            {
                return oEntrenamientoDAL.ObtenerDiasEntrenamientoPorId(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna todos los entrenamientos relacionados a un usuario
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerEntrenamientosPorIdUsuario(string pId)
        {
            throw new NotImplementedException();
        }
    }
}
