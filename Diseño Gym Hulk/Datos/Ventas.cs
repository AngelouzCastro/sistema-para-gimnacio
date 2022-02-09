using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Gym_Hulk.Datos
{
    class Ventas
    {
        private int idventa;
        private String fecha_inicio;
        private String fecha_fin;
        private float total;
        private int idcliente;
        private int idmembresia;
        private String fecha_venta;

        //creo que eso es todo 

        public int IDVenta
        {
            get { return idventa; }
            set { idventa = value; }
        }
        public String Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }
        public String Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        public int IDCliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        public int IDMembresia
        {
            get { return idmembresia; }
            set { idmembresia = value; }
        }
        public String Fecha_venta
        {
            get { return fecha_venta; }
            set { fecha_venta = value; }
        }
    }
}
