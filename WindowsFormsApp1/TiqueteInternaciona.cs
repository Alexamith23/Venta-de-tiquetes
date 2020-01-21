using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enteties;
using BOL;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class TiqueteInternaciona : Form
    {
        private Usuario logueado;
        public TiqueteInternaciona(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logueado = log;
            txtNumEqui.Visible = false;
            lblNumEqui.Visible = false;
            txtNumEqui2.Visible = false;
            lblTiq2.Visible = false;
            cargarHorarios();
            cargarHorarios2();
            cargarAsientos(asientos());
            cargarAsientos2(asientos2());
            cargarTerminales();
            
          
        /// <summary>
        /// Allows to charge a table with schedules
        /// </summary> 
        }
        public void cargarHorarios() { 
        HorarioBOL us = new HorarioBOL();
        List<Horario> lst = us.cargarHorarios();
        DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
        DataRow Renglon;

        //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
        Tabla.Columns.Add(new DataColumn("Horario", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Ruta", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Terminal", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Día", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Salida", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Llegada", typeof(string)));
            Renglon = Tabla.NewRow();
            foreach (Horario a in lst)
            {
                Tabla.Rows.Add(a.GSidHorario, a.GSidRuta, a.GSidTerminal, a.GSdia, a.GSHoraSalida, a.GSHoraLlegada);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            dtHorarios.DataSource = Tabla;

        }
        /// <summary>
        /// Allows to charge a table with schedules
        /// </summary>
        public void cargarHorarios2()
        {
            HorarioBOL us = new HorarioBOL();
            List<Horario> lst = us.cargarHorarios();
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Horario", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Ruta", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Terminal", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Día", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Salida", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Llegada", typeof(string)));
            Renglon = Tabla.NewRow();
            foreach (Horario a in lst)
            {
                Tabla.Rows.Add(a.GSidHorario, a.GSidRuta, a.GSidTerminal, a.GSdia, a.GSHoraSalida, a.GSHoraLlegada);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            tabla.DataSource = Tabla;

        }
      
        private void Button1_Click(object sender, EventArgs e)
        {
         
        }
        /// <summary>
        /// Allows to show the amount of seats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtUnidaes_MouseClick(object sender, MouseEventArgs e)
        {
            txtUni.Text = dtUnidaes.CurrentRow.Cells[0].Value.ToString();
            int cap = Convert.ToInt32(dtUnidaes.CurrentRow.Cells[4].Value.ToString());
            camposDisponibles(cap);
        }
        /// <summary>
        /// Allows to generate a matriz
        /// </summary>
        /// <returns></returns>
        public Button[,] asientos()
        {
            int con = 1;
            Button[,] boton = new Button[10, 7];
            Button[,] mat = new Button[10, 7];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    boton[i, j] = new Button();
                    boton[i, j].Width = 45;
                    boton[i, j].Height = 25;
                    // boton[i, j].Text = String.Format("{0},{1}", i, j);
                    boton[i, j].Text = String.Format("{0}", con);
                    boton[i, j].Top = i * 25;
                    boton[i, j].Left = j * 45;
                    con++;
                    boton[i, j].Click += new EventHandler(evento);
                    mat[i, j] = boton[i, j];
                    //panel1.Controls.Add(boton[i, j]);
                }
            }
            return mat;
        }
        /// <summary>
        /// Allows to generate a matriz
        /// </summary>
        /// <returns></returns>
        public Button[,] asientos2()
        {
            int con = 1;
            Button[,] boton = new Button[10, 7];
            Button[,] mat = new Button[10, 7];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    boton[i, j] = new Button();
                    boton[i, j].Width = 45;
                    boton[i, j].Height = 25;
                    // boton[i, j].Text = String.Format("{0},{1}", i, j);
                    boton[i, j].Text = String.Format("{0}", con);
                    boton[i, j].Top = i * 25;
                    boton[i, j].Left = j * 45;
                    con++;
                    boton[i, j].Click += new EventHandler(evento2);
                    mat[i, j] = boton[i, j];
                    //panel1.Controls.Add(boton[i, j]);
                }
            }
            return mat;
        }
        /// <summary>
        /// allows to assign events to the buttoms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento2(object sender, EventArgs e)
        {
            txtAsiento2.Text = ((Button)sender).Text.ToString();

            txtNumTiq2.Text = ((Button)sender).Text.ToString();
            txtNumEqui2.Text = ((Button)sender).Text.ToString();
        }
        /// <summary>
        /// allows to assign events to the buttoms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento(object sender, EventArgs e)
        {
            txtAsiento.Text = ((Button)sender).Text.ToString();

            txtNumTiq.Text = ((Button)sender).Text.ToString();
            txtNumEqui.Text = ((Button)sender).Text.ToString();
        }
        /// <summary>
        /// Allows to add buttoms to the matriz
        /// </summary>
        /// <param name="boton">buttom matriz</param>
        public void cargarAsientos(Button[,] boton)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    panel1.Controls.Add(boton[i, j]);
                    

                }
            }
        }
        /// <summary>
        /// Allows to add buttoms to the matriz
        /// </summary>
        /// <param name="boton">button matriz</param>
        public void cargarAsientos2(Button[,] boton)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    panel2.Controls.Add(boton[i, j]);


                }
            }
        }
        /// <summary>
        /// Allows to register a new ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                TiquetesBOL x = new TiquetesBOL();
                Pasajero d = new Pasajero();
                TiqueteInternacional z = new TiqueteInternacional();
                TiqueteInternacional q = new TiqueteInternacional();
                d.Passport = txtPassport.Text.Trim();
                d.Nombre = txtNombre.Text.Trim();
                d.Vigencia = dtVigencia.Value.ToString("dd/MM/yyyy");
                d.FecViaje = dtFechaViaje.Value.ToString("dd/MM/yyyy");
                d.FecRegreso = dtFechaRegreso.Value.ToString("dd/MM/yyyy");
                d.MotivoViaje = cbxMotVia.SelectedItem.ToString();
                d.HoraSalida = txtHoraSalida.Text.Trim();
                d.LugarSalida = cbxTerSalida.SelectedItem.ToString();
                d.Destino = cbxTerSalida.SelectedItem.ToString();
                x.registrarPasajero(d);
                z.Asiento = txtAsiento.Text.ToString().Trim();
                z.Equipaje = Convert.ToBoolean(chkEquipaje.Checked);
                z.NumEquipaje = Convert.ToInt32(txtNumEqui.Text.ToString().Trim());
                z.NumTiquete = Convert.ToInt32(txtNumTiq.Text.ToString().Trim());
                z.Horasalida = dtHorarios.CurrentRow.Cells[4].Value.ToString();
                z.TerminalSalida = dtHorarios.CurrentRow.Cells[2].Value.ToString();
                z.Monto = Convert.ToDouble(txtMonto.Text.ToString().Trim());
                z.TerminalLLegada = cbxTerDes.SelectedItem.ToString();
                z.Fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                z.Vendedor = logueado.Codigo.ToString();
                DateTime fecha = DateTime.Now;
                string Text = fecha.ToString("dd/MM/yyyy");
                z.FechaVenta = Text;
                z.CodUnidad = dtUnidaes.CurrentRow.Cells[0].Value.ToString();
                z.NumPassport = txtPas.Text.Trim();
                x.registrarTiqInt(z);
                q.Asiento = txtAsiento2.Text.ToString().Trim();
                q.Equipaje = Convert.ToBoolean(chkEquipaje2.Checked);
                q.NumEquipaje = Convert.ToInt32(txtNumEqui2.Text.ToString().Trim());
                q.NumTiquete = Convert.ToInt32(txtNumTiq2.Text.ToString().Trim());
                q.Horasalida = tabla.CurrentRow.Cells[4].Value.ToString();
                q.TerminalSalida = tabla.CurrentRow.Cells[2].Value.ToString();
                q.Monto = Convert.ToDouble(txtMonto2.Text.ToString().Trim());
                q.TerminalLLegada = cbxTerDes2.SelectedItem.ToString();
                q.Fecha = dtFec2.Value.ToString("dd/MM/yyyy");
                q.Vendedor = logueado.Codigo.ToString();
                DateTime fech = DateTime.Now;
                string text = fech.ToString("dd/MM/yyyy");
                q.FechaVenta = text;
                q.CodUnidad = dtRegreso.CurrentRow.Cells[0].Value.ToString();
                q.NumPassport = txtPas2.Text.Trim();
                x.registrarTiqInt(q);
                MessageBox.Show("Registrado con exito", "Tiquetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception be)
            {
                MessageBox.Show(be.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Allows to input text in different textbox at same time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPas_TextChanged(object sender, EventArgs e)
        {
            txtPas2.Text = txtPas.Text.Trim();
            txtPassport.Text= txtPas.Text.Trim();
        }
        /// <summary>
        /// Allows to charge a combobox with Terminals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxTerSal_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxTerDes.Items.Clear();
            cbxTerSalida.SelectedItem = cbxTerSal.SelectedItem.ToString();
            TerminalBOL u = new TerminalBOL();
            List<Terminal> c = u.cargarTerminales();
            foreach (Terminal x in c)
            {
                if (x.Codigo != cbxTerSal.SelectedItem.ToString())
                {
                    cbxTerDes.Items.Add(x.Codigo);
                }

            }
        }
        /// <summary>
        /// allows to selected the item of a combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxTerDes_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxTerDestino.SelectedItem = cbxTerDes.SelectedItem.ToString();
        }
        /// <summary>
        /// allows to selected the item of a combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtHora_TextChanged(object sender, EventArgs e)
        {
            txtHoraSalida.Text = txtHora.Text.ToString();
        }
        /// <summary>
        /// Allows to charge the available seats for a specific date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtFec2_ValueChanged(object sender, EventArgs e)
        {
            
            TiquetesBOL x = new TiquetesBOL();
            string fec = dtFec2.Value.ToString("dd/MM/yyyy");

            if (tabla.CurrentRow.Cells[3].Value.ToString().ToLower().Equals(dtFec2.Value.ToString("dddd", new CultureInfo("es-ES"))))
            {
                dtFechaRegreso.Value = dtFec2.Value;
                List<int> z = x.camposDisponiblesInter(fec, dtHorarios.CurrentRow.Cells[4].Value.ToString());
                quitarAsiento2();
            }
            else
            {
                MessageBox.Show("Seleccione un dia que corresponda al del horario");
            }
        }
        /// <summary>
        /// Allows to charge a combobox with Terminals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cargarTerminales()
        {
            TerminalBOL u = new TerminalBOL();
            List<Terminal> c = u.cargarTerminales();
            foreach (Terminal x in c)
            {
                cbxTerSal.Items.Add(x.Codigo);
                cbxTerSal2.Items.Add(x.Codigo);
                cbxTerSalida.Items.Add(x.Codigo);
                
                cbxTerDestino.Items.Add(x.Codigo);
                
            }
        }
        /// <summary>
        /// Allows to charge the buses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tabla_MouseClick(object sender, MouseEventArgs e)
        {
            UnidadBOL b = new UnidadBOL();
            cbxTerSal2.SelectedItem = tabla.CurrentRow.Cells[2].Value.ToString();
            txtHora2.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            cargarUnidades2(tabla.CurrentRow.Cells[1].Value.ToString());
        }
        /// <summary>
        /// Allows to charge the buses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtHorarios_MouseClick(object sender, MouseEventArgs e)
        {
            UnidadBOL b = new UnidadBOL();
            cbxTerSal.SelectedItem = dtHorarios.CurrentRow.Cells[2].Value.ToString();
            txtHora.Text = dtHorarios.CurrentRow.Cells[4].Value.ToString();
            cargarUnidades(dtHorarios.CurrentRow.Cells[1].Value.ToString());
        }
        /// <summary>
        /// Allows to charge the buses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cargarUnidades(String rut)
        {
            UnidadBOL us = new UnidadBOL();
            List<Unidad> lst = us.cargarUnidadesRuta(rut);
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Codigo", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Placa", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Motor", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Modelo", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Capacidad", typeof(int)));
            Tabla.Columns.Add(new DataColumn("Color", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Ruta", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Permiso", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Fecha Vigencia", typeof(string)));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon = Tabla.NewRow();

            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            /*
            Renglon[0] = "Judis";
            Renglon[1] = "othis";
            Renglon[2] = 12;
            Renglon[3] = "Maxa";
            */
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            //Tabla.Rows.Add("luis");
            //Tabla.Rows.Add("pepe");
            foreach (Unidad a in lst)
            {
                Tabla.Rows.Add(a.Codigo, a.GSNumPlaca, a.GSNumMotor, a.GSModelo, a.GSCapacidad, a.GSColor, a.GSRutaAsignada,
                    a.GSPermisoTransito, a.GSFechaVigencia);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            dtUnidaes.DataSource = Tabla;
            // cbxCol.SelectedIndex = 0;
            //cbxColor.SelectedIndex = 0;
            //cbxRut.SelectedIndex = 0;
            //cbxRuta.SelectedIndex = 0;
        }
        /// <summary>
        /// Allows to charge the buses in a table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cargarUnidades2(String rut)
        {
            UnidadBOL us = new UnidadBOL();
            List<Unidad> lst = us.cargarUnidadesRuta(rut);
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Codigo", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Placa", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Motor", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Modelo", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Capacidad", typeof(int)));
            Tabla.Columns.Add(new DataColumn("Color", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Ruta", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Permiso", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Fecha Vigencia", typeof(string)));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon = Tabla.NewRow();

            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            /*
            Renglon[0] = "Judis";
            Renglon[1] = "othis";
            Renglon[2] = 12;
            Renglon[3] = "Maxa";
            */
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            //Tabla.Rows.Add("luis");
            //Tabla.Rows.Add("pepe");
            foreach (Unidad a in lst)
            {
                Tabla.Rows.Add(a.Codigo, a.GSNumPlaca, a.GSNumMotor, a.GSModelo, a.GSCapacidad, a.GSColor, a.GSRutaAsignada,
                    a.GSPermisoTransito, a.GSFechaVigencia);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            dtRegreso.DataSource = Tabla;
            // cbxCol.SelectedIndex = 0;
            //cbxColor.SelectedIndex = 0;
            //cbxRut.SelectedIndex = 0;
            //cbxRuta.SelectedIndex = 0;
        }
        /// <summary>
        /// Allows to select the arrive terminal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtRegreso_MouseClick(object sender, MouseEventArgs e)
        {
            txtUni2.Text = dtRegreso.CurrentRow.Cells[0].Value.ToString();
            int cap = Convert.ToInt32(dtRegreso.CurrentRow.Cells[4].Value.ToString());
            camposDisponibles2(cap);
        }
        /// <summary>
        /// Allows to show the availables seats of a bus
        /// </summary>
        /// <param name="cap"></param>
        private void camposDisponibles2(int cap)
        {
            foreach (Control x in panel2.Controls)
            {
                if (x is Button)
                {
                    int num = Convert.ToInt32(x.Text);
                    x.Visible = mostrarAsiento2(Convert.ToInt32(num));
                }
            }
        }
        /// <summary>
        /// Allows to validate if a seat is available
        /// </summary>
        /// <param name="num">text of the buttom</param>
        /// <returns></returns>
        private bool mostrarAsiento2(int num)
        {
            int cap = Convert.ToInt32(dtRegreso.CurrentRow.Cells[4].Value.ToString());
            for (int i = 0; i < cap + 1; i++)
            {
                if (i == num)
                {
                    return true;
                }
            }
            return false;

        }
        /// <summary>
        /// Allows to show the buttoms availables that represents bus seats
        /// </summary>
        /// <param name="cap">text of the buttom</param>
        
        private void camposDisponibles(int cap)
        {
            foreach (Control x in panel1.Controls)
            {
                if (x is Button)
                {
                    int num = Convert.ToInt32(x.Text);
                    x.Visible = mostrarAsiento(Convert.ToInt32(num));
                }
            }
        }
        /// <summary>
        /// Allows to show the buttoms availables that represents bus seats
        /// </summary>
        /// <param name="num">text of the buttom</param>
        /// <returns></returns>
        private bool mostrarAsiento(int num)
        {
            int cap = Convert.ToInt32(dtUnidaes.CurrentRow.Cells[4].Value.ToString());
            for (int i = 0; i < cap + 1; i++)
            {
                if (i == num)
                {
                    return true;
                }
            }
            return false;

        }
        /// <summary>
        /// Allows to remove the seats not availables of a bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TiquetesBOL x = new TiquetesBOL();
            string fec = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            if (dtHorarios.CurrentRow.Cells[3].Value.ToString().ToLower().Equals(dateTimePicker1.Value.ToString("dddd", new CultureInfo("es-ES"))))
            {
                dtFechaViaje.Value = dateTimePicker1.Value;
                List<int> z = x.camposDisponiblesInter(fec, dtHorarios.CurrentRow.Cells[4].Value.ToString());
                quitarAsiento();
            }
            else
            {
                MessageBox.Show("Seleccione un dia que corresponda al del horario");
            }
        }
        /// <summary>
        /// Allows to show or not a buttom that represent a bus Seat
        /// </summary>
        private void quitarAsiento()
        {
            foreach (Control b in panel1.Controls)
            {
                if (b is Button)
                {
                    b.Visible = disponibilidadAsientos(Convert.ToInt32(b.Text.ToString()));
                }
            }
        }
        /// <summary>
        /// Allows to show or not a buttom that represent a bus Seat
        /// </summary>
        private void quitarAsiento2()
        {
            foreach (Control b in panel2.Controls)
            {
                if (b is Button)
                {
                    b.Visible = disponibilidadAsientos2(Convert.ToInt32(b.Text.ToString()));
                }
            }
        }
        /// <summary>
        /// Allows to know what are the availables seats of a bus
        /// </summary>
        /// <param name="num">text of the seat</param>
        /// <returns>true if is available otherwise false</returns>
        private bool disponibilidadAsientos2(int num)
        {
            TiquetesBOL x = new TiquetesBOL();
            List<int> z = x.camposDisponiblesInter(dtFec2.Value.ToString("dd/MM/yyyy"), tabla.CurrentRow.Cells[4].Value.ToString());
            bool encontrado = true;
            int cap = Convert.ToInt32(dtRegreso.CurrentRow.Cells[4].Value.ToString());
            if (num <= cap)
            {
                if (z.Count == 0)
                {
                    encontrado = true;
                }
                for (int i = 0; i <= z.Count-1; i++)
                {

                    if (z[i] == num)
                    {
                        encontrado = false;
                    }

                }
            }
            else
            {
                encontrado = false;
            }
            return encontrado;
        }
        /// <summary>
        /// Allows to know what are the availables seats of a bus
        /// </summary>
        /// <param name="num">text of the seat</param>
        /// <returns>true if is available otherwise false</returns>
        private bool disponibilidadAsientos(int num)
        {
            TiquetesBOL x = new TiquetesBOL();
            List<int> z = x.camposDisponiblesInter(dateTimePicker1.Value.ToString("dd/MM/yyyy"), dtHorarios.CurrentRow.Cells[4].Value.ToString());
            bool encontrado = true;
            int cap = Convert.ToInt32(dtUnidaes.CurrentRow.Cells[4].Value.ToString());
            if (num <= cap)
            {
                if (z.Count == 0)
                {
                    encontrado = true;
                }
                for (int i = 0; i <= z.Count-1; i++)
                {

                    if (z[i] == num)
                    {
                        encontrado = false;
                    }
                   
                }
            }
            else
            {
                encontrado = false;
            }
            return encontrado;
        }
        /// <summary>
        /// Allows to know if a ticket own a luggage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkEquipaje_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEquipaje.Checked == true)
            {
                txtNumEqui.Visible = true;
                lblNumEqui.Visible = true;
                txtNumEqui.Text = txtAsiento.Text;
            }
            else
            {
                txtNumEqui.Visible = false;
                lblNumEqui.Visible = false;
                txtNumEqui.Text = "0";
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to input just numbers in a textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMonto2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("DIgite Unicamente Numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Allows to input just numbers in a textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("DIgite Unicamente Numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Allows to know if a ticket own a luggage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkEquipaje2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEquipaje2.Checked == true)
            {
                txtNumEqui2.Visible = true;
                lblTiq2.Visible = true;
                txtNumEqui2.Text = txtAsiento.Text;
            }
            else
            {
                txtNumEqui2.Visible = false;
                lblTiq2.Visible = false;
                txtNumEqui2.Text = "0";
            }
        }
        /// <summary>
        /// Allows to charge a combobox with Terminals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxTerSal2_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxTerDes2.Items.Clear();
           
            TerminalBOL u = new TerminalBOL();
            List<Terminal> c = u.cargarTerminales();
            foreach (Terminal x in c)
            {
                if (x.Codigo != cbxTerSal2.SelectedItem.ToString())
                {
                    cbxTerDes2.Items.Add(x.Codigo);
                }

            }
        }
        /// <summary>
        /// allows to selected the itemof a combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxTerDes2_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxTerDestino.SelectedItem = cbxTerDes2.SelectedItem.ToString();
        }
    }
}
