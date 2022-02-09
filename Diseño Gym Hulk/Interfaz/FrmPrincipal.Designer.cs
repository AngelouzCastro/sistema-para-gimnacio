namespace Diseño_Gym_Hulk
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnControlCliente = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.sidebarwrapper = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PBminimizar = new System.Windows.Forms.PictureBox();
            this.PBpantalla = new System.Windows.Forms.PictureBox();
            this.PBSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuTop.SuspendLayout();
            this.sidebarwrapper.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBpantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReporte
            // 
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(58, 255);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(110, 66);
            this.BtnReporte.TabIndex = 0;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVenta.Location = new System.Drawing.Point(58, 170);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(119, 50);
            this.BtnVenta.TabIndex = 1;
            this.BtnVenta.Text = "Registrar visita";
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // BtnControlCliente
            // 
            this.BtnControlCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnControlCliente.Location = new System.Drawing.Point(58, 109);
            this.BtnControlCliente.Name = "BtnControlCliente";
            this.BtnControlCliente.Size = new System.Drawing.Size(119, 50);
            this.BtnControlCliente.TabIndex = 2;
            this.BtnControlCliente.Text = "Control de cliente";
            this.BtnControlCliente.UseVisualStyleBackColor = true;
            this.BtnControlCliente.Click += new System.EventHandler(this.BtnControlCliente_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(58, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Control de membresia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.MenuTop.Controls.Add(this.pictureBox3);
            this.MenuTop.Controls.Add(this.PBminimizar);
            this.MenuTop.Controls.Add(this.PBpantalla);
            this.MenuTop.Controls.Add(this.PBSalir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.pictureBox2);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1386, 80);
            this.MenuTop.TabIndex = 5;
            // 
            // sidebarwrapper
            // 
            this.sidebarwrapper.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.sidebarwrapper.Controls.Add(this.flowLayoutPanel1);
            this.sidebarwrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarwrapper.Location = new System.Drawing.Point(0, 80);
            this.sidebarwrapper.Name = "sidebarwrapper";
            this.sidebarwrapper.Size = new System.Drawing.Size(264, 708);
            this.sidebarwrapper.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 617);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(58, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "HULK\'S GYM";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.5F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnReporte, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnVenta, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnControlCliente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 381);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_hulk_50;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_box_50;
            this.pictureBox5.Location = new System.Drawing.Point(3, 59);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_user_male_50;
            this.pictureBox6.Location = new System.Drawing.Point(3, 109);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 50);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_cash_app_50;
            this.pictureBox7.Location = new System.Drawing.Point(3, 170);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_document_50;
            this.pictureBox8.Location = new System.Drawing.Point(3, 255);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(49, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_undelete_50;
            this.pictureBox3.Location = new System.Drawing.Point(1272, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PBminimizar
            // 
            this.PBminimizar.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_share_3_50;
            this.PBminimizar.Location = new System.Drawing.Point(1272, 29);
            this.PBminimizar.Name = "PBminimizar";
            this.PBminimizar.Size = new System.Drawing.Size(30, 30);
            this.PBminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBminimizar.TabIndex = 8;
            this.PBminimizar.TabStop = false;
            this.PBminimizar.Click += new System.EventHandler(this.PBminimizar_Click);
            // 
            // PBpantalla
            // 
            this.PBpantalla.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_sorting_501;
            this.PBpantalla.Location = new System.Drawing.Point(1236, 29);
            this.PBpantalla.Name = "PBpantalla";
            this.PBpantalla.Size = new System.Drawing.Size(30, 30);
            this.PBpantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBpantalla.TabIndex = 7;
            this.PBpantalla.TabStop = false;
            this.PBpantalla.Click += new System.EventHandler(this.PBpantalla_Click);
            // 
            // PBSalir
            // 
            this.PBSalir.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_delete_50;
            this.PBSalir.Location = new System.Drawing.Point(1308, 29);
            this.PBSalir.Name = "PBSalir";
            this.PBSalir.Size = new System.Drawing.Size(30, 30);
            this.PBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSalir.TabIndex = 2;
            this.PBSalir.TabStop = false;
            this.PBSalir.Click += new System.EventHandler(this.PBSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Diseño_Gym_Hulk.Properties.Resources.icons8_menu_50;
            this.pictureBox2.Location = new System.Drawing.Point(12, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(485, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.sidebarwrapper);
            this.Controls.Add(this.MenuTop);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.sidebarwrapper.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBpantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button BtnControlCliente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel sidebarwrapper;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PBSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBminimizar;
        private System.Windows.Forms.PictureBox PBpantalla;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}