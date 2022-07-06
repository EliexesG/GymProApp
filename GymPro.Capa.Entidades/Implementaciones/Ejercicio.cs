using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    public class Ejercicio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoEjercicio _TipoEjercicio { get; set; }
        public byte[] Imagen { get; set; }
        public byte[] Video { get; set; }
    }
}
