using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class ProductoDAL : IProductoDAL
    {
        private static ProductoDAL Instancia;

        /// <summary>
        /// Retorna instancia de tipo ProductoDAL
        /// </summary>
        /// <returns></returns>
        public static ProductoDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new ProductoDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Retorna una lista con todos los productos que ofrece el gimnacio de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Producto> SeleccionarTodosProductos()
        {
            return default;
        }

        /// <summary>
        /// Selecciona un producto por su id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Producto SeleccionarProductoPorID(int pId)
        {
            return default;
        }

    }
}
