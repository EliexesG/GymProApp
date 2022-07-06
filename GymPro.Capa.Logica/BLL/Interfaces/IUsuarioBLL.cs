using GymPro.Capa.Entidades.Interfaces;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL
{
    public interface IUsuarioBLL
    {
        void InsertarUsuario(IUsuario pUsuario);
        void ActualizarUsuario(IUsuario pUsuario);
        List<IUsuario> SeleccionarTodosUsuarios();
        IUsuario SeleccionarUsuarioPorId(string pId);
        void EliminarUsuarioPorId(string pId);

    }
}