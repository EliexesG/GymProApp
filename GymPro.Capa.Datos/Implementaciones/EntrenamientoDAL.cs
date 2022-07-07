using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
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
        /// Actualizar el entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento"></param>
        public void ActualizarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Eliminar un dia del entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pDia"></param>
        public void EliminarDiaDeEntrenamiento(int pId, Dia pDia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Eliminar un entrenamiento por id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarEntrenamientoPorID(int pId)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Insertar un dia en el entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pDia"></param>
        public void InsertarDiaEnEntrenamiento(int pId, Dia pDia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insertar un entrenamiento perteneciente a un usuario en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pEntrenamiento"></param>
        public void InsertarEntrenamientoDeUsuario(string pId, Entrenamiento pEntrenamiento)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtener los dias de entrenamiento de un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Dia> ObtenerDiasDeEntrenamientoPorID(int pId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtener un entrenamiento por su id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Entrenamiento ObtenerEntrenamientoPorID(int pId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtener todos los entrenamientos pertenecientes a un usuario de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerEntrenamientosIdUsuario(string pId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtener todos los entrenamientos existentes
        /// </summary>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerTodosEntrenamientos()
        {
            throw new NotImplementedException();
        }
    }
}
