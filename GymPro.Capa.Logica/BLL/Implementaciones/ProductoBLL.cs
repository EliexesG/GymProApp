using GymPro.Capa.Datos.Implementaciones;
using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Logica.BLL.Implementaciones
{
    public class ProductoBLL : IProductoBLL
    {

        private IProductoDAL oProductoDAL;

        public ProductoBLL()
        {
            oProductoDAL = ProductoDAL.GetInstance();
        }

        #region Acceso a datos
        /// <summary>
        /// Retorna una lista con todos los productos que ofrece el gimnacio de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Servicio> SeleccionarTodosProductos()
        {
            try
            {
                return oProductoDAL.SeleccionarTodosProductos();
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        /// <summary>
        /// Selecciona un producto por su id de la base de datos
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Servicio SeleccionarProductoPorID(int pId)
        {
            try
            {
                return oProductoDAL.SeleccionarProductoPorID(pId);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion
    }
}
