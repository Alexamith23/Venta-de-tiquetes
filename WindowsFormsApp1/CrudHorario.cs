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

namespace WindowsFormsApp1
{
    public partial class CrudHorario : Form
    {
        public CrudHorario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar();
            cargarTerminal();
            cargarRuta();
            cargarCombox();
            
        }
        /// <summary>
        /// Allows to caharge all schedules registered in the system
        /// </summary>
        public void cargar() {

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
                Tabla.Rows.Add(a.GSidHorario, a.GSidRuta, a.GSidTerminal,a.GSdia,a.GSHoraSalida,a.GSHoraLlegada);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            tabla.DataSource = Tabla;

        }
        /// <summary>
        /// Allows to update a schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.CurrentRow != null)
                {
                    HorarioBOL d = new HorarioBOL();
                    Horario u = new Horario();
                    u.GSidHorario = txtIdHor.Text.Trim();
                    u.GSidRuta = cbxRut.SelectedItem.ToString();
                    u.GSidTerminal = cbxTer.SelectedItem.ToString();
                    u.GSdia = cbxD.SelectedItem.ToString();
                    u.GSHoraSalida = txtSal.Text.Trim();
                    u.GSHoraLlegada = txtLle.Text.Trim();
                    String actual = tabla.CurrentRow.Cells[0].Value.ToString();
                    d.editarHorarios(actual, u);
                    this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccione un Horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch
            {
                MessageBox.Show("No se ha podido realizar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
       /// <summary>
       /// Allows to charge a combobox with all routes registered in the system
       /// </summary>
        public void cargarRuta()
        {
            HorarioBOL c = new HorarioBOL();
            List<Ruta> d = c.cargarRutas();
            foreach(Ruta x in d)
            {
                cbxRut.Items.Add(x.Identificador);
                cbxRuta.Items.Add(x.Identificador);
            }
        }
        /// <summary>
        /// Allows to charge a combobox with all terminals registered in the system
        /// </summary>
        public void cargarTerminal()
        {
            HorarioBOL c = new HorarioBOL();
            List<Terminal> d = c.cargarTerminales();
            foreach (Terminal x in d)
            {
                cbxTer.Items.Add(x.Codigo);
                cbxTerminal.Items.Add(x.Codigo);
            }
        }
        /// <summary>
        /// Allows to register a new route
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                HorarioBOL d = new HorarioBOL();
                Horario u = new Horario();
                u.GSidHorario = txtHorario.Text.Trim();
                u.GSidRuta = cbxRuta.SelectedItem.ToString();
                u.GSidTerminal = cbxTerminal.SelectedItem.ToString();
                u.GSdia = cbxDia.SelectedItem.ToString();
                u.GSHoraSalida = cbxSalH.SelectedItem.ToString() + ":" + cbxSalM.SelectedItem.ToString();//txtSalida.Text.Trim();
                u.GSHoraLlegada = cbxLleH.SelectedItem.ToString() + ":" + cbxLleM.SelectedItem.ToString();//txtLlegada.Text.Trim();
                d.registrarHorario(u);
                MessageBox.Show("Horario Registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar();
            }catch(Exception te)
            {
                MessageBox.Show(te.Message);
            }
        }
        /// <summary>
        /// Allows to charge comboboxes to select an hour
        /// </summary>
        public void cargarCombox()
        {
            for(int i = 1; i < 24; i++)
            {
                cbxLleH.Items.Add(Convert.ToString(i));
                cbxSalH.Items.Add(Convert.ToString(i));

            }
            for (int i = 00; i < 60; i++)
            {
                cbxLleM.Items.Add(Convert.ToString(i));
                cbxSalM.Items.Add(Convert.ToString(i));

            }
        }
        /// <summary>
        /// Allows to eliminate an schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            String Nombre = tabla.CurrentRow.Cells[0].Value.ToString();
            if (Nombre != null)
            {
                HorarioBOL d = new HorarioBOL();
                if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    d.eliminarHorario(Nombre);
                    this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                    cargar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Allows to charge the days in a combobox
        /// </summary>
        public void cargarDias()
        {

            cbxD.Items.Add("Lunes");
            cbxD.Items.Add("Martes");
            cbxD.Items.Add("Miercoles");
            cbxD.Items.Add("Jueves");
            cbxD.Items.Add("Viernes");
            cbxD.Items.Add("Sabado");
            cbxD.Items.Add("Domingo");
        }
        /// <summary>
        /// Charge the inforation when a schedule will be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tabla_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdHor.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            cbxRut.SelectedItem= tabla.CurrentRow.Cells[1].Value.ToString();
            cbxTer.SelectedItem= tabla.CurrentRow.Cells[2].Value.ToString();
            cbxD.SelectedItem= tabla.CurrentRow.Cells[3].Value.ToString();
            txtSal.Text= tabla.CurrentRow.Cells[4].Value.ToString();
            txtLle.Text= tabla.CurrentRow.Cells[5].Value.ToString();
        }
    }
    }

