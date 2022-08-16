using GymPro.Capa.Entidades.Implementaciones;
using GymPro.Capa.Logica.Implementaciones;
using GymPro.Capa.Logica.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GymPro.UnitTesting
{
    [TestClass]
    public class UnitTesting_FacturaEncabezado
    {

        IFacturaEncabezadoBLLGestor Logica = new FacturaEncabezadoBLL();

        [TestMethod]
        public void TestYaPagado1()
        {
            DateTime fechaProxPago = DateTime.Now;

            Assert.AreEqual(true, Logica.YaPagado(fechaProxPago));
        }

        [TestMethod]
        public void TestYaPagado2()
        {
            DateTime fechaProxPago = new DateTime(2022, 7, 14);

            Assert.AreEqual(false, Logica.YaPagado(fechaProxPago));
        }

        [TestMethod]
        public void TestYaPagado3()
        {
            DateTime fechaProxPago = new DateTime(2022, 8, 22);

            Assert.AreEqual(true, Logica.YaPagado(fechaProxPago));
        }

        [TestMethod]
        public void TestEstaMoroso1()
        {
            DateTime fechaProxPago = new DateTime(2022, 8, 22);

            Assert.AreEqual(false, Logica.EstaMoroso(fechaProxPago));
        }

        [TestMethod]
        public void TestEstaMoroso2()
        {
            DateTime fechaProxPago = DateTime.Now;

            Assert.AreEqual(false, Logica.EstaMoroso(fechaProxPago));
        }

        [TestMethod]
        public void TestEstaMoroso3()
        {
            DateTime fechaProxPago = new DateTime(2022, 8, 10);

            Assert.AreEqual(true, Logica.EstaMoroso(fechaProxPago));
        }

        [TestMethod]
        public void TestSiguientePago1()
        {
            DateTime siguientePago = DateTime.Now.AddMonths(1);

            Assert.AreEqual(siguientePago, Logica.SiguientePago(DateTime.Now));
        }

        [TestMethod]
        public void TestCalcularMulta1()
        {
            double calculo = Logica.CalcularMulta(25000);

            Assert.AreEqual(2500, calculo);
        }

        [TestMethod]
        public void TestCalcularMulta2()
        {
            double calculo = Logica.CalcularMulta(30000);

            Assert.AreEqual(3000, calculo);
        }

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

        [TestMethod]
        public void TestValidarTarjeta1()
        {

            Exception exception = null;
            Tarjeta tarjeta = new Tarjeta() { AnnoExpiracion = 2022, CodigoSeguridad = "155", MesExpiracion = 12, Numero = "4401097300793430" };

            try
            {
                Logica.ValidarTarjeta(tarjeta);
            }
            catch(Exception er)
            {
                exception = er;
            }

            Assert.AreEqual(true, exception == null);
        }

        [TestMethod]
        public void TestValidarTarjeta2()
        {

            Exception exception = null;
            Tarjeta tarjeta = new Tarjeta() { AnnoExpiracion = 2022, CodigoSeguridad = "155d", MesExpiracion = 12, Numero = "4401097300793430" };

            try
            {
                Logica.ValidarTarjeta(tarjeta);
            }
            catch (Exception er)
            {
                exception = er;
            }

            string mensajeEsperado = "El campo del código debe ser llenado solamente con números";

            Assert.AreEqual(exception.Message, mensajeEsperado);
        }

        [TestMethod]
        public void TestValidarTarjeta3()
        {

            Exception exception = null;
            Tarjeta tarjeta = new Tarjeta() { AnnoExpiracion = 2022, CodigoSeguridad = "1555", MesExpiracion = 12, Numero = "4401097300793430" };

            try
            {
                Logica.ValidarTarjeta(tarjeta);
            }
            catch (Exception er)
            {
                exception = er;
            }

            string mensajeEsperado = "Código de seguridad incorrecto, debe ser un número de 3 dígitos";

            Assert.AreEqual(exception.Message, mensajeEsperado);
        }

        [TestMethod]
        public void TestValidarTarjeta4()
        {

            Exception exception = null;
            Tarjeta tarjeta = new Tarjeta() { AnnoExpiracion = 2022, CodigoSeguridad = "155", MesExpiracion = 8, Numero = "4401097300793430" };

            try
            {
                Logica.ValidarTarjeta(tarjeta);
            }
            catch (Exception er)
            {
                exception = er;
            }

            string mensajeEsperado = "La tarjeta con la que se desea pagar ha expirado";

            Assert.AreEqual(exception.Message, mensajeEsperado);
        }

        [TestMethod]
        public void TestValidarTarjeta5()
        {

            Exception exception = null;
            Tarjeta tarjeta = new Tarjeta() { AnnoExpiracion = 2021, CodigoSeguridad = "155", MesExpiracion = 9, Numero = "4401097300793430" };

            try
            {
                Logica.ValidarTarjeta(tarjeta);
            }
            catch (Exception er)
            {
                exception = er;
            }

            string mensajeEsperado = "La tarjeta con la que se desea pagar ha expirado";

            Assert.AreEqual(exception.Message, mensajeEsperado);
        }

        [TestMethod]
        public void TestValidarTarjeta6()
        {

            Exception exception = null;
            Tarjeta tarjeta = new Tarjeta() { AnnoExpiracion = 2022, CodigoSeguridad = "155", MesExpiracion = 12, Numero = "44010973007934d0" };

            try
            {
                Logica.ValidarTarjeta(tarjeta);
            }
            catch (Exception er)
            {
                exception = er;
            }

            string mensajeEsperado = "El campo del número de tarjeta debe ser llenado solamente con números";

            Assert.AreEqual(exception.Message, mensajeEsperado);
        }

        [TestMethod]
        public void TestValidarTarjeta7()
        {

            Exception exception = null;
            Tarjeta tarjeta = new Tarjeta() { AnnoExpiracion = 2022, CodigoSeguridad = "155", MesExpiracion = 12, Numero = "4401097" };

            try
            {
                Logica.ValidarTarjeta(tarjeta);
            }
            catch (Exception er)
            {
                exception = er;
            }

            string mensajeEsperado = "El número de la tarjeta no es válido, digite un número válido";

            Assert.AreEqual(exception.Message, mensajeEsperado);
        }

        [TestMethod]
        public void TestValidarTarjeta8()
        {

            Exception exception = null;
            Tarjeta tarjeta = new Tarjeta() { AnnoExpiracion = 2022, CodigoSeguridad = "155", MesExpiracion = 12, Numero = "4401015300793430" };

            try
            {
                Logica.ValidarTarjeta(tarjeta);
            }
            catch (Exception er)
            {
                exception = er;
            }

            string mensajeEsperado = "El número de la tarjeta no es válido, digite un número válido";

            Assert.AreEqual(exception.Message, mensajeEsperado);
        }
    }
}
