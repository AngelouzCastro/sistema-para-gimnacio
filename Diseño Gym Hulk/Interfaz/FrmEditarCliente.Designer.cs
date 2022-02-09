namespace Diseño_Gym_Hulk
{
    partial class FrmEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCliente));
            this.Txttelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtapellidos = new System.Windows.Forms.TextBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbdInactivo = new System.Windows.Forms.RadioButton();
            this.RbdActivo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txttelefono
            // 
            this.Txttelefono.Location = new System.Drawing.Point(100, 110);
            this.Txttelefono.Name = "Txttelefono";
            this.Txttelefono.Size = new System.Drawing.Size(126, 20);
            this.Txttelefono.TabIndex = 18;
            this.Txttelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttelefono_KeyDown);
            this.Txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefono:";
            // 
            // Txtapellidos
            // 
            this.Txtapellidos.Location = new System.Drawing.Point(100, 84);
            this.Txtapellidos.Name = "Txtapellidos";
            this.Txtapellidos.Size = new System.Drawing.Size(126, 20);
            this.Txtapellidos.TabIndex = 16;
            this.Txtapellidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtapellidos_KeyDown);
            this.Txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtapellidos_KeyPress);
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(100, 54);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(126, 20);
            this.Txtnombre.TabIndex = 15;
            this.Txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyDown);
            this.Txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre(s): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número de cliente:";
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.Location = new System.Drawing.Point(148, 24);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(23, 13);
            this.LblIdCliente.TabIndex = 24;
            this.LblIdCliente.Text = "null";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_checkmark_50;
            this.BtnGuardar.Location = new System.Drawing.Point(160, 225);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(66, 50);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_delete_50;
            this.BtnCancelar.Location = new System.Drawing.Point(79, 225);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(66, 52);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbdInactivo);
            this.groupBox1.Controls.Add(this.RbdActivo);
            this.groupBox1.Location = new System.Drawing.Point(47, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 67);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de cliente";
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
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblIdCliente);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.Txttelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtapellidos);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarCliente";
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox Txttelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtapellidos;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIdCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbdInactivo;
        private System.Windows.Forms.RadioButton RbdActivo;
    }
}