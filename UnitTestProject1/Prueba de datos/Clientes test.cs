using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diseño_Gym_Hulk.Datos;

namespace UnitTestProject1.Prueba_de_datos
{
    [TestClass]
    public class UnitTest1
    {
        Cliente mCliente = new Cliente();
        [TestMethod]
        public void TestID()
        {
            mCliente.IDCliente = 1;
            int resultado = mCliente.IDCliente;
            Assert.AreEqual(1, resultado);
        }    
        [TestMethod]
        public void SetNombre()
        {
            mCliente.Nombre = "Angel";
            string resultado = mCliente.Nombre;

            Assert.AreEqual("Angel", resultado);

        }
        [TestMethod]
        public void TestApellido()
        {
            mCliente.Apellido = "Martinez";
            string resultado = mCliente.Apellido;
            Assert.AreEqual("Martinez", resultado);

        }
        [TestMethod]
        public void Testtelefono()
        {
            mCliente.Telefono = "4981057112";
            string resultado = mCliente.Telefono;
            Assert.AreEqual("4981057112", resultado);

        }

    
    }
}
