using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.BLL.Implementaciones;
using GymPro.Capa.Logica.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IExpedienteUsuarioBLL expediente = new ExpedienteUsuarioBLL();

            //expediente.EliminarExpedienteUsuario(DateTime.Parse("6/7/2022"), "117900330");

            //ExpedienteUsuario ex = expediente.ObtenerExpedienteUsuarioId(DateTime.Parse("6/7/2022"), "117900330");

            //Console.WriteLine($"{ex.Fecha}, {ex.IdentificacionUsuario}, {ex.Peso}, \n");

            //foreach (ExpedienteUsuario expediente1 in expediente.ObtenerExpedienteUsuarioTodos())
            //{
            //    Console.WriteLine($"{expediente1.Fecha}, {expediente1.IdentificacionUsuario}, {expediente1.Peso}, \n");
            //}

            //for (int i = 0; i < 7; i++)
            //{
            //    ExpedienteUsuario expediente1 = new ExpedienteUsuario()
            //    {
            //        Fecha = DateTime.Parse($"6-{i + 1}-2022"),
            //        IdentificacionUsuario = "117900329",
            //        Altura = new Random().Next(150, 200),
            //        Peso = new Random().Next(30, 180),
            //        IMC = new Random().Next(10, 100),
            //        MetabolismoBasal = new Random().Next(10, 100),
            //    };

            //    expediente.InsertarExpedienteUsuario(expediente1);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
