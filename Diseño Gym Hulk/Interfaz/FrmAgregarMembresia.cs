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
    public partial class FrmAgregarMembresia : Form
    {
        VALIDACION mVALIDACION = new VALIDACION();
        
        public FrmAgregarMembresia()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            TxtDescripcion.Text = TxtDescripcion.Text.Trim(' ');
            TxtPrecioDia.Text = TxtPrecioDia.Text.TrimEnd('.', ',');
            TxtPrecioSemana.Text = TxtPrecioSemana.Text.TrimEnd('.', ',');
            TxtPrecio15dias.Text = TxtPrecio15dias.Text.TrimEnd('.', ',');
            TxtPreciomes.Text = TxtPreciomes.Text.TrimEnd('.',',');
            TxtPrecioAnio.Text = TxtPrecioAnio.Text.TrimEnd('.', ',');

            try
            {
                if (float.Parse(TxtPrecioDia.Text) <= 0)
                {
                    TxtPrecioDia.Text = "";
                }
                if (float.Parse(TxtPrecio15dias.Text) <= 0)
                {
                    TxtPrecio15dias.Text = "";
                }
                if (float.Parse(TxtPrecioSemana.Text) <= 0)
                {
                    TxtPrecioSemana.Text = "";
                }
                if (float.Parse(TxtPreciomes.Text) <= 0)
                {
                    TxtPreciomes.Text = "";
                }
                if (float.Parse(TxtPrecioAnio.Text) <= 0)
                {
                    TxtPrecioAnio.Text = "";
                }

                if(TxtDescripcion.Text != "")
                {
                    Membresia mMembresia = new Membresia();
                    mMembresia.Preciosemana = float.Parse(TxtPrecioSemana.Text);
                    mMembresia.Descripcion = TxtDescripcion.Text;
                    mMembresia.Precio15dias = float.Parse(TxtPrecio15dias.Text);
                    mMembresia.Preciomes = float.Parse(TxtPreciomes.Text);
                    mMembresia.Precioanio = float.Parse(TxtPrecioAnio.Text);
                    mMembresia.Preciodia = float.Parse(TxtPrecioDia.Text);


                    ControlMembresia mControlMembresia = new ControlMembresia();
                    mControlMembresia.agregarMembresia(mMembresia);
                    MessageBox.Show("Membresia Registrada con exito");


                    Visible = false;
                }
                else
                {
                    if (TxtDescripcion.Text == "")
                    {
                        MessageBox.Show("dato en el campo 'Descripcion' incorrecto");
                    }
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al registrar");
                if(TxtDescripcion.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Descripcion' incorrecto");
                }
                else if(TxtPrecioDia.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Día' incorrecto");
                }
                else if (TxtPrecioSemana.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Semana' incorrecto");
                }
                else if (TxtPrecio15dias.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por 15 Dias' incorrecto");
                }
                else if (TxtPreciomes.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Més' incorrecto");
                }
                else if (TxtPrecioAnio.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Año' incorrecto");
                }
               

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmAgregarMembresia_Load(object sender, EventArgs e)
        {
            TxtDescripcion.Text = "";
            TxtPrecioDia.Text = "";
            TxtPrecioSemana.Text = "";
            TxtPrecio15dias.Text = "";
            TxtPreciomes.Text = "";
            TxtPrecioAnio.Text = "";
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (TxtDescripcion.Text.Length == 0)
            {
                mVALIDACION.sololetras2(e);
            }
            else if (TxtDescripcion.Text.Length >= 40)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.sololetras(e);
            }


        }

        private void TxtPrecioDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (TxtPrecioDia.Text.Length == 0)
            {
                mVALIDACION.solonumeros2(e);
            }
            else if(TxtPrecioDia.Text.Length >= 10)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.solonumeros(e);
            }
        }

        private void TxtPrecioSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtPrecioSemana.Text.Length == 0)
            {
                mVALIDACION.solonumeros2(e);
            }
            else if (TxtPrecioSemana.Text.Length >= 10)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.solonumeros(e);
            }
        }

        private void TxtPrecio15dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtPrecio15dias.Text.Length == 0)
            {
                mVALIDACION.solonumeros2(e);
            }
            else if (TxtPrecio15dias.Text.Length >= 10)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.solonumeros(e);
            }
        }

        private void TxtPreciomes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtPreciomes.Text.Length == 0)
            {
                mVALIDACION.solonumeros2(e);
            }
            else if (TxtPreciomes.Text.Length >= 10)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.solonumeros(e);
            }
        }

        private void TxtPrecioAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtPrecioAnio.Text.Length == 0)
            {
                mVALIDACION.solonumeros2(e);
            }
            else if (TxtPrecioAnio.Text.Length >= 10)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.solonumeros(e);
            }
        }

        private void TxtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtDescripcion.Text = "";
            }
        }

        private void TxtPrecioDia_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtPrecioDia.Text = "";
            }
        }

        private void TxtPrecioSemana_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtPrecioSemana.Text = "";
            }
        }

        private void TxtPrecio15dias_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtPrecio15dias.Text = "";
            }
        }

        private void TxtPreciomes_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtPreciomes.Text = "";
            }
        }

        private void TxtPrecioAnio_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtPrecioAnio.Text = "";
            }
        }
    }
}
