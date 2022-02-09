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

    public partial class FrmReporte : Form
    {

        private string fecha_inicio;
        private string fecha_fin;
        private double total = 0;

        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            DtpFechafin.Value = DateTime.Today.AddDays(1);
            fecha_inicio = DtpFechaInicio.Text;
            fecha_fin = DtpFechafin.Text;
                     
            ControlVentas mControlventas = new ControlVentas();
            TblReporte.DataSource = mControlventas.Reporte(fecha_inicio, fecha_fin).Tables[0];
            foreach(DataGridViewRow row in TblReporte.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);

            }
            LblTotal.Text = total.ToString();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            fecha_inicio = DtpFechaInicio.Text;
            fecha_fin = DtpFechafin.Text;
            ControlVentas mControlventas = new ControlVentas();
            TblReporte.DataSource = mControlventas.Reporte(fecha_inicio, fecha_fin).Tables[0];
            foreach (DataGridViewRow row in TblReporte.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);

            }
            LblTotal.Text = total.ToString();
            total = 0;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
