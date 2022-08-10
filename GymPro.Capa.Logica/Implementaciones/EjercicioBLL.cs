using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class EjercicioBLL : IEjercicioBLL
    {
        private IEjercicioDAL oEjercicioDAL;

        public EjercicioBLL()
        {
            oEjercicioDAL = EjercicioDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Elimina un Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Ejercicio a eliminar</param>
        public void EliminarEjercicio(int pCodigo)
        {
            try
            {

                oEjercicioDAL.EliminarEjercicio(pCodigo);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Inserta un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio">Ejercicio a insertar</param>
        public void InsertarEjercicio(Ejercicio pEjercicio)
        {
            try
            {

                oEjercicioDAL.InsertarEjercicio(pEjercicio);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Modifica un Ejercicio en la base de datos
        /// </summary>
        /// <param name="pEjercicio">Ejercicio a modificar</param>
        public void ModificarEjercicio(Ejercicio pEjercicio)
        {
            try
            {

                oEjercicioDAL.ModificarEjercicio(pEjercicio);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtiene una lista de Ejercicios por Codigo del Tipo de Ejercicio de la base de datos
        /// </summary>
        /// <param name="pCodigoTipo">Codigo del Tipo de Ejercicio de los Ejercicios a buscar</param>
        /// <returns>Lista de Entidades de tipo Ejercicio</returns>
        public List<Ejercicio> ObtenerEjercicioCodigoTipo(int pCodigoTipo)
        {
            try
            {

                return oEjercicioDAL.ObtenerEjercicioCodigoTipo(pCodigoTipo).OrderBy(ejercicio => ejercicio.CodigoTipo).ThenBy(ejercicio => ejercicio.Nombre).ToList(); ;

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtiene un Ejercicio por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del Ejercicio a buscar</param>
        /// <returns>Entidad de tipo Ejercicio</returns>
        public Ejercicio ObtenerEjercicioId(int pCodigo)
        {
            try
            {

                return oEjercicioDAL.ObtenerEjercicioId(pCodigo);

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtiene una lista de todos los Ejercicios en la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Ejercicio</returns>
        public List<Ejercicio> ObtenerEjercicioTodos()
        {
            try
            {

                return oEjercicioDAL.ObtenerEjercicioTodos().OrderBy(ejercicio => ejercicio.CodigoTipo).ThenBy(ejercicio => ejercicio.Nombre).ToList();

            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Obtener una lista de Ejercicios que NO estan en el entrenamiento referenciado por codigo de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del entrenamiento</param>
        /// <returns>Lista de entidades de tipo Ejercicio</returns>
        public List<Ejercicio> ObtenerEjercicioDisponibleCodigoEntrenamiento(int pCodigo)
        {

            List<Ejercicio> ejercicios = new List<Ejercicio>();

            try
            {
                EjercicioEnEntrenamientoBLL logica = new EjercicioEnEntrenamientoBLL();
                List<EjercicioEnEntrenamiento> ejerciciosDeLEntrenamiento = logica.ObtenerEjercicioEnEntrenamientoCodigoEntrenamiento(pCodigo);

                ObtenerEjercicioTodos().ForEach(ejercicio =>
                {
                    if(ejerciciosDeLEntrenamiento.LastOrDefault(buscado => buscado.CodigoEjercicio.Equals(ejercicio.Codigo)) == null)
                    {
                        ejercicios.Add(ejercicio);
                    }
                });


                return ejercicios;
            }
            catch (SqlException sqlError)
            {
                throw sqlError;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
