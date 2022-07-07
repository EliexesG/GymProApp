﻿using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class UsuarioDAL : IUsuarioDAL
    {

        private static UsuarioDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo UsuarioDAL
        /// </summary>
        /// <returns></returns>
        public static UsuarioDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new UsuarioDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Insertar usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"></param>
        public void InsertarUsuario(IUsuario pUsuario)
        {

        }

        /// <summary>
        /// Eliminar usuario segun su Id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        public void EliminarUsuarioPorID(string pId)
        {

        }

        /// <summary>
        /// Actualizar un usuario en la base de datos
        /// </summary>
        /// <param name="pUsuario"></param>
        public void ActualizarUsuario(IUsuario pUsuario)
        {

        }

        /// <summary>
        /// Retorna una lista con todos los usuarios de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<IUsuario> SeleccionarTodosUsuarios()
        {
            return default;
        }

        /// <summary>
        /// Retorna un usuario segun su Id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public IUsuario SeleccionarUsuarioPorID(string pId)
        {
            return default;
        }
    }
}
