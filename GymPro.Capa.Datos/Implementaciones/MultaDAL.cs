using GymPro.Capa.Datos.Interfaces;
using GymPro.Capa.Entidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro.Capa.Datos.Implementaciones
{
    public class MultaDAL : IMultaDAL
    {
        private static MultaDAL Instancia;

        private const string RutaDirectorio = @"C:\Windows\Temp";
        private const string RutaJSON = @"C:\Windows\Temp\Multa.json";
        private const double PorcentajeBaseMulta = 0.17;

        /// <summary>
        /// Retorna una instancia de tipo MultaDAL unica por medio del patrón Singleton
        /// </summary>
        /// <returns></returns>
        public static MultaDAL GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new MultaDAL();
            }

            return Instancia;
        }

        /// <summary>
        /// Obtiene la Multa a utilizar por la Facturacion, en caso de no existir la crea con un porcentaje base, 
        /// esto desde un JSON local
        /// </summary>
        /// <returns>Entidad de tipo Multa</returns>
        public Multa ObtenerMulta()
        {
            try
            {
                if (!Directory.Exists(RutaDirectorio))
                {
                    Directory.CreateDirectory(RutaDirectorio);
                }

                if (!File.Exists(RutaJSON))
                {

                    Multa multaBase = new Multa() { PorcentajeMulta = PorcentajeBaseMulta };

                    string json = Util.JsonGenerics<Multa>.ObjetoAJSON(multaBase);

                    File.WriteAllText(RutaJSON, json);
                }

                string dataTraer = File.ReadAllText(RutaJSON);
                return Util.JsonGenerics<Multa>.JsonAObjeto(dataTraer);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        
        /// <summary>
        /// Modifica el porcentaje de la multa en el JSON local
        /// </summary>
        /// <param name="pMulta">Multa a modificar</param>
        public void ModificarMulta(Multa pMulta)
        {
            try
            {
                if (!Directory.Exists(RutaDirectorio))
                {
                    Directory.CreateDirectory(RutaDirectorio);
                }

                string json = Util.JsonGenerics<Multa>.ObjetoAJSON(pMulta);

                File.WriteAllText(RutaJSON, json);
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
