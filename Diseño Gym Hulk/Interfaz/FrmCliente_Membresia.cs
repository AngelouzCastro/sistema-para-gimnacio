using Diseño_Gym_Hulk.Logica;
using Diseño_Gym_Hulk.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Gym_Hulk
{
    public partial class FrmCliente_Membresia : Form
    {
        
        public FrmCliente_Membresia()
        {
            InitializeComponent();
            
        }

        private void FrmCliente_Membresia_Load(object sender, EventArgs e)
        {
            LblIdClientev.Text = Id;
            DtpFechaActual.Visible = false;
            this.Text="Numero  de cliente: "+Id; 
            
            

            try
            {
                ControlCliente mControlCliente = new ControlCliente();
                TbLVerCliente.DataSource = mControlCliente.verCliente(int.Parse(LblIdClientev.Text),DtpFechaActual.Text).Tables[0];

            }
            catch (Exception)
            {

                MessageBox.Show("No se seleciono ningun cliente");
                Visible = false;
            }

        }
        public string Id { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
