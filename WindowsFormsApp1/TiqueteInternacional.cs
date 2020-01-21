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
    public partial class TiqueteInternacional : Form
    {
        public TiqueteInternacional()
        {
            InitializeComponent();
            cargarUnidades();
            cargarHorarios();
            cargarAsientos(asientos());
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
        public void cargarUnidades()
        {
            UnidadBOL us = new UnidadBOL();
            List<Unidad> lst = us.cargarUnidades();
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

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void DtUnidaes_MouseClick(object sender, MouseEventArgs e)
        {

        }
        public Button[,] asientos()
        {
            int con = 1;
            Button[,] boton = new Button[10, 6];
            Button[,] mat = new Button[10, 6];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
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
        private void evento(object sender, EventArgs e)
        {
            txtAsiento.Text = ((Button)sender).Text.ToString();

            txtNumTiq.Text = ((Button)sender).Text.ToString();
        }
        public void cargarAsientos(Button[,] boton)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    panel1.Controls.Add(boton[i, j]);

                }
            }
        }
    }
}
