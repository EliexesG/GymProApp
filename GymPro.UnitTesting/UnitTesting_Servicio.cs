using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GymPro.UnitTesting
{
    [TestClass]
    public class UnitTesting_Servicio
    {

        IServicioBLL Logica = new ServicioBLL();

        [TestMethod]
        public void TestCalcularCostoServicio1()
        {
            double calculo = Logica.CalcularCostoServicio(new Servicio() { Monto = 19.99 });

            Assert.AreEqual(13401.296, calculo);
        }

        [TestMethod]
        public void TestCalcularCostoServicio2()
        {
            double calculo = Logica.CalcularCostoServicio(new Servicio() { Monto = 10.5 });

            Assert.AreEqual(7035.42, calculo);
        }
    }
}
