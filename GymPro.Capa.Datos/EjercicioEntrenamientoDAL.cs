using GymPro.Capa.Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos
{
    class EjercicioEntrenamientoDAL
    {
        public void InsertarEjercicio(int idEntrenamiento, EjercicioEnEntrenamiento pEjercicio)
        {
            // Se inserta el registroen la tabla intermida
        }

        public IEnumerable<EjercicioEnEntrenamiento> ObtenerEjercicioPorEntrenamiento(int idEntrenamiento) => default;

        public void ModificarEjercicioEnEntrenamiento(int idEntrenamiento, EjercicioEnEntrenamiento pEjercicio)
        {

        }

    }
}
