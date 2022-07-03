using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Interfaces
{
    interface IUsuario
    {
        string Identificacion { get; set; }
        string Nombre { get; set; }
        string Apellidos { get; set; }
        byte[] Fotografia { get; set; }
        string Contrasenna { get; set; }
    }
}
