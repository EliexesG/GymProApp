using GymPro.Capa.Entidades.Interfaces;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IUsuarioDAL
    {
        void ActualizarUsuario(IUsuario pUsuario);
        void EliminarUsuarioPorID(string pId);
        void InsertarUsuario(IUsuario pUsuario);
        List<IUsuario> SeleccionarTodosUsuarios();
        IUsuario SeleccionarUsuarioPorID(string pId);
    }
}