using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Gym_Hulk.BaseDatos
{
    class Conexion
    {
        OdbcConnection ConexionMySQL;

        public void conectar(String Controlador, String Servidor, String BaseDatos, String Usuario, String Password)
        {
            try
            {
                ConexionMySQL = new OdbcConnection("DRIVER={" + Controlador + "};SERVER=" + Servidor + ";DATABASE=" + BaseDatos + ";UID=" + Usuario + ";PWD=" + Password + ";");
                ConexionMySQL.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede conectar a la base de datos");
                Environment.Exit(0);

            }
            
            
        }
        public DataSet ejecutarConsulta(String SQL)
        {
            DataSet resultado = null;
            try
            {
                OdbcDataAdapter AdaptadorDatos = new OdbcDataAdapter(SQL, ConexionMySQL);
                 resultado = new DataSet();
                AdaptadorDatos.Fill(resultado);
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede conectar a la base de datos");
                Application.Exit();
            }
           
            return resultado;
        }
      
        public void ejecutarActualizacion(String SQL)
        {
            OdbcCommand Comando = new OdbcCommand(SQL, ConexionMySQL);
            Comando.ExecuteNonQuery();
        }
        public void desconectar()
        {
            ConexionMySQL.Close();
        }

    }
}
