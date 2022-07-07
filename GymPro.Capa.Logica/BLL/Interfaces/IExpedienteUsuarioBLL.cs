using GymPro.Capa.Entidades.Implementaciones;
using System.Collections.Generic;

namespace GymPro.Capa.Logica.BLL.Interfaces
{
    interface IExpedienteUsuarioBLL
    {
        void ActualizarExpedienteUsuario(ExpedienteUsuario pExpediente);
        void EliminarExpedienteUsuarioPorID(string pIdUsuario);
        void InsertarExpedienteUsuario(ExpedienteUsuario pExpediente);
        ExpedienteUsuario SeleccionarExpedienteUsuarioPorID(string pIdUsuario);
        List<ExpedienteUsuario> SeleccionarTodosExpedientesUsuarios();
    }
}