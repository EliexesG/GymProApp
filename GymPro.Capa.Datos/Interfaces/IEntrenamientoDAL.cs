using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IEntrenamientoDAL
    {
        void InsertarEntrenamiento(Entrenamiento pEntrenamiento);
        void ModificarEntrenamiento(Entrenamiento pEntrenamiento);
        void EliminarEntrenamiento(int pCodigo);
        List<Entrenamiento> ObtenerEntrenamientoTodos();
        Entrenamiento ObtenerEntrenamientoId(int pCodigo);
        List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioCliente(string pIdentificacionUsuario);
        List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioEntrenador(string pIdentificacionUsuario);
    }
}
