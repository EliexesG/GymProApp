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
    class DiaEntrenamientoBLL : IDiaEntrenamientoBLL
    {

        private IDiaEntrenamientoDAL oDiaEntrenamientoDAL;

        public DiaEntrenamientoBLL()
        {
            oDiaEntrenamientoDAL = DiaEntrenamientoDAL.GetInstance();
        }

        /// <summary>
        /// Insertar un dia de entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pDia"></param>
        public void InsertarDiaEnEntrenamiento(DiaEntrenamiento pDia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Eliminar un dia del entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pDia"></param>
        public void EliminarDiaDeEntrenamiento(DiaEntrenamiento pDia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retorna una lista con todos los dias de entrenamiento existentes en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<DiaEntrenamiento> SeleccionarTodosDiasDeEntrenamiento()
        {
            return default;
        }

        /// <summary>
        /// Obtener los dias de entrenamiento de un entrenamiento en la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public List<DiaEntrenamiento> SeleccionarDiasDeEntrenamientoPorID(int pId)
        {
            throw new NotImplementedException();
        }
    }
}
