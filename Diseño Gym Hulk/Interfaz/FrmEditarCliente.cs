using Diseño_Gym_Hulk.Datos;
using Diseño_Gym_Hulk.Logica;
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
    public partial class FrmEditarCliente : Form
    {
        VALIDACION mVALIDACION = new VALIDACION();
        ControlMembresia mControlmembresia = new ControlMembresia();
        public FrmEditarCliente()
        {
            InitializeComponent();
        }
        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            LblIdCliente.Text = Id.ToString();
            Txtnombre.Text = Nombre;
            Txtapellidos.Text = Apellidos;
            Txttelefono.Text = Telefono.ToString();
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Txtnombre.Text = Txtnombre.Text.Trim(' ');
                Txtapellidos.Text = Txtapellidos.Text.Trim(' ');

                if (Txtnombre.Text != "" && Txtapellidos.Text != "")
                {
                    Cliente mCliente = new Cliente();
                    int ID = Id;
                    mCliente.IDCliente = ID;
                    mCliente.Nombre = Txtnombre.Text;
                    mCliente.Telefono = Txttelefono.Text;
                    mCliente.Apellido = Txtapellidos.Text;
                    if (RbdActivo.Checked)
                    {
                        mCliente.Estado = "activo";

                        ControlCliente mControlCliente = new ControlCliente();
                        mControlCliente.modificarCliente(mCliente);
                        MessageBox.Show("Cliente actualizado");
                        this.Visible = false;
                    }
                    if (RbdInactivo.Checked)
                    {
                        mCliente.Estado = "inactivo";

                        String formato = "yyyy-MM-dd";
                        DateTime fecha = DateTime.Now;
                        String fechahoy = fecha.ToString(formato);
                        DataSet Comprobar;
                        Comprobar = mControlmembresia.Comprobaractivacion(LblIdCliente.Text, fechahoy);
                        if (Comprobar.Tables[0].Rows.Count != 0)
                        {
                            MessageBox.Show("Este cliente no se pude desactivar por que aun tiene una membresia vigente");
                            this.Visible = false;
                        }
                        else
                        {
                            ControlCliente mControlCliente = new ControlCliente();
                            mControlCliente.modificarCliente(mCliente);
                            MessageBox.Show("Cliente actualizado");
                            this.Visible = false;
                        }
                    }
                    
                    
                       
                    

                    
                }
                else
                {

                    if (Txtnombre.Text == "")
                    {
                        MessageBox.Show("dato en el campo 'Nombre' incorrecto");
                    }
                    else if (Txtapellidos.Text == "")
                    {
                        MessageBox.Show("dato en el campo 'Apellidos' incorrecto");
                    }
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar ");
                if (Txtnombre.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Nombre' incorrecto");
                }
                else if (Txtapellidos.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Apellidos' incorrecto");
                }
                
            }
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }

        private void FrmEditarCliente_Load_1(object sender, EventArgs e)
        {
            LblIdCliente.Text = Id.ToString();
            Txtnombre.Text = Nombre;
            Txtapellidos.Text = Apellidos;
            Txttelefono.Text = Telefono.ToString();
            

            if (Estado == "activo")
            {
                RbdActivo.Select();
            }
            else
            {
                RbdInactivo.Select();
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Txtnombre.Text.Length == 0)
            {
                mVALIDACION.sololetras(e);
            }
            else if (Txtnombre.Text.Length >= 40)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.sololetras(e);
            }
        }

        private void Txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Txtapellidos.Text.Length == 0)
            {
                mVALIDACION.sololetras2(e);
            }
            else if (Txtapellidos.Text.Length >= 40)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.sololetras(e);
            }
        }

        private void Txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Txttelefono.Text.Length >= 10)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.telefono(e);
            }
            
        }

        private void Txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                Txtnombre.Text = "";
            }
        }

        private void Txtapellidos_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control + V");
                Txtapellidos.Text = "";
            }
        }

        private void Txttelefono_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                Txttelefono.Text = "";
            }
        }
    }
}
