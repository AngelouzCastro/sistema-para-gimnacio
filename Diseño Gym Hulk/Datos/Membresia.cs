using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Gym_Hulk.Datos
{
    class Membresia
    {
        private int IDmembresia;
        private String descripcion;
        private float precioSemana;
        private float precio15dias;
        private float precioMes;
        private float precioAnio;
        private float precioDia;


        public int IDMembresia
        {
            get { return IDmembresia; }
            set { IDmembresia = value; }
        }
       
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float Preciosemana
        {
            get { return precioSemana; }
            set { precioSemana = value; }
        }

        public float Precio15dias
        {
            get { return precio15dias; }
            set { precio15dias = value; }
        }
        public float Preciomes
        {
            get { return precioMes; }
            set { precioMes = value; }
        }
        public float Precioanio
        {
            get { return precioAnio; }
            set { precioAnio = value; }
        }
        public float Preciodia
        {
            get { return precioDia; }
            set { precioDia = value; }
        }


    }
}
