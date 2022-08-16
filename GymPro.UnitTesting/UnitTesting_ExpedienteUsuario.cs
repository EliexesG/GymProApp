using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GymPro.UnitTesting
{
    [TestClass]
    public class UnitTesting_ExpedienteUsuario
    {
        private IExpedienteUsuarioBLL Logica = new ExpedienteUsuarioBLL();

        [TestMethod]
        public void TestCalculoIMC1()
        {
            double calculo = Logica.CalcularIMC(new ExpedienteUsuario() { Altura = 180, Peso = 75 });

            Assert.AreEqual(23, calculo);
        }

        [TestMethod]
        public void TestCalculoIMC2()
        {
            double calculo = Logica.CalcularIMC(new ExpedienteUsuario() { Altura = 175, Peso = 63 });

            Assert.AreEqual(21, calculo);
        }

        [TestMethod]
        public void TestCalcularMetabolismoBasal1()
        {
            double calculo = Logica.CalcularMetabolismoBasal(new ExpedienteUsuario() { Altura = 180, Peso = 75 }, 22, Genero.Masculino);

            Assert.AreEqual(1770, calculo);
        }

        [TestMethod]
        public void TestCalcularMetabolismoBasal2()
        {
            double calculo = Logica.CalcularMetabolismoBasal(new ExpedienteUsuario() { Altura = 180, Peso = 75 }, 22, Genero.Femenino);

            Assert.AreEqual(1604, calculo);
        }
    }
}
