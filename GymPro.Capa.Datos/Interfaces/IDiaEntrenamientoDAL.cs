using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IDiaEntrenamientoDAL
    {
        void InsertarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento);
        void EliminarDiaEntrenamiento(DiaEntrenamiento pDiaEntrenamiento);
        List<DiaEntrenamiento> ObtenerDiaEntrenamientoTodos();
        List<DiaEntrenamiento> ObtenerDiaEntrenamientoCodigoEntrenamiento(int pCodigoEntrenamiento);
    }
}
