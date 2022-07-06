using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
{
    public class TipoEjercicioDAL : ITipoEjercicioDAL
    {

        private static TipoEjercicioDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo TipoEjercicioDAL
        /// </summary>
        /// <returns></returns>
        public static TipoEjercicioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new TipoEjercicioDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Inserta un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio"></param>
        public void InsertarTipoEjercicio(TipoEjercicio pTipoEjercicio)
        {

        }

        /// <summary>
        /// Actualiza un Tipo de Ejercicio en la base de datos
        /// </summary>
        /// <param name="pTipoEjercicio"></param>
        public void ActualizarTipoEjercicio(TipoEjercicio pTipoEjercicio)
        {

        }

        /// <summary>
        /// Retorna todos los Tipos de Ejercicio en la base de datos
        /// </summary>
        /// <returns></returns>
        public IList<TipoEjercicio> SeleccionarTodosTiposEjercicio()
        {
            return null;
            // Seleccione todos los que tengan el campo estado en true
        }

        /// <summary>
        /// Retorna un Tipo de Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Ejercicio SeleccionarTipoEjercicioPorId(int pId)
        {
            return default;
        }

        /// <summary>
        /// Elimina un Tipo de Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarTipoEjercicioPorId(int pId)
        {
            // No va a hacer un delete sino que va a hacer un UPDATE al campo Activo
        }
    }
}
