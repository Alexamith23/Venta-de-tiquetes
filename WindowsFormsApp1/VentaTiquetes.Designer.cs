namespace WindowsFormsApp1
{
    partial class VentaTiquetes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumTiq = new System.Windows.Forms.TextBox();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.txtNumEqui = new System.Windows.Forms.TextBox();
            this.lblNumEqui = new System.Windows.Forms.Label();
            this.cbxTerSal = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.chkEquipaje = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInternacional = new System.Windows.Forms.Button();
            this.tdUni = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdUni)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(620, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 282);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Tiquete:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "#Asiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(266, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(510, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lugar Salida:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(539, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Destino:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Equipaje:";
            // 
            // txtNumTiq
            // 
            this.txtNumTiq.Location = new System.Drawing.Point(333, 375);
            this.txtNumTiq.Name = "txtNumTiq";
            this.txtNumTiq.ReadOnly = true;
            this.txtNumTiq.Size = new System.Drawing.Size(140, 20);
            this.txtNumTiq.TabIndex = 9;
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(120, 331);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.ReadOnly = true;
            this.txtAsiento.Size = new System.Drawing.Size(98, 20);
            this.txtAsiento.TabIndex = 11;
            // 
            // txtNumEqui
            // 
            this.txtNumEqui.Location = new System.Drawing.Point(120, 410);
            this.txtNumEqui.Name = "txtNumEqui";
            this.txtNumEqui.ReadOnly = true;
            this.txtNumEqui.Size = new System.Drawing.Size(98, 20);
            this.txtNumEqui.TabIndex = 16;
            // 
            // lblNumEqui
            // 
            this.lblNumEqui.AutoSize = true;
            this.lblNumEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEqui.ForeColor = System.Drawing.Color.White;
            this.lblNumEqui.Location = new System.Drawing.Point(17, 412);
            this.lblNumEqui.Name = "lblNumEqui";
            this.lblNumEqui.Size = new System.Drawing.Size(86, 18);
            this.lblNumEqui.TabIndex = 17;
            this.lblNumEqui.Text = "#Equipaje:";
            // 
            // cbxTerSal
            // 
            this.cbxTerSal.FormattingEnabled = true;
            this.cbxTerSal.Location = new System.Drawing.Point(632, 335);
            this.cbxTerSal.Name = "cbxTerSal";
            this.cbxTerSal.Size = new System.Drawing.Size(184, 21);
            this.cbxTerSal.TabIndex = 18;
            this.cbxTerSal.SelectedIndexChanged += new System.EventHandler(this.CbxTerSal_SelectedIndexChanged);
            this.cbxTerSal.SelectedValueChanged += new System.EventHandler(this.CbxTerSal_SelectedValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 410);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(632, 374);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(184, 21);
            this.cbxDestino.TabIndex = 20;
            // 
            // chkEquipaje
            // 
            this.chkEquipaje.AutoSize = true;
            this.chkEquipaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEquipaje.ForeColor = System.Drawing.Color.White;
            this.chkEquipaje.Location = new System.Drawing.Point(120, 373);
            this.chkEquipaje.Name = "chkEquipaje";
            this.chkEquipaje.Size = new System.Drawing.Size(68, 20);
            this.chkEquipaje.TabIndex = 22;
            this.chkEquipaje.Text = "SI/NO";
            this.chkEquipaje.UseVisualStyleBackColor = true;
            this.chkEquipaje.CheckedChanged += new System.EventHandler(this.ChkEquipaje_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(743, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Asientos";
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(29, 31);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(565, 118);
            this.tabla.TabIndex = 24;
            this.tabla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tabla_MouseClick);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(333, 333);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(140, 20);
            this.txtHora.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(549, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(632, 410);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(184, 20);
            this.txtMonto.TabIndex = 27;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonto_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(746, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnInternacional
            // 
            this.btnInternacional.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnInternacional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnInternacional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternacional.ForeColor = System.Drawing.Color.White;
            this.btnInternacional.Location = new System.Drawing.Point(876, 433);
            this.btnInternacional.Name = "btnInternacional";
            this.btnInternacional.Size = new System.Drawing.Size(114, 46);
            this.btnInternacional.TabIndex = 29;
            this.btnInternacional.Text = "Tiquete Internacional";
            this.btnInternacional.UseVisualStyleBackColor = true;
            this.btnInternacional.Click += new System.EventHandler(this.BtnInternacional_Click);
            // 
            // tdUni
            // 
            this.tdUni.AllowUserToAddRows = false;
            this.tdUni.AllowUserToDeleteRows = false;
            this.tdUni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdUni.Location = new System.Drawing.Point(29, 199);
            this.tdUni.Name = "tdUni";
            this.tdUni.ReadOnly = true;
            this.tdUni.Size = new System.Drawing.Size(565, 114);
            this.tdUni.TabIndex = 30;
            this.tdUni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TdUni_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Horario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(26, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 32;
            this.label11.Text = "Unidades:";
            // 
            // VentaTiquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(991, 482);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tdUni);
            this.Controls.Add(this.btnInternacional);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkEquipaje);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxTerSal);
            this.Controls.Add(this.lblNumEqui);
            this.Controls.Add(this.txtNumEqui);
            this.Controls.Add(this.txtAsiento);
            this.Controls.Add(this.txtNumTiq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "VentaTiquetes";
            this.Text = "VentaTiquetes";
            this.Load += new System.EventHandler(this.VentaTiquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdUni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumTiq;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.TextBox txtNumEqui;
        private System.Windows.Forms.Label lblNumEqui;
        private System.Windows.Forms.ComboBox cbxTerSal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.CheckBox chkEquipaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInternacional;
        private System.Windows.Forms.DataGridView tdUni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}