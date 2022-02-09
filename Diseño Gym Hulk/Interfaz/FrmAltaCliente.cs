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
    public partial class FrmAltaCliente : Form
    {
        VALIDACION mValidacion = new VALIDACION();
        
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                TxtNombres.Text = TxtNombres.Text.Trim(' ');
                TxtApellidos.Text = TxtApellidos.Text.Trim(' ');

                if (TxtNombres.Text != "" && TxtApellidos.Text != "")
                {
                    Cliente mCliente = new Cliente();
                    mCliente.Nombre = TxtNombres.Text;
                    mCliente.Apellido = TxtApellidos.Text;
                    mCliente.Telefono = TxtTelefono.Text;
                    mCliente.Estado = "activo";

                    ControlCliente mControlCliente = new ControlCliente();
                    mControlCliente.agregarCliente(mCliente);
                    MessageBox.Show("Cliente Registrado");
                    this.Visible = false;
                    
                }
                else
                {
                    if (TxtNombres.Text == "")
                    {
                        MessageBox.Show("dato en el campo 'Nombre' incorrecto");
                    }
                    else if (TxtApellidos.Text == "")
                    {
                        MessageBox.Show("dato en el campo 'Apellidos' incorrecto");
                    }
                }

                   
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al Registrar");
                if (TxtNombres.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Nombre' incorrecto");
                }
                else if (TxtApellidos.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Apellidos' incorrecto");
                }
                
                
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            TxtApellidos.Text = "";
            TxtNombres.Text = "";
            TxtTelefono.Text = "";
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (TxtNombres.Text.Length == 0)
            {
                mValidacion.sololetras2(e);
            }
            else if (TxtNombres.Text.Length >= 40)
            {
                mValidacion.soloborrar(e);
            }
            else
            {
                mValidacion.sololetras(e);
            }
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtApellidos.Text.Length == 0)
            {
                mValidacion.sololetras2(e);
            }
            else if (TxtApellidos.Text.Length >= 40)
            {
                mValidacion.soloborrar(e);
            }
            else
            {
                mValidacion.sololetras(e);
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (TxtTelefono.Text.Length >= 10)
            {
                mValidacion.soloborrar(e);
            }
            else
            {
                mValidacion.telefono(e);
            }
        }

        private void TxtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtNombres.Text = "";
            }
        }

        private void TxtApellidos_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtApellidos.Text = "";
            }
        }

        private void TxtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtTelefono.Text = "";
            }
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
