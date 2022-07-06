using GymPro.Capa.Entidades.Interfaces;
using System.Collections.Generic;

namespace GymPro.Capa.Datos
{
    public interface IUsuarioDAL
    {
        void ActualizarUsuario(IUsuario usuario);
        void EliminarUsuarioPorId(string id);
        void InsertarUsuario(IUsuario usuario);
        List<IUsuario> SeleccionarTodosUsuarios();
        IUsuario SeleccionarUsuarioPorId(string id);
    }
}