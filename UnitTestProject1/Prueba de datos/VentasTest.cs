using System;
using Diseño_Gym_Hulk.Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Prueba_de_datos
{
    [TestClass]
    public class UnitTest3
    {
        Ventas mVentas = new Ventas();
        [TestMethod]
        public void TestIdVenta()
        {
            mVentas.IDVenta = 1;
            int resultado = mVentas.IDVenta;
            Assert.AreEqual(1, resultado);
        }
        public void TestFechaInicio()
        {
            mVentas.Fecha_inicio = "2020-04-24";
            string resultado = mVentas.Fecha_inicio;
            Assert.AreEqual("2020-04-24", resultado);
        }
        public void TestFechaFin()
        {
            mVentas.Fecha_fin = "2020-05-24";
            string resultado = mVentas.Fecha_fin;
            Assert.AreEqual("2020-05-24", resultado);
        }
        public void TestTotal()
        {
            mVentas.Total = 200;
            float resultado = mVentas.Total;
            Assert.AreEqual(200, resultado);
        }
        public void TestIdCliente()
        {
            mVentas.IDCliente = 1;
            int resultado = mVentas.IDCliente;
            Assert.AreEqual(2, resultado);
        }
        public void TestIdMembresia()
        {
            mVentas.IDMembresia = 2;
            int resultado = mVentas.IDMembresia;
            Assert.AreEqual(2, resultado);
        }

    }
}
