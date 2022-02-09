using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Gym_Hulk.Datos
{
    class Cliente
    {
        private int idCliente;
        private String telefono;
        private String nombre;
        private String apellido;
        private String estado;


        public int IDCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
