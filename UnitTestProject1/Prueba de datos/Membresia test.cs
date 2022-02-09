using System;
using Diseño_Gym_Hulk.Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Prueba_de_datos
{
    [TestClass]
    public class UnitTest2
    {
        Membresia mMrmbresia = new Membresia();
        [TestMethod]
        public void TestId()
        {
            mMrmbresia.IDMembresia = 1;
            int resultado = mMrmbresia.IDMembresia;
            Assert.AreEqual(1, resultado);
        }
        public void TestDescripcion()
        {
            mMrmbresia.Descripcion = "pesas";
            string resultado = mMrmbresia.Descripcion;
            Assert.AreEqual("pesas", resultado);
        }
        public void TestPreciosemana()
        {
            mMrmbresia.Preciosemana = 15;
            float resultado = mMrmbresia.Preciosemana;
            Assert.AreEqual(15, resultado);
        }
        public void TestPrecio15dias()
        {
            mMrmbresia.Precio15dias = 20;
            float resultado = mMrmbresia.Precio15dias;
            Assert.AreEqual(20, resultado);
        }
        public void TestPrecioMes()
        {
            mMrmbresia.Preciomes = 80;
            float resultado = mMrmbresia.Preciomes;
            Assert.AreEqual(80, resultado);
        }
        public void TestPrecioAnio()
        {
            mMrmbresia.Precioanio = 150;
            float resultado = mMrmbresia.Precioanio;
            Assert.AreEqual(150, resultado);
        }
        public void TestPrecioDia()
        {
            mMrmbresia.Preciodia = 10;
            float resultado = mMrmbresia.Preciodia;
            Assert.AreEqual(10, resultado);
        }
    }
}
