using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    /// <summary>
    /// Entidad que representa una Tarjeta de Pago
    /// </summary>
    public class Tarjeta
    {
        public String Numero { get; set; }
        public string CodigoSeguridad { get; set; }
        public int MesExpiracion { get; set; }
        public int AnnoExpiracion { get; set; }
        public TipoTarjeta _TipoTarjeta { get; set; }
    }
}
