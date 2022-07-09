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
        public string Apellidos { get; set; }
        public byte[] Fotografia { get; set; }
        public string Contrasenna { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public Genero Genero { get; set; }
    }
}
