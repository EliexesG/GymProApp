using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IServicioDAL
    {
        List<Servicio> ObtenerServicioTodos();
        Servicio ObtenerServicioId(int pCodigo);
    }
}
