using System;
using System.Data;
using Diseño_Gym_Hulk.BaseDatos;
using Diseño_Gym_Hulk.Datos;
using Diseño_Gym_Hulk.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Pruebas_de_logica
{
    

    [TestClass]
    public class UnitTest2
    {
        Membresia mMembresia = new Membresia();
        ControlMembresia mControlMembresia = new ControlMembresia();
        [TestMethod]
        public void agregarMembresia()
        {
            mMembresia.Descripcion = "cualquiera";
            mMembresia.Preciosemana = 100;
            mMembresia.Precio15dias = 48;
            mMembresia.Preciomes = 50;
            mMembresia.Precioanio = 200;
            mMembresia.Preciodia = 10;
            mControlMembresia.agregarMembresia(mMembresia);
            string SQL = "select Descripcion from membresia where idCliente = '18'";
            string resultado = "";
            Conexion mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            foreach (DataRow dr in ListaClientes.Tables[0].Rows)
            {

                resultado = dr[0].ToString();


            }
            Assert.AreEqual(resultado, "cualquiera");
        }
        [TestMethod]
        public void TestConsultarcliente()
        {
            string resultado = "";
            string ExpResult = "pesas";
            int id = 6;

            string SQL = "select Descripcion from membresia where  idMembresia  = '" + id + "'";
            Conexion mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
            DataSet ListaMembresias = mConexion.ejecutarConsulta(SQL);
            foreach (DataRow dr in ListaMembresias.Tables[0].Rows)
            {

                resultado = dr[0].ToString();


            }
            Assert.AreEqual(resultado, ExpResult);
        }
        [TestMethod]
        public void TestConsultarclientefiltrado()
        {
            string[] resultado = new string[3];
            string ExpResult = "bo";
            string id = "4";
            string id3 = "6";
            string id2 = "9";

            string SQL = "SELECT idCliente FROM cliente WHERE Nombre  LIKE '%" + ExpResult + "%'";
            Conexion mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            int i = 0;
            foreach (DataRow dr in ListaClientes.Tables[0].Rows)
            {

                resultado[i] = dr[0].ToString();
                i++;

            }

            string Resultado = "";
            string Resultado2 = "";
            string Resultado3 = "";
            Resultado = resultado[0];
            Resultado2 = resultado[1];
            Resultado3 = resultado[2];
            Assert.AreEqual(Resultado, id);
            Assert.AreEqual(Resultado2, id3);
            Assert.AreEqual(Resultado3, id2);

        }
        [TestMethod]
        public void TestModificarCliente()
        {
            string resultado = "";
            string ExpResult = "box";
            int id = 6;

            string SQL = "select Descripcion from membresia where  idMembresia  = '" + id + "'";
            Conexion mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            foreach (DataRow dr in ListaClientes.Tables[0].Rows)
            {

                resultado = dr[0].ToString();


            }
            Assert.AreEqual(resultado, ExpResult);
        }
    }
}
