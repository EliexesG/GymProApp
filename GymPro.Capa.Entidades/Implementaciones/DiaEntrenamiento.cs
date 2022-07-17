using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    public class DiaEntrenamiento
    {
        public int CodigoEntrenamiento { get; set; }
        public int Dia { get; set; }
        public string Nombre { get => Enum.GetName(typeof(Dia), Dia); }
    }
}
