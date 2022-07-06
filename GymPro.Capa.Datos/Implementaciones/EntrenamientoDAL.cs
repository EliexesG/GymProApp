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
        /// Insertar Entrenamiento en la base de datos perteneciente a un usuario
        /// </summary>
        /// <param name="pEntrenamineto"></param>
        /// <param name="ppId"></param>
        public void InsertarEntrenamientoUsuario(Entrenamiento pEntrenamineto, string ppId)
        {
            // Cuando hacemos instancias y se dejan de usar hay un mecanismo que se llama Garbage Collector que limpia esas referencias que no se estan usando
            // Cunado tenemos estatático esas instancias nunca limpian entonces queda en menoria siempre y puede darse un desperdicio. 

            // Aqui va toda logica para insetart el entrenamiento
        }

        /// <summary>
        /// Actualizar un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento"></param>
        public void ActualizarEntrenamiento(Entrenamiento pEntrenamiento)
        {

        }

        /// <summary>
        /// Eliminar un Entrenamiento por pId en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarEntrenamientoPorId(int pId)
        {

        }

        /// <summary>
        /// Retorna una lista con todos los entrenamientos de un usuario en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerTodosEntrenamientosUsuario(string pId)
        {
            return default;
        }

        /// <summary>
        /// Retorna entrenamiento por pId de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Entrenamiento ObtenerEntrenamientoPorId(int pId)
        {
            return default;
        }

        /// <summary>
        /// Insertar dia de entrenamiento a un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="dia"></param>
        public void InsertarDiaEntrenamiento(int pIdEntrenamiento, Dia dia)
        {
            // Se inserta el registroen la tabla Dias entrenamiento
        }

        /// <summary>
        /// Eliminar dia de entrenamiento de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pIdEntrenamiento"></param>
        /// <param name="dia"></param>
        public void EliminarDiaEntrenamiento(int pIdEntrenamiento, Dia dia)
        {

        }

        /// <summary>
        /// Retorna los dias ligados al entrenamiento por pId desde la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<Dia> ObtenerDiasEntrenamientoPorId(int pId)
        {
            return default;
        }
    }
}
