using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Datos.Interfaces
{
    public interface IExpedienteUsuarioDAL
    {
        void InsertarExpedienteUsuario(ExpedienteUsuario pExpediente);
        void ActualizarExpedienteUsuario(ExpedienteUsuario pExpediente);
        void EliminarExpedienteUsuarioPorID(string pIdUsuario);
        ExpedienteUsuario SeleccionarExpedienteUsuarioPorID(string pIdUsuario);
        List<ExpedienteUsuario> SeleccionarTodosExpedientesUsuarios();
    }
}