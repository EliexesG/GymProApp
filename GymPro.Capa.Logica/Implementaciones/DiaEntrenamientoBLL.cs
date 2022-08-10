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
    public class DiaEntrenamientoBLL : IDiaEntrenamientoBLL
    {
        private IDiaEntrenamientoDAL oDiaEntrenamientoDAL;

        public DiaEntrenamientoBLL()
        {
            oDiaEntrenamientoDAL = DiaEntrenamientoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Elimina un Dia de un Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pDiaEntrenamiento"> Dia de Entrenamiento a eliminar </param>
        public void EliminarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento)
        {
            try
            {

                oDiaEntrenamientoDAL.EliminarDiaEntrenamiento(pDiaEntrenamiento);

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
        /// Inserta un Dia de un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pDiaEntrenamiento"> Dia de Entrenamiento a insertar </param>
        public void InsertarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento)
        {
            try
            {

                oDiaEntrenamientoDAL.InsertarDiaEntrenamiento(pDiaEntrenamiento);

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
        /// Obtiene una lista de Dias de Entrenamiento de la base de datos relacionados al Codigo de Entrenamiento
        /// </summary>
        /// <param name="pCodigoEntrenamiento"> Codigo de Entrenamiento relacionado a los Dias de Entrenamiento a buscar </param>
        /// <returns>Lista de entidades de tipo DiaEntrenamiento</returns>
        public List<DiaEntrenamiento> ObtenerDiaEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento)
        {
            try
            {

                return oDiaEntrenamientoDAL.ObtenerDiaEntrenamientoCodigoEntrenamiento(pCodigoEntrenamiento).OrderBy(dia => dia.Dia).ToList();

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
        /// Obtiene una lista de todos los Dias de Entrenamiento de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo DiaEntrenamiento</returns>
        public List<DiaEntrenamiento> ObtenerDiaEntrenamientoTodos()
        {

            try
            {

                return oDiaEntrenamientoDAL.ObtenerDiaEntrenamientoTodos().OrderBy(dia => dia.Dia).ToList();

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
        /// Obtiene los días disponibles que no estén asignados al entrenamiento de la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Lista de Dias</returns>
        public List<Dia> ObtenerDiaDisponibleSobreCodigoEntrenamiento(int pCodigoEntrenamiento)
        {
            try
            {
                List<DiaEntrenamiento> diasEntrenamiento = this.ObtenerDiaEntrenamientoCodigoEntrenamiento(pCodigoEntrenamiento);
                List<Dia> dias = new List<Dia>();

                foreach (Dia dia in Enum.GetValues(typeof(Dia)))
                {
                    if(diasEntrenamiento.FirstOrDefault(diaEntrenamiento => diaEntrenamiento.Dia == (int)dia) == null)
                    {
                        dias.Add(dia);
                    }
                }

                return dias;

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
