using GymPro.Capa.Datos;
using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL
{
    public class UsuarioBLL
    {
        public void InsertarUsuario(IUsuario pUsuario)
        {
            UsuarioDAL oUsuarioDAL = new UsuarioDAL();
            oUsuarioDAL.InsertarUsuario(pUsuario);
        }
    }
}
