using Diseño_Gym_Hulk.BaseDatos;
using Diseño_Gym_Hulk.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Gym_Hulk.Logica
{
    class ControlMembresia
    {
        Conexion mConexion;
        public ControlMembresia()
        {
            mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
        }

        public void agregarMembresia(Membresia mMembresia)
        {
            String SQL = "insert into membresia values (null,'?1','?2','?3','?4','?5','?6')";
            SQL = SQL.Replace("?1", mMembresia.Preciosemana.ToString());
            SQL = SQL.Replace("?2", mMembresia.Descripcion);
            SQL = SQL.Replace("?3", mMembresia.Precio15dias.ToString());
            SQL = SQL.Replace("?4", mMembresia.Preciomes.ToString());
            SQL = SQL.Replace("?5", mMembresia.Precioanio.ToString());
            SQL = SQL.Replace("?6", mMembresia.Preciodia.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }
        public DataSet consultarMembresias()
        {
            DataSet ListaMembresias = null;
            try
            {
                String SQL = "select * from membresia";
                ListaMembresias = mConexion.ejecutarConsulta(SQL);
               

            }
            catch (Exception e)
            {
                MessageBox.Show("NO HAY CONEXION");
                Application.Exit();
            }
            return ListaMembresias;
        }
        public DataSet consultarMembresia2(string nombre)
        {
            String SQL = "SELECT * FROM membresia WHERE Descripcion LIKE '%" + nombre + "%'";
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            return ListaClientes;
        }
        public void modificarMembresia(Membresia mMembresia)
        {
            String SQL = "update membresia set Preciosemana='?1',Descripcion='?2',Precio15dias='?3',Preciomes='?4',Precioanio='?5',Preciodia='?6' where idMembresia='?7'";
            SQL = SQL.Replace("?1", mMembresia.Preciosemana.ToString());
            SQL = SQL.Replace("?2", mMembresia.Descripcion);
            SQL = SQL.Replace("?3", mMembresia.Precio15dias.ToString());
            SQL = SQL.Replace("?4", mMembresia.Preciomes.ToString());
            SQL = SQL.Replace("?5", mMembresia.Precioanio.ToString());
            SQL = SQL.Replace("?6", mMembresia.Preciodia.ToString());
            SQL = SQL.Replace("?7", mMembresia.IDMembresia.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }
        public void eliminarMembresia(int ID)
        {
            String SQL = "delete from membresia where idMembresia='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }

        public DataSet ComprobarMembresias(String id,String fecha,String idmem)
        {
            DataSet ListaMembresias = null;
            try
            {
                String SQL = "select idVenta from venta_membresia where Cliente_idCliente = "+ id + " and (Fecha_fin >= '" + fecha + "' and Membresia_idMembresia = " + idmem+")";
                ListaMembresias = mConexion.ejecutarConsulta(SQL);
            }
            catch (Exception e)
            {
                MessageBox.Show("NO HAY CONEXION");
                Application.Exit();
            }
            return ListaMembresias;
        }

        public DataSet Comprobaractivacion(String id, String fecha)
        {
            DataSet ListaMembresias = null;
            try
            {
                String SQL = "select idVenta from venta_membresia where Cliente_idCliente = " + id + " and Fecha_fin >= '" + fecha + "'";
                ListaMembresias = mConexion.ejecutarConsulta(SQL);
            }
            catch (Exception e)
            {
                MessageBox.Show("NO HAY CONEXION");
                Application.Exit();
            }
            return ListaMembresias;
        }
    }
}
