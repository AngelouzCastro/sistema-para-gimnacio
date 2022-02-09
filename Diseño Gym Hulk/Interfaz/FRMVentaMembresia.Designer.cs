namespace Diseño_Gym_Hulk
{
    partial class FRMVentaMembresia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMVentaMembresia));
            this.RbdSemana = new System.Windows.Forms.RadioButton();
            this.Rbd15dias = new System.Windows.Forms.RadioButton();
            this.RbdMes = new System.Windows.Forms.RadioButton();
            this.RbdAnio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RbdDia = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TblClientes = new System.Windows.Forms.DataGridView();
            this.TblMembresia = new System.Windows.Forms.DataGridView();
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.LblMem = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtMembresia = new System.Windows.Forms.TextBox();
            this.LblIdMembresia = new System.Windows.Forms.Label();
            this.TxtDinero = new System.Windows.Forms.TextBox();
            this.LblNombrebuscado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.DtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.RbdClientereg = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbdClienteGeneral = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.LblAdvertencia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TblClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMembresia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RbdSemana
            // 
            this.RbdSemana.AutoSize = true;
            this.RbdSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdSemana.Location = new System.Drawing.Point(15, 37);
            this.RbdSemana.Name = "RbdSemana";
            this.RbdSemana.Size = new System.Drawing.Size(70, 17);
            this.RbdSemana.TabIndex = 2;
            this.RbdSemana.TabStop = true;
            this.RbdSemana.Text = "Semana";
            this.RbdSemana.UseVisualStyleBackColor = true;
            this.RbdSemana.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.RbdSemana.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbdSemana_MouseClick);
            // 
            // Rbd15dias
            // 
            this.Rbd15dias.AutoSize = true;
            this.Rbd15dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbd15dias.Location = new System.Drawing.Point(15, 60);
            this.Rbd15dias.Name = "Rbd15dias";
            this.Rbd15dias.Size = new System.Drawing.Size(68, 17);
            this.Rbd15dias.TabIndex = 3;
            this.Rbd15dias.TabStop = true;
            this.Rbd15dias.Text = "15 días";
            this.Rbd15dias.UseVisualStyleBackColor = true;
            this.Rbd15dias.CheckedChanged += new System.EventHandler(this.Rbd15dias_CheckedChanged);
            this.Rbd15dias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Rbd15dias_MouseClick);
            // 
            // RbdMes
            // 
            this.RbdMes.AutoSize = true;
            this.RbdMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdMes.Location = new System.Drawing.Point(109, 14);
            this.RbdMes.Name = "RbdMes";
            this.RbdMes.Size = new System.Drawing.Size(48, 17);
            this.RbdMes.TabIndex = 4;
            this.RbdMes.TabStop = true;
            this.RbdMes.Text = "Mes";
            this.RbdMes.UseVisualStyleBackColor = true;
            this.RbdMes.CheckedChanged += new System.EventHandler(this.RbdMes_CheckedChanged);
            this.RbdMes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbdMes_MouseClick);
            // 
            // RbdAnio
            // 
            this.RbdAnio.AutoSize = true;
            this.RbdAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdAnio.Location = new System.Drawing.Point(109, 37);
            this.RbdAnio.Name = "RbdAnio";
            this.RbdAnio.Size = new System.Drawing.Size(47, 17);
            this.RbdAnio.TabIndex = 5;
            this.RbdAnio.TabStop = true;
            this.RbdAnio.Text = "Año";
            this.RbdAnio.UseVisualStyleBackColor = true;
            this.RbdAnio.CheckedChanged += new System.EventHandler(this.RbdAnio_CheckedChanged);
            this.RbdAnio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbdAnio_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione fecha de inicio: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(424, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total:  $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selecione catidad de tiempo";
            // 
            // RbdDia
            // 
            this.RbdDia.AutoSize = true;
            this.RbdDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdDia.Location = new System.Drawing.Point(15, 14);
            this.RbdDia.Name = "RbdDia";
            this.RbdDia.Size = new System.Drawing.Size(46, 17);
            this.RbdDia.TabIndex = 14;
            this.RbdDia.TabStop = true;
            this.RbdDia.Text = "Día";
            this.RbdDia.UseVisualStyleBackColor = true;
            this.RbdDia.CheckedChanged += new System.EventHandler(this.RbdDia_CheckedChanged);
            this.RbdDia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbdDia_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo de Membresia:";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCliente.Location = new System.Drawing.Point(569, 77);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(125, 15);
            this.LblNombreCliente.TabIndex = 19;
            this.LblNombreCliente.Text = "Seleccione cliente";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(569, 99);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(125, 15);
            this.LblApellido.TabIndex = 20;
            this.LblApellido.Text = "Seleccione cliente";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(559, 408);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(32, 33);
            this.LblTotal.TabIndex = 22;
            this.LblTotal.Text = "0";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaInicio.Location = new System.Drawing.Point(437, 313);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaInicio.TabIndex = 23;
            this.DtpFechaInicio.ValueChanged += new System.EventHandler(this.DtpFechaInicio_ValueChanged);
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaFin.Enabled = false;
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaFin.Location = new System.Drawing.Point(437, 374);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaFin.TabIndex = 24;
            // 
            // TblClientes
            // 
            this.TblClientes.AllowUserToAddRows = false;
            this.TblClientes.AllowUserToDeleteRows = false;
            this.TblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblClientes.Location = new System.Drawing.Point(12, 86);
            this.TblClientes.Name = "TblClientes";
            this.TblClientes.ReadOnly = true;
            this.TblClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblClientes.Size = new System.Drawing.Size(384, 150);
            this.TblClientes.TabIndex = 25;
            this.TblClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblClientes_CellContentClick);
            this.TblClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TblClientes_MouseClick);
            // 
            // TblMembresia
            // 
            this.TblMembresia.AllowUserToAddRows = false;
            this.TblMembresia.AllowUserToDeleteRows = false;
            this.TblMembresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblMembresia.Location = new System.Drawing.Point(12, 291);
            this.TblMembresia.Name = "TblMembresia";
            this.TblMembresia.ReadOnly = true;
            this.TblMembresia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblMembresia.Size = new System.Drawing.Size(384, 150);
            this.TblMembresia.TabIndex = 26;
            this.TblMembresia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblMembresia_CellContentClick);
            this.TblMembresia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TblMembresia_MouseClick);
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdCliente.Location = new System.Drawing.Point(569, 53);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(15, 15);
            this.LblIdCliente.TabIndex = 27;
            this.LblIdCliente.Text = "0";
            // 
            // LblMem
            // 
            this.LblMem.AutoSize = true;
            this.LblMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMem.Location = new System.Drawing.Point(569, 153);
            this.LblMem.Name = "LblMem";
            this.LblMem.Size = new System.Drawing.Size(154, 15);
            this.LblMem.TabIndex = 28;
            this.LblMem.Text = "Seleccione membresia";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(143, 60);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(253, 20);
            this.TxtCliente.TabIndex = 29;
            this.TxtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TxtMembresia
            // 
            this.TxtMembresia.Location = new System.Drawing.Point(143, 254);
            this.TxtMembresia.Name = "TxtMembresia";
            this.TxtMembresia.Size = new System.Drawing.Size(253, 20);
            this.TxtMembresia.TabIndex = 30;
            this.TxtMembresia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMembresia_KeyPress);
            // 
            // LblIdMembresia
            // 
            this.LblIdMembresia.AutoSize = true;
            this.LblIdMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMembresia.Location = new System.Drawing.Point(569, 127);
            this.LblIdMembresia.Name = "LblIdMembresia";
            this.LblIdMembresia.Size = new System.Drawing.Size(15, 15);
            this.LblIdMembresia.TabIndex = 35;
            this.LblIdMembresia.Text = "0";
            // 
            // TxtDinero
            // 
            this.TxtDinero.Location = new System.Drawing.Point(441, 469);
            this.TxtDinero.Name = "TxtDinero";
            this.TxtDinero.Size = new System.Drawing.Size(100, 20);
            this.TxtDinero.TabIndex = 36;
            this.TxtDinero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDinero_KeyDown);
            this.TxtDinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDinero_KeyPress);
            // 
            // LblNombrebuscado
            // 
            this.LblNombrebuscado.AutoSize = true;
            this.LblNombrebuscado.Location = new System.Drawing.Point(41, 63);
            this.LblNombrebuscado.Name = "LblNombrebuscado";
            this.LblNombrebuscado.Size = new System.Drawing.Size(96, 13);
            this.LblNombrebuscado.TabIndex = 37;
            this.LblNombrebuscado.Text = "Nombre de cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Nombre membresia:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_calendar_50;
            this.pictureBox1.Location = new System.Drawing.Point(627, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_home_50;
            this.BtnCancelar.Location = new System.Drawing.Point(30, 455);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(65, 65);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_cash_app_50;
            this.BtnAceptar.Location = new System.Drawing.Point(603, 455);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 47);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Pagar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // DtpFechaVenta
            // 
            this.DtpFechaVenta.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaVenta.Enabled = false;
            this.DtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaVenta.Location = new System.Drawing.Point(152, 482);
            this.DtpFechaVenta.Name = "DtpFechaVenta";
            this.DtpFechaVenta.Size = new System.Drawing.Size(82, 20);
            this.DtpFechaVenta.TabIndex = 40;
            this.DtpFechaVenta.Visible = false;
            // 
            // RbdClientereg
            // 
            this.RbdClientereg.AutoSize = true;
            this.RbdClientereg.Location = new System.Drawing.Point(6, 19);
            this.RbdClientereg.Name = "RbdClientereg";
            this.RbdClientereg.Size = new System.Drawing.Size(106, 17);
            this.RbdClientereg.TabIndex = 41;
            this.RbdClientereg.TabStop = true;
            this.RbdClientereg.Text = "Cliente registrado";
            this.RbdClientereg.UseVisualStyleBackColor = true;
            this.RbdClientereg.CheckedChanged += new System.EventHandler(this.Rbd_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbdDia);
            this.groupBox1.Controls.Add(this.RbdAnio);
            this.groupBox1.Controls.Add(this.RbdMes);
            this.groupBox1.Controls.Add(this.Rbd15dias);
            this.groupBox1.Controls.Add(this.RbdSemana);
            this.groupBox1.Location = new System.Drawing.Point(430, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 86);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbdClienteGeneral);
            this.groupBox2.Controls.Add(this.RbdClientereg);
            this.groupBox2.Location = new System.Drawing.Point(44, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 51);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de cliente";
            // 
            // RbdClienteGeneral
            // 
            this.RbdClienteGeneral.AutoSize = true;
            this.RbdClienteGeneral.Location = new System.Drawing.Point(124, 19);
            this.RbdClienteGeneral.Name = "RbdClienteGeneral";
            this.RbdClienteGeneral.Size = new System.Drawing.Size(95, 17);
            this.RbdClienteGeneral.TabIndex = 42;
            this.RbdClienteGeneral.TabStop = true;
            this.RbdClienteGeneral.Text = "Cliente general";
            this.RbdClienteGeneral.UseVisualStyleBackColor = true;
            this.RbdClienteGeneral.CheckedChanged += new System.EventHandler(this.RbdClienteGeneral_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Detalles:";
            // 
            // LblAdvertencia
            // 
            this.LblAdvertencia.AutoSize = true;
            this.LblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LblAdvertencia.Location = new System.Drawing.Point(643, 316);
            this.LblAdvertencia.Name = "LblAdvertencia";
            this.LblAdvertencia.Size = new System.Drawing.Size(80, 13);
            this.LblAdvertencia.TabIndex = 45;
            this.LblAdvertencia.Text = "Fecha  Invalida";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(435, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "ID de Membresia:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "fecha de la venta:";
            // 
            // FRMVentaMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 538);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblAdvertencia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtpFechaVenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblNombrebuscado);
            this.Controls.Add(this.TxtDinero);
            this.Controls.Add(this.LblIdMembresia);
            this.Controls.Add(this.TxtMembresia);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.LblMem);
            this.Controls.Add(this.LblIdCliente);
            this.Controls.Add(this.TblMembresia);
            this.Controls.Add(this.TblClientes);
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombreCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMVentaMembresia";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FRMVentaMembresia_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FRMVentaMembresia_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.TblClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMembresia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RbdSemana;
        private System.Windows.Forms.RadioButton Rbd15dias;
        private System.Windows.Forms.RadioButton RbdMes;
        private System.Windows.Forms.RadioButton RbdAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RbdDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.DataGridView TblClientes;
        private System.Windows.Forms.DataGridView TblMembresia;
        private System.Windows.Forms.Label LblIdCliente;
        private System.Windows.Forms.Label LblMem;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtMembresia;
        private System.Windows.Forms.Label LblIdMembresia;
        private System.Windows.Forms.TextBox TxtDinero;
        private System.Windows.Forms.Label LblNombrebuscado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtpFechaVenta;
        private System.Windows.Forms.RadioButton RbdClientereg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbdClienteGeneral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblAdvertencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

