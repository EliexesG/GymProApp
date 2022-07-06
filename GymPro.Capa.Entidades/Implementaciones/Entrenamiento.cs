using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    public class Entrenamiento
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
       // public List<EjercicioEnEntrenamiento> Ejercicios { get; }

        public Entrenamiento()
        {
            //Ejercicios = new List<EjercicioEnEntrenamiento>();
        }

        //public void AsignarEjercicio(Ejercicio ejercicio, int repeticiones, int[] series, int tiempo)
        //{
        //    try
        //    {
        //        EjercicioEnEntrenamiento nuevo = new EjercicioEnEntrenamiento()
        //        {
        //            _Ejercicio = ejercicio,
        //            Repeticiones = repeticiones,
        //            Series = series,
        //            Tiempo = tiempo
        //        };

        //        Ejercicios.Add(nuevo);
        //    }
        //    catch (NullReferenceException)
        //    {
        //        throw new NullReferenceException("No se ha inicializado la Lista de Ejercicios");
        //    }
        //}
    }
}
