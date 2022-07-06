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
        void ActualizarEntrenamiento(Entrenamiento pEntrenamiento);
        void EliminarDiaEntrenamiento(int idEntrenamiento, Dia dia);
        void EliminarEntrenamientoPorId(int id);
        void InsertarDiaEntrenamiento(int idEntrenamiento, Dia dia);
        void InsertarEntrenamientoUsuario(Entrenamiento pEntrenamineto, string id);
        Entrenamiento ObtenerEntrenamientoPorId(int id);
        List<Entrenamiento> ObtenerTodosEntrenamientosUsuario(string id);
        List<Dia> ObtenerDiasEntrenamientoPorId(int pId);
        List<Entrenamiento> ObtenerEntrenamientosPorIdUsuario(string pId);
    }
}
