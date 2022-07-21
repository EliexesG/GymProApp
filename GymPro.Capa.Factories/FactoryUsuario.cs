using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Factories
{
    public class FactoryUsuario
    {
        public static IUsuario CrearUsuario(TipoUsuarioEnum tipoUsuario)
        {
            IUsuario usuario = null;

            switch (tipoUsuario)
            {
                case TipoUsuarioEnum.Cliente:
                    usuario = new Cliente();
                    break;
                case TipoUsuarioEnum.Instructor:
                    usuario = new Instructor();
                    break;
                case TipoUsuarioEnum.Administrador:
                    usuario = new Administrador();
                    break;
                default:
                    break;
            }

            return usuario;
        }
    }
}
