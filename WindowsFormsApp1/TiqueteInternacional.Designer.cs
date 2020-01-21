namespace WindowsFormsApp1
{
    partial class TiqueteInternacional
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
            this.dtHorarios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.chkEquipaje = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxTerSal = new System.Windows.Forms.ComboBox();
            this.lblNumEqui = new System.Windows.Forms.Label();
            this.txtNumEqui = new System.Windows.Forms.TextBox();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.txtNumTiq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtUnidaes = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUnidaes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHorarios
            // 
            this.dtHorarios.AllowUserToAddRows = false;
            this.dtHorarios.AllowUserToDeleteRows = false;
            this.dtHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHorarios.Location = new System.Drawing.Point(19, 49);
            this.dtHorarios.Name = "dtHorarios";
            this.dtHorarios.ReadOnly = true;
            this.dtHorarios.Size = new System.Drawing.Size(526, 193);
            this.dtHorarios.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(904, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 47;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(874, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(778, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Monto:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(689, 344);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(68, 20);
            this.txtHora.TabIndex = 44;
            // 
            // chkEquipaje
            // 
            this.chkEquipaje.AutoSize = true;
            this.chkEquipaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEquipaje.ForeColor = System.Drawing.Color.White;
            this.chkEquipaje.Location = new System.Drawing.Point(689, 424);
            this.chkEquipaje.Name = "chkEquipaje";
            this.chkEquipaje.Size = new System.Drawing.Size(68, 20);
            this.chkEquipaje.TabIndex = 43;
            this.chkEquipaje.Text = "SI/NO";
            this.chkEquipaje.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(689, 508);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 21);
            this.comboBox2.TabIndex = 42;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(874, 421);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // cbxTerSal
            // 
            this.cbxTerSal.FormattingEnabled = true;
            this.cbxTerSal.Items.AddRange(new object[] {
            "SV001"});
            this.cbxTerSal.Location = new System.Drawing.Point(845, 464);
            this.cbxTerSal.Name = "cbxTerSal";
            this.cbxTerSal.Size = new System.Drawing.Size(143, 21);
            this.cbxTerSal.TabIndex = 40;
            // 
            // lblNumEqui
            // 
            this.lblNumEqui.AutoSize = true;
            this.lblNumEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEqui.ForeColor = System.Drawing.Color.White;
            this.lblNumEqui.Location = new System.Drawing.Point(594, 466);
            this.lblNumEqui.Name = "lblNumEqui";
            this.lblNumEqui.Size = new System.Drawing.Size(86, 18);
            this.lblNumEqui.TabIndex = 39;
            this.lblNumEqui.Text = "#Equipaje:";
            // 
            // txtNumEqui
            // 
            this.txtNumEqui.Location = new System.Drawing.Point(689, 464);
            this.txtNumEqui.Name = "txtNumEqui";
            this.txtNumEqui.ReadOnly = true;
            this.txtNumEqui.Size = new System.Drawing.Size(68, 20);
            this.txtNumEqui.TabIndex = 38;
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(874, 310);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.ReadOnly = true;
            this.txtAsiento.Size = new System.Drawing.Size(68, 20);
            this.txtAsiento.TabIndex = 37;
            // 
            // txtNumTiq
            // 
            this.txtNumTiq.Location = new System.Drawing.Point(689, 308);
            this.txtNumTiq.Name = "txtNumTiq";
            this.txtNumTiq.ReadOnly = true;
            this.txtNumTiq.Size = new System.Drawing.Size(68, 20);
            this.txtNumTiq.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(594, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Equipaje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(596, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(780, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(609, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(778, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "#Asiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(778, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(582, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "#Tiquete:";
            // 
            // dtUnidaes
            // 
            this.dtUnidaes.AllowUserToAddRows = false;
            this.dtUnidaes.AllowUserToDeleteRows = false;
            this.dtUnidaes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUnidaes.Location = new System.Drawing.Point(19, 308);
            this.dtUnidaes.Name = "dtUnidaes";
            this.dtUnidaes.ReadOnly = true;
            this.dtUnidaes.Size = new System.Drawing.Size(526, 206);
            this.dtUnidaes.TabIndex = 48;
            this.dtUnidaes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DtUnidaes_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(687, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(583, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "#Unidad:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(621, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 271);
            this.panel1.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(778, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Pasaporte:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(874, 384);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 53;
            // 
            // TiqueteInternacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1005, 577);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtUnidaes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.chkEquipaje);
            this.Controls.Add(this.comboBox2);
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
            this.Controls.Add(this.dtHorarios);
            this.Name = "TiqueteInternacional";
            this.Text = "TiqueteInternacional";
            ((System.ComponentModel.ISupportInitialize)(this.dtHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUnidaes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtHorarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.CheckBox chkEquipaje;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxTerSal;
        private System.Windows.Forms.Label lblNumEqui;
        private System.Windows.Forms.TextBox txtNumEqui;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.TextBox txtNumTiq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtUnidaes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
    }
}