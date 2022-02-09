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
    public partial class FrmControlMembresia : Form
    {
        FrmAgregarMembresia mFrmAgregarMembresia;
        FrmEditarMembresia mFrmEditarMembresia;
        ControlMembresia mControlMembresia2;
        private int ID;
        private float preciosemana;
        private String descripcion;
        private float preciodia;
        private float precio15dias;
        private float preciomes;
        private float precioanio;
        public FrmControlMembresia()
        {
            InitializeComponent();
            mFrmAgregarMembresia = new FrmAgregarMembresia();
            mFrmEditarMembresia = new FrmEditarMembresia();
            ID = 0;
            BtnActualizar.Visible = false;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Membresia mMembresia = new Membresia();
                int ID = (int)TblMembresia.SelectedRows[0].Cells[0].Value;

                ControlMembresia mControlMembresia = new ControlMembresia();
                mControlMembresia.eliminarMembresia(ID);
                MessageBox.Show("Paquete de membresia eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar ");
            }
            actualizartabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mFrmAgregarMembresia.ShowDialog();
            //BtnActualizar.Visible = true;
            actualizartabla();
        }

        private void BtnModificarMembresia_Click(object sender, EventArgs e)
        {
            mFrmEditarMembresia.ShowDialog();
            //BtnActualizar.Visible = true;
            //BtnModificarMembresia.Visible = false;
            actualizartabla();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ID = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
            preciosemana = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            descripcion = (String)TblMembresia.SelectedRows[0].Cells[2].Value;
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[3].Value; 
            preciomes = (float)TblMembresia.SelectedRows[0].Cells[4].Value;
            precioanio = (float)TblMembresia.SelectedRows[0].Cells[5].Value;
            preciodia = (float)TblMembresia.SelectedRows[0].Cells[6].Value;
            

            mFrmEditarMembresia.Id = ID;
            mFrmEditarMembresia.Preciosemana = preciosemana;
            mFrmEditarMembresia.Descripcion = descripcion;
            mFrmEditarMembresia.Precio15dias = precio15dias;
            mFrmEditarMembresia.Preciomes = preciomes;
            mFrmEditarMembresia.Precioanio = precioanio;
            mFrmEditarMembresia.Preciodia = preciodia;

            BtnEliminar.Enabled = true;
            BtnModificarMembresia.Enabled = true;
        }
      

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmControlMembresia_Load(object sender, EventArgs e)
        {
            ControlMembresia mControlMembresia = new ControlMembresia();
            TblMembresia.DataSource = mControlMembresia.consultarMembresias().Tables[0];
            BtnModificarMembresia.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnActualizar.Visible = false;
            BtnEliminar.Visible = false;
        }
        public void actualizartabla()
        {
            ControlMembresia mControlMembresia = new ControlMembresia();
            TblMembresia.DataSource = mControlMembresia.consultarMembresias().Tables[0];

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlMembresia mControlMembresia = new ControlMembresia();
            TblMembresia.DataSource = mControlMembresia.consultarMembresia2(TxtMembresia.Text).Tables[0];
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            actualizartabla();
            BtnActualizar.Visible = false;
            BtnModificarMembresia.Visible = true;

        }

        private void TblMembresia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
