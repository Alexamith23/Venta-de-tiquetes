namespace WindowsFormsApp1
{
    partial class CrudHorario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.txtIdHor = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLle = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRut = new System.Windows.Forms.ComboBox();
            this.cbxTer = new System.Windows.Forms.ComboBox();
            this.cbxD = new System.Windows.Forms.ComboBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxSalM = new System.Windows.Forms.ComboBox();
            this.cbxLleM = new System.Windows.Forms.ComboBox();
            this.cbxLleH = new System.Windows.Forms.ComboBox();
            this.cbxSalH = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxTerminal = new System.Windows.Forms.ComboBox();
            this.cbxRuta = new System.Windows.Forms.ComboBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(41, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tabPage.Controls.Add(this.txtIdHor);
            this.tabPage.Controls.Add(this.btnEditar);
            this.tabPage.Controls.Add(this.button1);
            this.tabPage.Controls.Add(this.txtLle);
            this.tabPage.Controls.Add(this.txtSal);
            this.tabPage.Controls.Add(this.label6);
            this.tabPage.Controls.Add(this.label5);
            this.tabPage.Controls.Add(this.label4);
            this.tabPage.Controls.Add(this.label3);
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Controls.Add(this.label1);
            this.tabPage.Controls.Add(this.cbxRut);
            this.tabPage.Controls.Add(this.cbxTer);
            this.tabPage.Controls.Add(this.cbxD);
            this.tabPage.Controls.Add(this.tabla);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(704, 327);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Horarios";
            // 
            // txtIdHor
            // 
            this.txtIdHor.Location = new System.Drawing.Point(568, 41);
            this.txtIdHor.Name = "txtIdHor";
            this.txtIdHor.Size = new System.Drawing.Size(121, 20);
            this.txtIdHor.TabIndex = 15;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(614, 298);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(520, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtLle
            // 
            this.txtLle.Location = new System.Drawing.Point(568, 260);
            this.txtLle.Name = "txtLle";
            this.txtLle.Size = new System.Drawing.Size(121, 20);
            this.txtLle.TabIndex = 12;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(568, 221);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(121, 20);
            this.txtSal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(457, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Llegada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(457, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(457, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Día:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(457, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Terminal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Horario:";
            // 
            // cbxRut
            // 
            this.cbxRut.FormattingEnabled = true;
            this.cbxRut.Location = new System.Drawing.Point(568, 85);
            this.cbxRut.Name = "cbxRut";
            this.cbxRut.Size = new System.Drawing.Size(121, 21);
            this.cbxRut.TabIndex = 4;
            // 
            // cbxTer
            // 
            this.cbxTer.FormattingEnabled = true;
            this.cbxTer.Location = new System.Drawing.Point(568, 130);
            this.cbxTer.Name = "cbxTer";
            this.cbxTer.Size = new System.Drawing.Size(121, 21);
            this.cbxTer.TabIndex = 3;
            // 
            // cbxD
            // 
            this.cbxD.FormattingEnabled = true;
            this.cbxD.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cbxD.Location = new System.Drawing.Point(568, 177);
            this.cbxD.Name = "cbxD";
            this.cbxD.Size = new System.Drawing.Size(121, 21);
            this.cbxD.TabIndex = 2;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.Location = new System.Drawing.Point(20, 49);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(398, 239);
            this.tabla.TabIndex = 0;
            this.tabla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tabla_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tabPage2.Controls.Add(this.cbxSalM);
            this.tabPage2.Controls.Add(this.cbxLleM);
            this.tabPage2.Controls.Add(this.cbxLleH);
            this.tabPage2.Controls.Add(this.cbxSalH);
            this.tabPage2.Controls.Add(this.btnRegistrar);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbxDia);
            this.tabPage2.Controls.Add(this.cbxTerminal);
            this.tabPage2.Controls.Add(this.cbxRuta);
            this.tabPage2.Controls.Add(this.txtHorario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar";
            // 
            // cbxSalM
            // 
            this.cbxSalM.FormattingEnabled = true;
            this.cbxSalM.Location = new System.Drawing.Point(468, 221);
            this.cbxSalM.Name = "cbxSalM";
            this.cbxSalM.Size = new System.Drawing.Size(52, 21);
            this.cbxSalM.TabIndex = 16;
            // 
            // cbxLleM
            // 
            this.cbxLleM.FormattingEnabled = true;
            this.cbxLleM.Location = new System.Drawing.Point(468, 259);
            this.cbxLleM.Name = "cbxLleM";
            this.cbxLleM.Size = new System.Drawing.Size(52, 21);
            this.cbxLleM.TabIndex = 15;
            // 
            // cbxLleH
            // 
            this.cbxLleH.FormattingEnabled = true;
            this.cbxLleH.Location = new System.Drawing.Point(361, 260);
            this.cbxLleH.Name = "cbxLleH";
            this.cbxLleH.Size = new System.Drawing.Size(52, 21);
            this.cbxLleH.TabIndex = 14;
            // 
            // cbxSalH
            // 
            this.cbxSalH.FormattingEnabled = true;
            this.cbxSalH.Location = new System.Drawing.Point(362, 221);
            this.cbxSalH.Name = "cbxSalH";
            this.cbxSalH.Size = new System.Drawing.Size(52, 21);
            this.cbxSalH.TabIndex = 13;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(506, 295);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 26);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(258, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Llegada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(270, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Salida:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(291, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Día:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(251, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Terminal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(281, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ruta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(259, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Horario:";
            // 
            // cbxDia
            // 
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cbxDia.Location = new System.Drawing.Point(362, 171);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(158, 21);
            this.cbxDia.TabIndex = 3;
            // 
            // cbxTerminal
            // 
            this.cbxTerminal.FormattingEnabled = true;
            this.cbxTerminal.Location = new System.Drawing.Point(362, 122);
            this.cbxTerminal.Name = "cbxTerminal";
            this.cbxTerminal.Size = new System.Drawing.Size(158, 21);
            this.cbxTerminal.TabIndex = 2;
            // 
            // cbxRuta
            // 
            this.cbxRuta.FormattingEnabled = true;
            this.cbxRuta.Location = new System.Drawing.Point(362, 84);
            this.cbxRuta.Name = "cbxRuta";
            this.cbxRuta.Size = new System.Drawing.Size(158, 21);
            this.cbxRuta.TabIndex = 1;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(362, 44);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(158, 20);
            this.txtHorario.TabIndex = 0;
            // 
            // CrudHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(796, 396);
            this.Controls.Add(this.tabControl1);
            this.Name = "CrudHorario";
            this.Text = "CrudHorario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLle;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRut;
        private System.Windows.Forms.ComboBox cbxTer;
        private System.Windows.Forms.ComboBox cbxD;
        private System.Windows.Forms.TextBox txtIdHor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.ComboBox cbxTerminal;
        private System.Windows.Forms.ComboBox cbxRuta;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.ComboBox cbxSalM;
        private System.Windows.Forms.ComboBox cbxLleM;
        private System.Windows.Forms.ComboBox cbxLleH;
        private System.Windows.Forms.ComboBox cbxSalH;
    }
}