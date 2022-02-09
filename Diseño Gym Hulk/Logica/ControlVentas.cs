using Diseño_Gym_Hulk.BaseDatos;
using Diseño_Gym_Hulk.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Gym_Hulk.Logica
{
    class ControlVentas
    {
        String resultado;
        Conexion mConexion;
        public ControlVentas()
        {
            mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
        }
        public void agregarVenta(Ventas mVentas)
        {
            String SQL = "insert into venta_membresia values (null,'?1','?2','?3','?4','?5','?6')";
            SQL = SQL.Replace("?1", mVentas.Fecha_inicio.ToString());
            SQL = SQL.Replace("?2", mVentas.Fecha_fin.ToString());
            SQL = SQL.Replace("?3", mVentas.Total.ToString());
            SQL = SQL.Replace("?4", mVentas.IDCliente.ToString());
            SQL = SQL.Replace("?5", mVentas.IDMembresia.ToString());
            SQL = SQL.Replace("?6", mVentas.Fecha_venta.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }
        public DataSet Reporte(String Fecha_inicio, String Fecha_fin)
        {
            String SQL = "select * from  venta_membresia  where Fecha_venta >= '"+ Fecha_inicio +"' and Fecha_venta <= '"+Fecha_fin+"'";
            DataSet ListaVentas = mConexion.ejecutarConsulta(SQL);
            return ListaVentas;
        }
        
        
        public DataSet consultarVentas()
        {
            String SQL = "select * from venta_membresia";
            DataSet ListaVentas = mConexion.ejecutarConsulta(SQL);
            return ListaVentas;
        }
        public DataSet consultarVenta2(string nombre)
        {
            String SQL = "select * from cliente where nombre = '?1'";
            SQL = SQL.Replace("?1", nombre);
            DataSet ListaVentas = mConexion.ejecutarConsulta(SQL);
            return ListaVentas;
        }
        

        public void eliminarVenta(String fecha_fin)
        {
            String SQL = "delete from venta_membresia where Fecha_fin='"+ fecha_fin+"'";
            mConexion.ejecutarActualizacion(SQL);
        }

    }
}
