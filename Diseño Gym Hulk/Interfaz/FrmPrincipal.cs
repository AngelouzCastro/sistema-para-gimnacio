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
    public partial class FrmPrincipal : Form
    {
       
        
        FrmControlMembresia mfrmControlMembresia;
        FrmCotrolCliente mfrmCotrolCliente;
        FrmReporte mfrmReporte;
        FRMVentaMembresia mFRMVentaMembresia;
        public FrmPrincipal()
        {
            InitializeComponent();
            mfrmControlMembresia = new FrmControlMembresia();
            mfrmCotrolCliente = new FrmCotrolCliente();
            mFRMVentaMembresia = new FRMVentaMembresia();
            mfrmReporte = new FrmReporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mfrmReporte.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mfrmControlMembresia.ShowDialog();
        }

        private void BtnControlCliente_Click(object sender, EventArgs e)
        {
            mfrmCotrolCliente.ShowDialog();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            mFRMVentaMembresia.ShowDialog();
        }

        private void PBminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PBminimizar.Visible = false;
            pictureBox3.Visible = true;
        }

        private void PBpantalla_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void PBSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictureBox3.Visible = false;
            PBminimizar.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            mfrmControlMembresia.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            mfrmCotrolCliente.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mFRMVentaMembresia.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            mfrmReporte.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             }
    }
}
