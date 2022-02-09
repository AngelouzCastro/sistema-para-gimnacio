namespace Diseño_Gym_Hulk
{
    partial class FrmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TblReporte = new System.Windows.Forms.DataGridView();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFechafin = new System.Windows.Forms.DateTimePicker();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TblReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_home_50;
            this.BtnCerrar.Location = new System.Drawing.Point(55, 350);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(70, 52);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(631, 361);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(29, 20);
            this.LblTotal.TabIndex = 6;
            this.LblTotal.Text = "$0";
            // 
            // TblReporte
            // 
            this.TblReporte.AllowUserToAddRows = false;
            this.TblReporte.AllowUserToDeleteRows = false;
            this.TblReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblReporte.Location = new System.Drawing.Point(55, 73);
            this.TblReporte.Name = "TblReporte";
            this.TblReporte.ReadOnly = true;
            this.TblReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblReporte.Size = new System.Drawing.Size(645, 262);
            this.TblReporte.TabIndex = 7;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaInicio.Location = new System.Drawing.Point(430, 22);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(104, 20);
            this.DtpFechaInicio.TabIndex = 24;
            // 
            // DtpFechafin
            // 
            this.DtpFechafin.CustomFormat = "yyyy/MM/dd";
            this.DtpFechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechafin.Location = new System.Drawing.Point(544, 22);
            this.DtpFechafin.Name = "DtpFechafin";
            this.DtpFechafin.Size = new System.Drawing.Size(85, 20);
            this.DtpFechafin.TabIndex = 25;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_search_50;
            this.BtnActualizar.Location = new System.Drawing.Point(635, 12);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(65, 55);
            this.BtnActualizar.TabIndex = 26;
            this.BtnActualizar.Text = "Filtrar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 426);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.DtpFechafin);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.TblReporte);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporte";
            this.Text = "Centro de Reporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView TblReporte;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechafin;
        private System.Windows.Forms.Button BtnActualizar;
    }
}