using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    public interface IEntrenamientoBLL
    {
        void EliminarEntrenamiento(int pCodigo);
        void InsertarEntrenamiento(Entrenamiento pEntrenamiento);
        void ModificarEntrenamiento(Entrenamiento pEntrenamiento);
        Entrenamiento ObtenerEntrenamientoId(int pCodigo);
        List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioCliente(string pIdentificacionUsuario);
        List<Entrenamiento> ObtenerEntrenamientoIdentificacionUsuarioEntrenador(string pIdentificacionUsuario);
        List<Entrenamiento> ObtenerEntrenamientoTodos();
        int UltimoCodigoEntrenamientoAgregadoCliente(string pIdentificacion);
    }
}