using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Interfaces
{
    interface IExpedienteUsuario
    {
        float Peso { get; set; }
        float Altura { get; set; }
        float IMC { get; set; }
        float MetabolismoBasal { get; set; }

    }
}
