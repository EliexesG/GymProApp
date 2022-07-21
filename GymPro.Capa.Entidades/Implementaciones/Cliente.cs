using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Implementaciones
{
    public class Cliente : IUsuario
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public byte[] Fotografia { get; set; }
        public int CodigoTipoUsuario { get; set; }
        public string Contrasenna { get; set; }

        public TipoUsuario _TipoUsuario { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public Genero Genero { get; set; }

        public List<Entrenamiento> Entrenamientos { get; set; }
        public List<ExpedienteUsuario> HistorialExpedientesUsuario { get; set; }
        public List<FacturaEncabezado> HistorialFacturasEncabezado { get; set; }
    }
}
