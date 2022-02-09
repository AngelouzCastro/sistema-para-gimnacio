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
using Microsoft.VisualBasic;

namespace Diseño_Gym_Hulk
{
    public partial class FRMVentaMembresia : Form
    {
       
        ControlCliente mControlCliente;
        ControlMembresia mControlmembresia;
        ControlMembresia mControlmembresia2;
        //ControlVentas mControlVentas;
        Ventas mVentass;
        private float preciosemana;
        private float preciodia;
        private float precio15dias;
        private float preciomes;
        private float precioanio;
        private float cambio;
        private String telefono;
        private int IDventas,IDcliente,IDMembresia=1;
        private String nombre;
        private String apellidos;
        private String descripcion;
        private string fecha_inicio;
        private string fecha_fin;
        private string fecha_venta;
        VALIDACION mVALIDACION = new VALIDACION();


        public FRMVentaMembresia()
        {
            InitializeComponent();
            
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechaInicio.Text = DateTime.Now.ToShortDateString();
            LblAdvertencia.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            fecha_inicio = DtpFechaInicio.Text;

            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
                fecha_fin = DtpFechaInicio.Value.AddDays(7).ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
                fecha_fin = DtpFechaInicio.Value.AddDays(15).ToString();
                
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
                fecha_fin = DtpFechaInicio.Value.AddMonths(1).ToString();
                
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
                
                fecha_fin = DtpFechaInicio.Value.AddDays(1).ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
               
                fecha_fin = DtpFechaInicio.Value.AddYears(1).ToString();
            }

            if (validar())
            {
                double Cambiesin = float.Parse(TxtDinero.Text) - float.Parse(LblTotal.Text);



                MessageBox.Show("Cambio: " + Cambiesin);



                


                try
                {
                    
                    Ventas mVentas = new Ventas();
                    mVentas.Fecha_inicio = DtpFechaInicio.Text;
                    mVentas.Fecha_fin = DtpFechaFin.Text;
                    mVentas.Total = float.Parse(LblTotal.Text);
                    mVentas.IDCliente = int.Parse(LblIdCliente.Text);
                    mVentas.IDMembresia = int.Parse(LblIdMembresia.Text);
                    mVentas.Fecha_venta = DtpFechaVenta.Text;

                   
                    DataSet Comprobar;
                    
                    Comprobar = mControlmembresia.ComprobarMembresias(LblIdCliente.Text, DtpFechaVenta.Text,LblIdMembresia.Text);
                    if ((Comprobar.Tables[0].Rows.Count != 0) && (LblIdCliente.Text != "4")) 
                    {
                        MessageBox.Show("Este cliente ya tiene una membresia de este tipo activa");
                        
                    }
                    else
                    {
                        
                        cambio = float.Parse(TxtDinero.Text) - float.Parse(LblTotal.Text);

                        ControlVentas mControlVentas = new ControlVentas();
                        mControlVentas.agregarVenta(mVentas);
                        MessageBox.Show("Gracias por su preferencia");
                        TxtDinero.Text = "";
                    }



                    

                   
                    BtnAceptar.Enabled = false;
                    LblIdCliente.Text = "0";
                    LblNombreCliente.Text = "Selecione cliente";
                    LblApellido.Text = "Selecione cliente";
                    LblIdMembresia.Text = "0";
                    LblMem.Text = "Selecione membresia";

                }
                catch (Exception error)
                {
                    MessageBox.Show("algo salio mal" + error);
                }

            }


        }
        
        private void FRMVentaMembresia_Load(object sender, EventArgs e)
        {
            RbdClientereg.Select();
            DtpFechaVenta.Visible = true;
            DtpFechaInicio.Text = DateTime.Now.ToShortDateString();
            DtpFechaVenta.Text = DateTime.Now.ToShortDateString();
            LblAdvertencia.Visible = false;
            mControlCliente = new ControlCliente();
            TblClientes.DataSource = mControlCliente.consultarClientes("activo").Tables[0];
            mControlmembresia = new ControlMembresia();
            TblMembresia.DataSource = mControlmembresia.consultarMembresias().Tables[0];
            //IDMembresia = 0;


            
           

           

            



            RbdDia.Select();
            BtnAceptar.Enabled = false;

            LblNombreCliente.Text = "Selecione Cliente";
            LblApellido.Text = "Selecione Cliente";
            LblMem.Text = "Selecione Membresia";
            LblIdMembresia.Text = "0";
            LblIdCliente.Text = "0";

        }

        private void TblClientes_MouseClick(object sender, MouseEventArgs e)
        {
             IDcliente = (int)TblClientes.SelectedRows[0].Cells[0].Value;
            nombre = TblClientes.SelectedRows[0].Cells[1].Value.ToString();
            telefono = TblClientes.SelectedRows[0].Cells[2].Value.ToString();
            apellidos = TblClientes.SelectedRows[0].Cells[3].Value.ToString();

            LblIdCliente.Text = IDcliente.ToString();
            LblNombreCliente.Text = nombre;
            LblApellido.Text = apellidos;


            if (DtpFechaInicio.Value < DtpFechaVenta.Value)
            {
                LblAdvertencia.Visible = true;
                BtnAceptar.Enabled = false;
            }
            else
            {
                LblAdvertencia.Visible = false;
                BtnAceptar.Enabled = true;
            }

            if (LblIdMembresia.Text == "0")
            {
                BtnAceptar.Enabled = false;
            }

           
        }

