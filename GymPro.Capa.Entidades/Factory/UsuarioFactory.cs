﻿using GymPro.Capa.Entidades.Clases;
using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Entidades.Factory
{
    class UsuarioFactory
    {
        public static IUsuario CrearUsuario(TipoUsuario tipoUsuario)
        {
            IUsuario usuario = null;

            switch (tipoUsuario)
            {
                case TipoUsuario.Cliente:
                    usuario = new Cliente();
                    break;
                case TipoUsuario.Instructor:
                    usuario = new Instructor();
                    break;
                case TipoUsuario.Administrador:
                    usuario = new Administrador();
                    break;
                default:
                    break;
            }

            return usuario;
        }
    }
}
