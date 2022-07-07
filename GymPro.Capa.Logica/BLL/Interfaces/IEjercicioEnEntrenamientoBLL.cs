using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IEjercicioEnEntrenamientoBLL
    {
        void ActualizarEjercicioEnEntrenamiento(int idEntrenamiento, EjercicioEnEntrenamiento pEjercicio);
        void EliminarEjercicioEnEntrenamientoID(int idEntrenamiento, int idEjercicio);
        void InsertarEjercicioEnEntrenamiento(int idEntrenamiento, EjercicioEnEntrenamiento pEjercicio);
        List<EjercicioEnEntrenamiento> ObtenerTodosEjerciciosPorEntrenamiento(int idEntrenamiento);
    }
}