        private void TblMembresia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rbd15dias_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechaInicio.Text = DateTime.Now.ToShortDateString();
            LblAdvertencia.Visible = false;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void TblMembresia_MouseClick(object sender, MouseEventArgs e)
        {
            
            IDMembresia = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
            preciosemana = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            descripcion = (String)TblMembresia.SelectedRows[0].Cells[2].Value;
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[3].Value;
            preciomes = (float)TblMembresia.SelectedRows[0].Cells[4].Value;
            precioanio = (float)TblMembresia.SelectedRows[0].Cells[5].Value;
            preciodia = (float)TblMembresia.SelectedRows[0].Cells[6].Value;

            LblMem.Text = descripcion;
            LblIdMembresia.Text = IDMembresia.ToString();

            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }

            if (DtpFechaInicio.Value < DtpFechaVenta.Value)
            {
                LblAdvertencia.Visible = true;
                BtnAceptar.Enabled = false;
            }
            else
            {
                LblAdvertencia.Visible = false;
                BtnAceptar.Enabled = true;
            }

            if (LblIdCliente.Text == "0")
            {
                BtnAceptar.Enabled = false;
            }

        }

        private void RbdSemana_MouseClick(object sender, MouseEventArgs e)
        {

            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(15);
            IDMembresia = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
            preciosemana = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            descripcion = (String)TblMembresia.SelectedRows[0].Cells[2].Value;
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[3].Value;
            preciomes = (float)TblMembresia.SelectedRows[0].Cells[4].Value;
            precioanio = (float)TblMembresia.SelectedRows[0].Cells[5].Value;
            preciodia = (float)TblMembresia.SelectedRows[0].Cells[6].Value;

            LblMem.Text = descripcion;
            LblIdMembresia.Text = IDMembresia.ToString();


            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(7);
            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
        }

        private void Rbd15dias_MouseClick(object sender, MouseEventArgs e)
        {
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(15);
            IDMembresia = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
            preciosemana = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            descripcion = (String)TblMembresia.SelectedRows[0].Cells[2].Value;
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[3].Value;
            preciomes = (float)TblMembresia.SelectedRows[0].Cells[4].Value;
            precioanio = (float)TblMembresia.SelectedRows[0].Cells[5].Value;
            preciodia = (float)TblMembresia.SelectedRows[0].Cells[6].Value;

            LblMem.Text = descripcion;
            LblIdMembresia.Text = IDMembresia.ToString();

            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
           
          
        }

        private void RbdMes_MouseClick(object sender, MouseEventArgs e)
        {
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(15);
            IDMembresia = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
            preciosemana = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            descripcion = (String)TblMembresia.SelectedRows[0].Cells[2].Value;
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[3].Value;
            preciomes = (float)TblMembresia.SelectedRows[0].Cells[4].Value;
            precioanio = (float)TblMembresia.SelectedRows[0].Cells[5].Value;
            preciodia = (float)TblMembresia.SelectedRows[0].Cells[6].Value;

            LblMem.Text = descripcion;
            LblIdMembresia.Text = IDMembresia.ToString();


            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
           
            DtpFechaFin.Value = DtpFechaInicio.Value.AddMonths(1);
        }

        private void RbdAnio_MouseClick(object sender, MouseEventArgs e)
        {
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(15);
            IDMembresia = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
            preciosemana = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            descripcion = (String)TblMembresia.SelectedRows[0].Cells[2].Value;
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[3].Value;
            preciomes = (float)TblMembresia.SelectedRows[0].Cells[4].Value;
            precioanio = (float)TblMembresia.SelectedRows[0].Cells[5].Value;
            preciodia = (float)TblMembresia.SelectedRows[0].Cells[6].Value;

            LblMem.Text = descripcion;
            LblIdMembresia.Text = IDMembresia.ToString();


            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
            
            DtpFechaFin.Value = DtpFechaInicio.Value.AddYears(1);
        }

        private void RbdDia_MouseClick(object sender, MouseEventArgs e)
        {
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(15);
            IDMembresia = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
            preciosemana = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            descripcion = (String)TblMembresia.SelectedRows[0].Cells[2].Value;
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[3].Value;
            preciomes = (float)TblMembresia.SelectedRows[0].Cells[4].Value;
            precioanio = (float)TblMembresia.SelectedRows[0].Cells[5].Value;
            preciodia = (float)TblMembresia.SelectedRows[0].Cells[6].Value;

            LblMem.Text = descripcion;
            LblIdMembresia.Text = IDMembresia.ToString();

            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(1);

            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
        }

        private void FRMVentaMembresia_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void RbdDia_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechaFin.Value = DateTime.Today.AddDays(15);




            DtpFechaInicio.Text = DateTime.Now.ToShortDateString();
            LblAdvertencia.Visible = false;
            LblMem.Text = descripcion;

            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
           
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(1);

        }

        public void actualizar()
        {
            

         
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TblClientes.DataSource = mControlCliente.consultarClientes3(TxtCliente.Text,"activo").Tables[0];
            
        }

        private void TxtMembresia_KeyPress(object sender, KeyPressEventArgs e)
        {
            TblMembresia.DataSource = mControlmembresia.consultarMembresia2(TxtMembresia.Text).Tables[0];
        }

        private void TxtDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (TxtDinero.Text.Length == 0)
            {
                mVALIDACION.solonumeros2(e);
            }
            else if (TxtDinero.Text.Length >= 12)
            {
                mVALIDACION.soloborrar(e);
            }
            else
            {
                mVALIDACION.solonumeros(e);
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (RbdSemana.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(7);
            }
            if (Rbd15dias.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(15);
            }
            if (RbdMes.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddMonths(1);
            }
            if (RbdDia.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(1);
            }
            if (RbdAnio.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddYears(1);
            }
            
            if (DtpFechaInicio.Value < DtpFechaVenta.Value)
            {
                
                    LblAdvertencia.Visible = true;
                    BtnAceptar.Enabled = false;
                
                
            }
            else
            {
                if (LblIdMembresia.Text == "0")
                {

                    BtnAceptar.Enabled = false;
                }
                 if(LblIdCliente.Text == "0")
                {
                    BtnAceptar.Enabled = false;
                }

                if(LblIdMembresia.Text != "0" && LblIdCliente.Text!="0")
                {
                    
                    BtnAceptar.Enabled = true;

                }
                LblAdvertencia.Visible = false;

            }

            //if (LblIdMembresia.Text == "0")
            //{

            //    BtnAceptar.Enabled = false;
            //}
            //if (LblIdCliente.Text == "0")
            //{
            //    BtnAceptar.Enabled = false;
            //}

            //if (LblIdMembresia.Text != "0" && LblIdCliente.Text != "0")
            //{
                
            //    BtnAceptar.Enabled = true;

            //}



        }

        private void RbdClienteGeneral_CheckedChanged(object sender, EventArgs e)
        {
            LblNombrebuscado.Visible = false;
            TxtCliente.Visible = false;
            TblClientes.Visible = false;
            Rbd15dias.Enabled = false;
            RbdSemana.Enabled = false;
            RbdMes.Enabled = false;
            RbdAnio.Enabled = false;
            RbdDia.Select();
            BtnAceptar.Enabled = true;
            LblNombreCliente.Text = "Cliente General";
            LblApellido.Text = "Cliente General";
            LblIdCliente.Text = "4";
            LblIdCliente.Visible = false;
            DtpFechaInicio.Enabled = false;

            if (LblIdMembresia.Text == "0")
            {
                BtnAceptar.Enabled = false;
            }
        }

        private void Rbd_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechaInicio.Text = DateTime.Now.ToShortDateString();
            DtpFechaInicio.Enabled = true;
            LblNombrebuscado.Visible = true;
            TxtCliente.Visible = true;
            TblClientes.Visible = true;
            Rbd15dias.Enabled = true;
            RbdSemana.Enabled = true;
            RbdMes.Enabled = true;
            RbdAnio.Enabled = true;
            BtnAceptar.Enabled = false;
            LblIdCliente.Visible = true;
            LblNombreCliente.Text = "Selecione Cliente";
            LblApellido.Text = "Selecione Cliente";
            LblIdCliente.Text = "0";

        }

        private void TblClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtDinero_KeyDown(object sender, KeyEventArgs e)
        {
            bool paste = (Convert.ToInt32(e.KeyData) == (Convert.ToInt32(Keys.Control) | Convert.ToInt32(Keys.V)));

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                MessageBox.Show("No se puede utilizar Control+V");
                TxtDinero.Text = "";
            }
        }

        private void RbdMes_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechaInicio.Text = DateTime.Now.ToShortDateString();
            LblAdvertencia.Visible = false;
        }

        private void RbdAnio_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechaInicio.Text = DateTime.Now.ToShortDateString();
            LblAdvertencia.Visible = false;
        }

        public void selecionarCliente()
        {
            IDcliente = (int)TblClientes.SelectedRows[0].Cells[0].Value;
            nombre = TblClientes.SelectedRows[0].Cells[1].Value.ToString();
            telefono = TblClientes.SelectedRows[0].Cells[2].Value.ToString();
            apellidos = TblClientes.SelectedRows[0].Cells[3].Value.ToString();

            LblIdCliente.Text = IDcliente.ToString();
            LblNombreCliente.Text = nombre;
            LblApellido.Text = apellidos;

        }
        public bool validar()
        {
            try
            {
                if (float.Parse(TxtDinero.Text) < float.Parse(LblTotal.Text))
                {
                    MessageBox.Show("Dinero insuficiente");
                    return false;
                }
                else
                {
                    try
                    {
                        float ca = float.Parse(TxtDinero.Text);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(this, "Datos de entrad incorrecto");
                        TxtDinero.Text = "";
                        TxtDinero.Focus();
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Formato de cantidad o precio incorrecto");
                return false;
            }
        
        }
    }
}
