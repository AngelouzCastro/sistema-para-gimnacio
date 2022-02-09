namespace Diseño_Gym_Hulk
{
    partial class FrmControlMembresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlMembresia));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMembresia = new System.Windows.Forms.TextBox();
            this.TblMembresia = new System.Windows.Forms.DataGridView();
            this.BtnAgregarMembresia = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificarMembresia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TblMembresia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre membresia:";
            // 
            // TxtMembresia
            // 
            this.TxtMembresia.Location = new System.Drawing.Point(130, 35);
            this.TxtMembresia.Name = "TxtMembresia";
            this.TxtMembresia.Size = new System.Drawing.Size(272, 20);
            this.TxtMembresia.TabIndex = 1;
            this.TxtMembresia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TblMembresia
            // 
            this.TblMembresia.AllowUserToAddRows = false;
            this.TblMembresia.AllowUserToDeleteRows = false;
            this.TblMembresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblMembresia.Location = new System.Drawing.Point(27, 78);
            this.TblMembresia.Name = "TblMembresia";
            this.TblMembresia.ReadOnly = true;
            this.TblMembresia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblMembresia.Size = new System.Drawing.Size(368, 150);
            this.TblMembresia.TabIndex = 2;
            this.TblMembresia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblMembresia_CellContentClick);
            this.TblMembresia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // BtnAgregarMembresia
            // 
            this.BtnAgregarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarMembresia.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_plus_501;
            this.BtnAgregarMembresia.Location = new System.Drawing.Point(430, 78);
            this.BtnAgregarMembresia.Name = "BtnAgregarMembresia";
            this.BtnAgregarMembresia.Size = new System.Drawing.Size(71, 63);
            this.BtnAgregarMembresia.TabIndex = 5;
            this.BtnAgregarMembresia.Text = "Agregar nueva membresia";
            this.BtnAgregarMembresia.UseVisualStyleBackColor = true;
            this.BtnAgregarMembresia.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_restart_50;
            this.BtnActualizar.Location = new System.Drawing.Point(431, 23);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(50, 49);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackgroundImage = global::Diseño_Gym_Hulk.Properties.Resources.icons8_home_50;
            this.BtnCerrar.Location = new System.Drawing.Point(27, 245);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(50, 53);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_remove_50;
            this.BtnEliminar.Location = new System.Drawing.Point(430, 200);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(71, 53);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnModificarMembresia
            // 
            this.BtnModificarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarMembresia.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_edit_50;
            this.BtnModificarMembresia.Location = new System.Drawing.Point(431, 147);
            this.BtnModificarMembresia.Name = "BtnModificarMembresia";
            this.BtnModificarMembresia.Size = new System.Drawing.Size(70, 47);
            this.BtnModificarMembresia.TabIndex = 3;
            this.BtnModificarMembresia.Text = "Modificar";
            this.BtnModificarMembresia.UseVisualStyleBackColor = true;
            this.BtnModificarMembresia.Click += new System.EventHandler(this.BtnModificarMembresia_Click);
            // 
            // FrmControlMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 348);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregarMembresia);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificarMembresia);
            this.Controls.Add(this.TblMembresia);
            this.Controls.Add(this.TxtMembresia);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmControlMembresia";
            this.Text = "Control  Membresia";
            this.Load += new System.EventHandler(this.FrmControlMembresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblMembresia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMembresia;
        private System.Windows.Forms.DataGridView TblMembresia;
        private System.Windows.Forms.Button BtnModificarMembresia;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregarMembresia;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnActualizar;
    }
}