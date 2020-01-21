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
    public partial class CrudTerminales : Form
    {
        public CrudTerminales()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar();
        }
        /// <summary>
        /// Allows to register a Terminal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            TerminalBOL d = new TerminalBOL();
            Terminal u = new Terminal();
            u.Codigo = txtCodigo.Text.Trim();
            u.Nombre =txtNombre .Text.Trim();
            u.Ubicacion = txtUbicacion.Text.Trim();
            d.registrarTerminal(u);
            MessageBox.Show("Terminal Registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar();
        }
        /// <summary>
        /// Charge a table with Terminals
        /// </summary>
        public void cargar()
        {
            TerminalBOL us = new TerminalBOL();
            List<Terminal> lst = us.cargarTerminales();
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Codigo", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Nombre", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Ubicación", typeof(string)));


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
            foreach (Terminal a in lst)
            {
                Tabla.Rows.Add(a.Codigo, a.Nombre, a.Ubicacion);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            tabla.DataSource = Tabla;

        }
        /// <summary>
        /// Allowsto eliminate a terminal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            String Nombre = tabla.CurrentRow.Cells[0].Value.ToString();
            if (Nombre != null)
            {
                TerminalBOL d = new TerminalBOL();
                if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    d.eliminarTerminal(Nombre);
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
        /// Allows to update a Terminal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.CurrentRow != null)
                {
                    TerminalBOL d = new TerminalBOL();
                    Terminal u = new Terminal();
                    u.Codigo = txtCod.Text.Trim();
                    u.Nombre = txtNam.Text.Trim();
                    u.Ubicacion = txtUbi.Text.Trim();
                    String actual = tabla.CurrentRow.Cells[0].Value.ToString();
                    d.editarTerminales(actual, u);
                    this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccione una Terminal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch(Exception be)
            {
                MessageBox.Show(be.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Charge the inforation when a terminal will be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tabla_MouseClick(object sender, MouseEventArgs e)
        {
            txtCod.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            txtNam.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            txtUbi.Text = tabla.CurrentRow.Cells[2].Value.ToString();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
