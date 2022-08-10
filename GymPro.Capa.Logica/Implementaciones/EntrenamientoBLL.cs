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
    public class EntrenamientoBLL : IEntrenamientoBLL
    {
        private IEntrenamientoDAL oEntrenamientoDAL;

        public EntrenamientoBLL()
        {
            oEntrenamientoDAL = EntrenamientoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Elimina un Entrenamiento de la base de datos
        /// </summary>
        /// <param name="pCodigo"> Codigo del entrenamiento a eliminar </param>
        public void EliminarEntrenamiento(int pCodigo)
        {

            try
            {

                oEntrenamientoDAL.EliminarEntrenamiento(pCodigo);

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
        /// Inserta un Entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento">Entrenamiento a insertar</param>
        public void InsertarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            try
            {

                oEntrenamientoDAL.InsertarEntrenamiento(pEntrenamiento);

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
        /// Modifica un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pEntrenamiento">Entrenamiento a modificar</param>
        public void ModificarEntrenamiento(Entrenamiento pEntrenamiento)
        {
            try
            {

                oEntrenamientoDAL.ModificarEntrenamiento(pEntrenamiento);

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
        /// Obtiene un Entrenamiento por su Id de la base de datos
        /// </summary>
        /// <param name="pCodigo">Codigo del entrenamiento a buscar</param>
        /// <returns>Entidad de tipo Entrenamiento</returns>
        public Entrenamiento ObtenerEntrenamientoId(int pCodigo)
        {
            try
            {

                return oEntrenamientoDAL.ObtenerEntrenamientoId(pCodigo);

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
        /// Obtiene una lista de Entrenamientos basado en la Identificacion del Usuario Cliente de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario Cliente </param>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        public List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioCliente(string pIdentificacionUsuario)
        {

            try
            {

                return oEntrenamientoDAL.ObtenerEntrenamientoIdentificacionUsuarioCliente(pIdentificacionUsuario);

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
        /// Obtiene una lista de Entrenamientos basado en la Identificacion del Usuario Entrenador de la base de datos
        /// </summary>
        /// <param name="pIdentificacionUsuario"> Identificacion del Usuario Entrenador </param>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        public List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioEntrenador(string pIdentificacionUsuario)
        {
            try
            {

                return oEntrenamientoDAL.ObtenerEntrenamientoIdentificacionUsuarioEntrenador(pIdentificacionUsuario);

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
        /// Obtiene una lista de todos los Entrenamientos de la base de datos
        /// </summary>
        /// <returns>Lista de entidades de tipo Entrenamiento</returns>
        public List<Entrenamiento> ObtenerEntrenamientoTodos()
        {
            try
            {

                return oEntrenamientoDAL.ObtenerEntrenamientoTodos();

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
        /// Obtiene el ultimo codigo de entrenamiento agregado a la base de datos según el cliente
        /// </summary>
        /// <param name="pIdentificacion"></param>
        /// <returns>Integer con el codigo de entrenamiento</returns>
        public int UltimoCodigoEntrenamientoAgregadoCliente(string pIdentificacion)
        {
            try
            {

                return ObtenerEntrenamientoIdentificacionUsuarioCliente(pIdentificacion).Max(entrenamiento => entrenamiento.Codigo);

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
