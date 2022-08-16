using GymPro.Capa.Logica.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GymPro.UnitTesting
{
    [TestClass]
    public class UnitTest_Usuario
    {

        IUsuarioBLL Logica = new UsuarioBLL();

        [TestMethod]
        public void TestCalcularEdad1()
        {
            int calculo = Logica.CalcularEdadUsuario(new DateTime(2000, 10, 6));

            Assert.AreEqual(21, calculo);
        }

        [TestMethod]
        public void TestCalcularEdad2()
        {
            int calculo = Logica.CalcularEdadUsuario(new DateTime(2007, 4, 16));

            Assert.AreEqual(15, calculo);
        }

        [TestMethod]
        public void TestCalcularEdad3()
        {
            int calculo = Logica.CalcularEdadUsuario(new DateTime(2005, 12, 6));

            Assert.AreEqual(16, calculo);
        }

        [TestMethod]
        public void TestCalcularEdad4()
        {
            int calculo = Logica.CalcularEdadUsuario(new DateTime(1997, 7, 31));

            Assert.AreEqual(25, calculo);
        }
    }
}
