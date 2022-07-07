using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class EntrenamientoDAL : IEntrenamientoDAL
    {

        private static EntrenamientoDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo EntrenamientoDAL
        /// </summary>
        /// <returns></returns>
        public static EntrenamientoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new EntrenamientoDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Inserta un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento"></param>
        public void InsertarEntrenamiento(Entrenamiento pEntrenamiento)
        {

        }

        /// <summary>
        /// Elimina un entrenamiento de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarEntrenamientoPorID(int pId)
        {

        }

        /// <summary>
        /// Actualiza un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento"></param>
        public void ActualizarEntrenamiento(Entrenamiento pEntrenamiento)
        {

        }

        /// <summary>
        /// Retorna todos los entrenamientos de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Entrenamiento> SeleccionarTodosEntrenamientos()
        {
            return default;
        }

        /// <summary>
        /// Retorna un entrenamiento por su Id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Entrenamiento SeleccionarEntrenamientoPorID(int pId)
        {
            return default;
        }

        /// <summary>
        /// Retorna una lista de entrenamientos según la Id del usuario de la base de datos
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public List<Entrenamiento> SeleccionarEntrenamientosPorIDUsuario(string pIdUsuario)
        {
            return default;
        }
    }
}
