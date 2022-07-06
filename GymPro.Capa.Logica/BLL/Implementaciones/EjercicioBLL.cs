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
    class EjercicioBLL : IEjercicioBLL
    {
        private EjercicioDAL oEjercicioDAL;

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
            try
            {
                oEjercicioDAL.InsertarEjercicio(pEjercicio);
            }
            catch(Exception er)
            {
                throw er;
            }
        } 

        /// <summary>
        /// Actualiza un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio"></param>
        public void ActualizarEjercicio(Ejercicio pEjercicio)
        {
            try
            {
                oEjercicioDAL.ActualizarEjercicio(pEjercicio);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna todos los Ejercicios en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Ejercicio> SeleccionarTodosEjercicios()
        {
            try
            {
                return oEjercicioDAL.SeleccionarTodosEjercicios();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Retorna un Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Ejercicio SeleccionarEjercicioPorId(int pId)
        {
            try
            {
                return SeleccionarEjercicioPorId(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Elimina un Ejercicio de la base por id
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarEjercicioPorId(int pId)
        {
            try
            {
                oEjercicioDAL.EliminarEjercicioPorId(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

    }
}
