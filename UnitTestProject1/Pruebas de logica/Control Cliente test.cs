using Diseño_Gym_Hulk;
using Diseño_Gym_Hulk.BaseDatos;
using Diseño_Gym_Hulk.Datos;
using Diseño_Gym_Hulk.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestProject1.Pruebas_de_logica
{
   
    [TestClass]
    public class UnitTest1
    {
        ControlCliente mControlCliente = new ControlCliente();
        Cliente mCliente = new Cliente();
        Cliente mCliente2 = new Cliente();
        FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
       

        [TestMethod]
        public void TestAgregarCliente()
        {
            //mCliente.IDCliente = 100;
            mCliente.Nombre = "lalo";
            mCliente.Apellido = "martinez";
            mCliente.Telefono = "4981057112";
            mControlCliente.agregarCliente(mCliente);
            string SQL = "select Nombre from cliente where idCliente = '41'";
            string resultado = "";
            Conexion mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            foreach (DataRow dr in ListaClientes.Tables[0].Rows)
            {
                
                 resultado = dr[0].ToString();
               
               
            }
            Assert.AreEqual(resultado, "lalo");
        }
        [TestMethod]
        public void TestConsultarcliente()
        {
            string resultado = "";
            string ExpResult = "noe";
            int id = 13;

            string SQL = "select Nombre from cliente where  idCliente  = '" + id + "'";
            Conexion mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            foreach (DataRow dr in ListaClientes.Tables[0].Rows)
            {

                resultado = dr[0].ToString();


            }
            Assert.AreEqual(resultado, ExpResult);
        }

        [TestMethod]
        public void TestConsultarclientefiltrado()
        {
            string []resultado = new string[3];
            string ExpResult = "ro";
            string id = "8";
            string id3 = "10";
            string id2 = "20";

            string SQL = "SELECT idCliente FROM cliente WHERE Nombre  LIKE '%"+ExpResult+"%'";
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
            string ExpResult = "noe";
            int id = 13;

            string SQL = "select Nombre from cliente where  idCliente  = '" + id + "'";
            Conexion mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            foreach (DataRow dr in ListaClientes.Tables[0].Rows)
            {

                resultado = dr[0].ToString();


            }
            Assert.AreEqual(resultado, ExpResult);
        }

        [TestMethod]
        public void TestEliminarCliente()
        {
            string resultado = "";
            string ExpResult = "";
            int id = 5;

            string SQL = "delete from cliente where idCliente= '" + id + "'";
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
