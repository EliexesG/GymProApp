using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    public class ExpedienteUsuario
    {
        #region Propiedades de Expediente de Cliente
        public string IdentificacionUsuario { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float IMC { get; set; }
        public float MetabolismoBasal { get; set; }
        #endregion
    }
}
