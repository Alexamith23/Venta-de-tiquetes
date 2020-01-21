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
    public partial class VentaTiquetes : Form
    {
        private Usuario vende;
        public VentaTiquetes(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //cargarAsientos(asientos());
            txtNumEqui.Visible = false;
            lblNumEqui.Visible = false;
            cargar();
            cargarTerminales();
            vende = log;
            btnInternacional.Visible = vendeInternacional();
        }
        /// <summary>
        /// Allows to know if a user can sell international tickets
        /// </summary>
        /// <returns></returns>
        public bool vendeInternacional()
        {
            if(vende.Codigo.Substring(3, 1).Equals("S"))
            {
                return true;
            }else if(vende.Codigo.Substring(3, 1).Equals("Z"))
            {
                return true;
            }
            else if (vende.Codigo.Substring(3, 1).Equals("P"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Allows to charge a table with schedules
        /// </summary>
        public void cargar()
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
        /// Allows to assign a event to the buttons of the matriz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento(object sender,EventArgs e)
        {
            txtAsiento.Text = ((Button)sender).Text.ToString();
            
            txtNumTiq.Text= ((Button)sender).Text.ToString();
            
        }
        /// <summary>
        /// Allows to charge the matriz
        /// </summary>
        /// <param name="boton"></param>
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
        private void VentaTiquetes_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to validate if a ticket needs luggage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkEquipaje_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEquipaje.Checked == true)
            {
                txtNumEqui.Visible=true;
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
        /// <summary>
        /// Allows to charge the buses in a table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tabla_MouseClick(object sender, MouseEventArgs e)
        {
            UnidadBOL b = new UnidadBOL();
            cbxTerSal.SelectedItem= tabla.CurrentRow.Cells[2].Value.ToString();
            txtHora.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            cargarUnidades (tabla.CurrentRow.Cells[1].Value.ToString());
            

        }
        /// <summary>
        /// Allows to charge the buses
        /// </summary>
        /// <param name="rut"></param>
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
            tdUni.DataSource = Tabla;
            // cbxCol.SelectedIndex = 0;
            //cbxColor.SelectedIndex = 0;
            //cbxRut.SelectedIndex = 0;
            //cbxRuta.SelectedIndex = 0;
        }
        private void CbxTerSal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to show the TiqueteInternaciona window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInternacional_Click(object sender, EventArgs e)
        {
            TiqueteInternaciona d = new TiqueteInternaciona(vende);
            d.Show();
        }
        /// <summary>
        /// Allows to register a new ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.CurrentRow.Cells[3].Value.ToString().ToLower().Equals(dateTimePicker1.Value.ToString("dddd", new CultureInfo("es-ES"))))
                {
                    string fec = tdUni.CurrentRow.Cells[8].Value.ToString();
                    DateTime userDate = DateTime.ParseExact(fec, "dd/MM/yyyy", null);

                    if ((userDate >= dateTimePicker1.Value || dateTimePicker1.Value<DateTime.Now) && tdUni.CurrentRow!=null)
                    {
                        TiquetesBOL c = new TiquetesBOL();
                        TiqueteNacional d = new TiqueteNacional();
                        d.GSAsiento = txtAsiento.Text.ToString().Trim();
                        d.GSEquipaje = Convert.ToBoolean(chkEquipaje.Checked);
                        d.GSNumEquipaje = Convert.ToInt32(txtNumEqui.Text.ToString().Trim());
                        d.GSNumTiquete = Convert.ToInt32(txtNumTiq.Text.ToString().Trim());
                        d.GSHorasalida = tabla.CurrentRow.Cells[4].Value.ToString();
                        d.GSTerminalSalida = tabla.CurrentRow.Cells[2].Value.ToString();
                        d.Monto = Convert.ToDouble(txtMonto.Text.ToString().Trim());
                        d.GSTerminalLLegada = cbxDestino.SelectedItem.ToString();
                        d.GSFecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                        d.Vendedor = vende.Codigo.ToString();
                        DateTime fecha = DateTime.Now;
                        string Text = fecha.ToString("dd/MM/yyyy");
                        d.FechaVenta = Text;
                        c.registrarTiqueteNac(d);
                        MessageBox.Show("Registrado con Exito","Tiquetes Nacionales",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El Bus no cuenta con permiso para la fecha seleccionada\n" +
                            "O la fecha seleccionada no es Vigente");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fecha con el mismo dia del horario");
                }
            }
            catch(Exception be)
            {
                MessageBox.Show(be.Message);
            }
            

            
        }
        /// <summary>
        /// Allows to do visible the seats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TdUni_MouseClick(object sender, MouseEventArgs e)
        {
            int cap = Convert.ToInt32(tdUni.CurrentRow.Cells[4].Value.ToString());
            cargarAsientos(asientos());
            camposDisponibles(cap);
        }
        /// <summary>
        /// Allows to do visible the seats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool mostrarAsiento(int num)
        {
            int cap = Convert.ToInt32(tdUni.CurrentRow.Cells[4].Value.ToString());
            for (int i = 0; i < cap+1; i++)
            {
                if (i == num)
                {
                    return true;
                }
            }
            return false;
            
        }
        /// <summary>
        /// Allows to charge the terminals in a combobox
        /// </summary>
        public void cargarTerminales()
        {
            TerminalBOL u = new TerminalBOL();
            List<Terminal> c = u.cargarTerminales();
            foreach (Terminal x in c)
            {
                if (x.Codigo != "PNM001")
                {
                    cbxTerSal.Items.Add(x.Codigo);
                }
            }
        }
        /// <summary>
        /// Allows to charge the availables seats 
        /// </summary>
        private void camposDisponibles(int cap)
        {
          foreach(Control x in panel1.Controls)
            {
                if(x is Button)
                {
                    int num = Convert.ToInt32(x.Text);
                    x.Visible = mostrarAsiento(Convert.ToInt32(num));
                }
            }
        }
        /// <summary>
        /// Allows to charge the available seats for a specific date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TiquetesBOL x = new TiquetesBOL();
            string fec= dateTimePicker1.Value.ToString("dd/MM/yyyy");
            
            if (tabla.CurrentRow.Cells[3].Value.ToString().ToLower().Equals(dateTimePicker1.Value.ToString("dddd", new CultureInfo("es-ES"))))
            {
                
               List<int> z= x.camposDisponibles(fec, tabla.CurrentRow.Cells[4].Value.ToString());
                quitarAsiento();
            }
            else
            {
                MessageBox.Show("Seleccione un dia d que corresponda al del horario");
            }
            // x.camposDisponibles(fec);
            //string ds = "27/04/1999";
           // MessageBox.Show(dateTimePicker1.Value.ToString("dddd", new CultureInfo("es-ES")));
           // DateTime userDate = DateTime.ParseExact(ds, "dd/MM/yyyy", null);
            //MessageBox.Show(userDate.ToString("dddd",new CultureInfo("es-ES")));
        }
        /// <summary>
        /// Allows to do visible or invisible a matriz buttom
        /// </summary>
        /// <param name="num">text of the button</param>
        /// <returns> true if is free otherwise false</returns>
        private bool disponibilidadAsientos(int num)
        {
            TiquetesBOL x = new TiquetesBOL();
            int cap = Convert.ToInt32(tdUni.CurrentRow.Cells[4].Value.ToString());

            bool encontrado = true;
            List<int> z = x.camposDisponibles(dateTimePicker1.Value.ToString("dd/MM/yyyy"), tabla.CurrentRow.Cells[4].Value.ToString());
            //txtMonto.Text = Convert.ToString(z[1]);
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
                    //encontrado = true;
                }
            }
            else
            {
                encontrado = false;
            }
            return encontrado;
        }
        /// <summary>
        /// Allows to validate if a seat will be shown
        /// </summary>
        private void quitarAsiento()
        {
           foreach(Control b in panel1.Controls)
            {
                if(b is Button)
                {
                    b.Visible=disponibilidadAsientos(Convert.ToInt32(b.Text.ToString()));
                }
            }

        }
        /// <summary>
        /// Allows to input just number in a textbox
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
                MessageBox.Show("DIgite Unicamente Valores Numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxDestino_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to charge the cbxDestino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxTerSal_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxDestino.Items.Clear();
            TerminalBOL u = new TerminalBOL();
            List<Terminal> c = u.cargarTerminales();
            foreach (Terminal x in c)
            {
                if (x.Codigo != "PNM001" && x.Codigo!=cbxTerSal.SelectedItem.ToString())
                {
                    cbxDestino.Items.Add(x.Codigo);
                }
            }
        }
    }
}
