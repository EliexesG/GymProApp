using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    public class EjercicioEnEntrenamiento
    {
        public int CodigoEntrenamiento { get; set; }
        public int CodigoEjercicio { get; set; }
        public int Repeticiones { get; set; }
        public string Series { get; set; }
        public int Tiempo { get; set; }
    }
}
