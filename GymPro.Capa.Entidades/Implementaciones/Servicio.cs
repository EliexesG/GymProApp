using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    /// <summary>
    /// Entidad que representa un Servicio
    /// </summary>
    public class Servicio
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
    }
}
