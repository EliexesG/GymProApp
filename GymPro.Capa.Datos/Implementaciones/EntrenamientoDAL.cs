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
        /// <param name="id"></param>
        public void InsertarEntrenamientoUsuario(Entrenamiento pEntrenamineto, string id)
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
        /// Eliminar un Entrenamiento por Id en la base de datos
        /// </summary>
        /// <param name="id"></param>
        public void EliminarEntrenamientoPorId(int id)
        {

        }

        /// <summary>
        /// Retorna una lista con todos los entrenamientos de un usuario en la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerTodosEntrenamientosUsuario(string id)
        {
            return default;
        }

        /// <summary>
        /// Retorna entrenamiento por id de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entrenamiento ObtenerEntrenamientoPorId(int id)
        {
            return default;
        }

        /// <summary>
        /// Insertar dia de entrenamiento a un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="idEntrenamiento"></param>
        /// <param name="dia"></param>
        public void InsertarDiaEntrenamiento(int idEntrenamiento, Dia dia)
        {
            // Se inserta el registroen la tabla Dias entrenamiento
        }

        /// <summary>
        /// Eliminar dia de entrenamiento de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="idEntrenamiento"></param>
        /// <param name="dia"></param>
        public void EliminarDiaEntrenamiento(int idEntrenamiento, Dia dia)
        {

        }

    }
}
