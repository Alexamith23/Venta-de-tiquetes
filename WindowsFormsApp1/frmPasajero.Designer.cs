namespace WindowsFormsApp1
{
    partial class frmPasajero
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMotViaje = new System.Windows.Forms.TextBox();
            this.dtVigencia = new System.Windows.Forms.DateTimePicker();
            this.dtFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.dtFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.cbxTerSalida = new System.Windows.Forms.ComboBox();
            this.cbxTerDestino = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasaporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vigencia.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Viaje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Regreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(170, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Motivo Viaje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(174, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hora Salida:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(169, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lugar Salida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(204, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Destino:";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(326, 38);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(200, 20);
            this.txtPassport.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(326, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtMotViaje
            // 
            this.txtMotViaje.Location = new System.Drawing.Point(326, 214);
            this.txtMotViaje.Name = "txtMotViaje";
            this.txtMotViaje.Size = new System.Drawing.Size(200, 20);
            this.txtMotViaje.TabIndex = 11;
            // 
            // dtVigencia
            // 
            this.dtVigencia.Location = new System.Drawing.Point(326, 114);
            this.dtVigencia.Name = "dtVigencia";
            this.dtVigencia.Size = new System.Drawing.Size(200, 20);
            this.dtVigencia.TabIndex = 12;
            // 
            // dtFechaRegreso
            // 
            this.dtFechaRegreso.Location = new System.Drawing.Point(326, 176);
            this.dtFechaRegreso.Name = "dtFechaRegreso";
            this.dtFechaRegreso.Size = new System.Drawing.Size(200, 20);
            this.dtFechaRegreso.TabIndex = 13;
            // 
            // dtFechaViaje
            // 
            this.dtFechaViaje.Location = new System.Drawing.Point(326, 147);
            this.dtFechaViaje.Name = "dtFechaViaje";
            this.dtFechaViaje.Size = new System.Drawing.Size(200, 20);
            this.dtFechaViaje.TabIndex = 14;
            // 
            // cbxTerSalida
            // 
            this.cbxTerSalida.FormattingEnabled = true;
            this.cbxTerSalida.Location = new System.Drawing.Point(326, 283);
            this.cbxTerSalida.Name = "cbxTerSalida";
            this.cbxTerSalida.Size = new System.Drawing.Size(200, 21);
            this.cbxTerSalida.TabIndex = 17;
            // 
            // cbxTerDestino
            // 
            this.cbxTerDestino.FormattingEnabled = true;
            this.cbxTerDestino.Location = new System.Drawing.Point(326, 326);
            this.cbxTerDestino.Name = "cbxTerDestino";
            this.cbxTerDestino.Size = new System.Drawing.Size(200, 21);
            this.cbxTerDestino.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(497, 374);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 29);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(326, 249);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(200, 20);
            this.txtHoraSalida.TabIndex = 20;
            // 
            // frmPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxTerDestino);
            this.Controls.Add(this.cbxTerSalida);
            this.Controls.Add(this.dtFechaViaje);
            this.Controls.Add(this.dtFechaRegreso);
            this.Controls.Add(this.dtVigencia);
            this.Controls.Add(this.txtMotViaje);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPasajero";
            this.Text = "frmPasajero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMotViaje;
        private System.Windows.Forms.DateTimePicker dtVigencia;
        private System.Windows.Forms.DateTimePicker dtFechaRegreso;
        private System.Windows.Forms.DateTimePicker dtFechaViaje;
        private System.Windows.Forms.ComboBox cbxTerSalida;
        private System.Windows.Forms.ComboBox cbxTerDestino;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtHoraSalida;
    }
}