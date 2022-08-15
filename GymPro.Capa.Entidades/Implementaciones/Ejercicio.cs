using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    /// <summary>
    /// Entidad que representa un Ejercicio
    /// </summary>
    public class Ejercicio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CodigoTipo { get; set; }
        public byte[] Multimedia { get; set; }

        public TipoEjercicio _TipoEjercicio { get; set; }
    }
}
