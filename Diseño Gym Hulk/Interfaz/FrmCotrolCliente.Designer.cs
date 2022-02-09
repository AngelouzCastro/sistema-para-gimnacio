namespace Diseño_Gym_Hulk
{
    partial class FrmCotrolCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCotrolCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.TblClientes = new System.Windows.Forms.DataGridView();
            this.BtnAltaCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBajaCliente = new System.Windows.Forms.Button();
            this.BtnVerCliente = new System.Windows.Forms.Button();
            this.BtnEditarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbdActivo = new System.Windows.Forms.RadioButton();
            this.RbdInactivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TblClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de cliente:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(138, 42);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(288, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // TblClientes
            // 
            this.TblClientes.AllowUserToAddRows = false;
            this.TblClientes.AllowUserToDeleteRows = false;
            this.TblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblClientes.Location = new System.Drawing.Point(42, 109);
            this.TblClientes.Name = "TblClientes";
            this.TblClientes.ReadOnly = true;
            this.TblClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblClientes.Size = new System.Drawing.Size(384, 150);
            this.TblClientes.TabIndex = 2;
            this.TblClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblClientes_CellContentClick);
            this.TblClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TblMembresias_MouseClick);
            // 
            // BtnAltaCliente
            // 
            this.BtnAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAltaCliente.Location = new System.Drawing.Point(538, 109);
            this.BtnAltaCliente.Name = "BtnAltaCliente";
            this.BtnAltaCliente.Size = new System.Drawing.Size(75, 167);
            this.BtnAltaCliente.TabIndex = 6;
            this.BtnAltaCliente.Text = "Alta de cliente";
            this.BtnAltaCliente.UseVisualStyleBackColor = true;
            this.BtnAltaCliente.Click += new System.EventHandler(this.BtnAltaCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_plus_501;
            this.pictureBox1.Location = new System.Drawing.Point(552, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackgroundImage = global::Diseño_Gym_Hulk.Properties.Resources.icons8_restart_50;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(455, 28);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(48, 47);
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "Actualizar tabla";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackgroundImage = global::Diseño_Gym_Hulk.Properties.Resources.icons8_home_50;
            this.BtnCerrar.Location = new System.Drawing.Point(42, 266);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(55, 49);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnBajaCliente
            // 
            this.BtnBajaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBajaCliente.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_remove_50;
            this.BtnBajaCliente.Location = new System.Drawing.Point(455, 222);
            this.BtnBajaCliente.Name = "BtnBajaCliente";
            this.BtnBajaCliente.Size = new System.Drawing.Size(58, 54);
            this.BtnBajaCliente.TabIndex = 5;
            this.BtnBajaCliente.Text = "Baja de cliente";
            this.BtnBajaCliente.UseVisualStyleBackColor = true;
            this.BtnBajaCliente.Click += new System.EventHandler(this.BtnBajaCliente_Click);
            // 
            // BtnVerCliente
            // 
            this.BtnVerCliente.BackgroundImage = global::Diseño_Gym_Hulk.Properties.Resources.icons8_complaint_50;
            this.BtnVerCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerCliente.Location = new System.Drawing.Point(455, 109);
            this.BtnVerCliente.Name = "BtnVerCliente";
            this.BtnVerCliente.Size = new System.Drawing.Size(58, 50);
            this.BtnVerCliente.TabIndex = 4;
            this.BtnVerCliente.Text = "Ver Cliente";
            this.BtnVerCliente.UseVisualStyleBackColor = true;
            this.BtnVerCliente.Click += new System.EventHandler(this.BtnVerCliente_Click);
            // 
            // BtnEditarCliente
            // 
            this.BtnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarCliente.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_edit_50;
            this.BtnEditarCliente.Location = new System.Drawing.Point(455, 165);
            this.BtnEditarCliente.Name = "BtnEditarCliente";
            this.BtnEditarCliente.Size = new System.Drawing.Size(58, 51);
            this.BtnEditarCliente.TabIndex = 3;
            this.BtnEditarCliente.Text = "Editar Cliente";
            this.BtnEditarCliente.UseVisualStyleBackColor = true;
            this.BtnEditarCliente.Click += new System.EventHandler(this.BtnEditarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbdInactivo);
            this.groupBox1.Controls.Add(this.RbdActivo);
            this.groupBox1.Location = new System.Drawing.Point(538, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de cliente";
            // 
            // RbdActivo
            // 
            this.RbdActivo.AutoSize = true;
            this.RbdActivo.Location = new System.Drawing.Point(7, 20);
            this.RbdActivo.Name = "RbdActivo";
            this.RbdActivo.Size = new System.Drawing.Size(55, 17);
            this.RbdActivo.TabIndex = 0;
            this.RbdActivo.TabStop = true;
            this.RbdActivo.Text = "Activo";
            this.RbdActivo.UseVisualStyleBackColor = true;
            this.RbdActivo.CheckedChanged += new System.EventHandler(this.RbdActivo_CheckedChanged);
            this.RbdActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RbdActivo_KeyPress);
            // 
            // RbdInactivo
            // 
            this.RbdInactivo.AutoSize = true;
            this.RbdInactivo.Location = new System.Drawing.Point(7, 44);
            this.RbdInactivo.Name = "RbdInactivo";
            this.RbdInactivo.Size = new System.Drawing.Size(63, 17);
            this.RbdInactivo.TabIndex = 1;
            this.RbdInactivo.TabStop = true;
            this.RbdInactivo.Text = "Inactivo";
            this.RbdInactivo.UseVisualStyleBackColor = true;
            this.RbdInactivo.CheckedChanged += new System.EventHandler(this.RbdInactivo_CheckedChanged);
            // 
            // FrmCotrolCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 327);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAltaCliente);
            this.Controls.Add(this.BtnBajaCliente);
            this.Controls.Add(this.BtnVerCliente);
            this.Controls.Add(this.BtnEditarCliente);
            this.Controls.Add(this.TblClientes);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCotrolCliente";
            this.Text = "Cotrol de Clientes";
            this.Load += new System.EventHandler(this.FrmCotrolCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView TblClientes;
        private System.Windows.Forms.Button BtnEditarCliente;
        private System.Windows.Forms.Button BtnBajaCliente;
        private System.Windows.Forms.Button BtnAltaCliente;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnVerCliente;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbdInactivo;
        private System.Windows.Forms.RadioButton RbdActivo;
    }
}