using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IEntrenamientoBLL
    {
        void InsertarEntrenamientoDeUsuario(string pId, Entrenamiento pEntrenamiento);
        void EliminarEntrenamientoPorID(int pId);
        void ActualizarEntrenamiento(Entrenamiento pEntrenamiento);
        Entrenamiento ObtenerEntrenamientoPorID(int pId);
        List<Entrenamiento> ObtenerTodosEntrenamientos();
        List<Entrenamiento> ObtenerEntrenamientosIdUsuario(string pId);
        void InsertarDiaEnEntrenamiento(int pId, Dia pDia);
        void EliminarDiaDeEntrenamiento(int pId, Dia pDia);
        List<Dia> ObtenerDiasDeEntrenamientoPorID(int pId);
    }
}
