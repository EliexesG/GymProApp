using GymPro.Capa.Logica.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GymPro.UnitTesting
{
    [TestClass]
    public class UnitTesting_FacturaDetalle
    {

        IFacturaDetalleBLL Logica = new FacturaDetalleBLL();

        [TestMethod]
        public void TestCalcularMontoServicios1()
        {
            try
            {
                double calculo = Logica.CalcularMontoServicios(new ServicioBLL().ObtenerServicioTodos());

                Assert.AreEqual(38458, calculo);
            }
            catch { }
        }
    }
}
