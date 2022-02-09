namespace Diseño_Gym_Hulk
{
    partial class FrmCliente_Membresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente_Membresia));
            this.button1 = new System.Windows.Forms.Button();
            this.TbLVerCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdClientev = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtpFechaActual = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TbLVerCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Diseño_Gym_Hulk.Properties.Resources.icons8_home_50;
            this.button1.Location = new System.Drawing.Point(50, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 51);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbLVerCliente
            // 
            this.TbLVerCliente.AllowUserToAddRows = false;
            this.TbLVerCliente.AllowUserToDeleteRows = false;
            this.TbLVerCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbLVerCliente.Location = new System.Drawing.Point(50, 36);
            this.TbLVerCliente.Name = "TbLVerCliente";
            this.TbLVerCliente.ReadOnly = true;
            this.TbLVerCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TbLVerCliente.Size = new System.Drawing.Size(563, 105);
            this.TbLVerCliente.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número de cliente:";
            // 
            // LblIdClientev
            // 
            this.LblIdClientev.AutoSize = true;
            this.LblIdClientev.Location = new System.Drawing.Point(152, 17);
            this.LblIdClientev.Name = "LblIdClientev";
            this.LblIdClientev.Size = new System.Drawing.Size(13, 13);
            this.LblIdClientev.TabIndex = 19;
            this.LblIdClientev.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_hulk_50;
            this.pictureBox1.Location = new System.Drawing.Point(543, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // DtpFechaActual
            // 
            this.DtpFechaActual.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaActual.Location = new System.Drawing.Point(295, 10);
            this.DtpFechaActual.Name = "DtpFechaActual";
            this.DtpFechaActual.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaActual.TabIndex = 27;
            // 
            // FrmCliente_Membresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 256);
            this.Controls.Add(this.DtpFechaActual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblIdClientev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbLVerCliente);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente_Membresia";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FrmCliente_Membresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbLVerCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TbLVerCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIdClientev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtpFechaActual;
    }
}