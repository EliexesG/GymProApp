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
    class EjercicioBLL : IEjercicioBLL
    {

        private IEjercicioDAL oEjercicioDAL;

        public EjercicioBLL()
        {
            oEjercicioDAL = EjercicioDAL.GetInstance();
        }

        /// <summary>
        /// Inserta un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio"></param>
        public void InsertarEjercicio(Ejercicio pEjercicio)
        {

        }

        /// <summary>
        /// Elimina un Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarEjercicioPorId(int pId)
        {

        }

        /// <summary>
        /// Actualiza un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio"></param>
        public void ActualizarEjercicio(Ejercicio pEjercicio)
        {

        }

        /// <summary>
        /// Retorna todos los Ejercicios en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Ejercicio> SeleccionarTodosEjercicios()
        {
            return null;
        }

        /// <summary>
        /// Retorna un Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Ejercicio SeleccionarEjercicioPorId(int pId)
        {
            return default;
        }

    }
}
