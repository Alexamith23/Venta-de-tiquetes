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
    public partial class CrudRutas : Form
    {
        public CrudRutas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar();
        }
        /// <summary>
        /// Allows to charge a table with Routes
        /// </summary>
        public void cargar()
        {
            RutaBOL us = new RutaBOL();
            List<Ruta> lst = us.cargarRutas();
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Identificador", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Nombre", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Descripción", typeof(string)));


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
            foreach (Ruta a in lst)
            {
                Tabla.Rows.Add(a.Identificador, a.Nombre, a.Descripcion);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            tabla.DataSource = Tabla;

        }
        private void CrudRutas_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to register a new Route
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            RutaBOL d = new RutaBOL();
            Ruta u = new Ruta();
            u.Identificador = txtIdentificador.Text.Trim();
            u.Nombre = txtNombre.Text.Trim();
            u.Descripcion = txtDescripcion.Text.Trim();
            d.registrarRuta(u);
            MessageBox.Show("Terminal Registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar();
        }
        /// <summary>
        /// Allows to eliminate a route
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            String Nombre = tabla.CurrentRow.Cells[0].Value.ToString();
            if (Nombre != null)
            {
                RutaBOL d = new RutaBOL();
                if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    d.eliminarRuta(Nombre);
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
        /// Allows to update a route
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.CurrentRow != null)
                {
                    RutaBOL d = new RutaBOL();
                    Ruta u = new Ruta();
                    u.Identificador = txtIde.Text.Trim();
                    u.Nombre = txtNom.Text.Trim();
                    u.Descripcion = txtDes.Text.Trim();
                    String actual = tabla.CurrentRow.Cells[0].Value.ToString();
                    d.editarRuta(actual, u);
                    this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccione una Ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido realizar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Charge the inforation when a route will be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tabla_MouseClick(object sender, MouseEventArgs e)
        {
            txtIde.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            txtNom.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            txtDes.Text = tabla.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
