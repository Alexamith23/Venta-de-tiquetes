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
    public partial class CrudUnidad : Form
    {
        public CrudUnidad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar();
            cargarRutas();
            cargarColores();
            
        }
       /// <summary>
       /// Allows to convert the date.now to a string
       /// </summary>
       /// <param name="fec"></param>
        public void setFecha(string fec)
        {
            DateTime userDate = DateTime.ParseExact(fec, "dd/MM/yyyy", null);
            txtFec.Value = userDate;
        }
        /// <summary>
        /// Allows to charge all routes in a combobox
        /// </summary>
        public void cargarRutas()
        {
            UnidadBOL us = new UnidadBOL();
            List<Ruta> lst = us.cargarRutas();
            foreach(Ruta a in lst)
            {
                cbxRut.Items.Add(a.Identificador);
                cbxRuta.Items.Add(a.Identificador);

            }


        }
        /// <summary>
        /// Allows to charge a table with buses
        /// </summary>
        public void cargar() {
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
                Tabla.Rows.Add(a.Codigo, a.GSNumPlaca, a.GSNumMotor, a.GSModelo,a.GSCapacidad,a.GSColor,a.GSRutaAsignada,
                    a.GSPermisoTransito,a.GSFechaVigencia);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            tabla.DataSource = Tabla;
           // cbxCol.SelectedIndex = 0;
            //cbxColor.SelectedIndex = 0;
            //cbxRut.SelectedIndex = 0;
            //cbxRuta.SelectedIndex = 0;


        }
        /// <summary>
        /// Allows to register a bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                UnidadBOL m = new UnidadBOL();
                Unidad u = new Unidad();
                u.Codigo = txtCodigo.Text.Trim();
                u.GSNumPlaca = txtPlaca.Text.Trim();
                u.GSNumMotor = txtMotor.Text.Trim();
                u.GSModelo = txtModelo.Text.Trim();
                u.GSCapacidad = Convert.ToInt32(txtCapacidad.Text.Trim());
                u.GSColor = cbxColor.SelectedItem.ToString();
               
                u.GSRutaAsignada = cbxRuta.SelectedItem.ToString();
                u.GSPermisoTransito = txtPermiso.Text.Trim();
                string Text = txtFecha.Value.ToString("dd/MM/yyyy");
                u.GSFechaVigencia = Text;
                m.registrarUnidad(u);
                cargar();
                MessageBox.Show("Unidad Registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception za){
                MessageBox.Show(za.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        /// <summary>
        /// Allows to eliminate a bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEleminar_Click(object sender, EventArgs e)
        {
            String Nombre = tabla.CurrentRow.Cells[0].Value.ToString();
            if (Nombre != null)
            {
                UnidadBOL d = new UnidadBOL();
                if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    d.eliminarUnidad(Nombre);
                    this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                    cargar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Unidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Allows to update a bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.CurrentRow != null)
                {
                    UnidadBOL d = new UnidadBOL();
                    Unidad u = new Unidad();
                    u.Codigo = txtCod.Text.Trim();
                    u.GSNumPlaca = txtPla.Text.Trim();
                    u.GSNumMotor = txtMot.Text.Trim();
                    u.GSModelo = txtMod.Text.Trim();
                    u.GSCapacidad = Convert.ToInt32(txtCap.Text.Trim());
                    u.GSColor = cbxCol.SelectedItem.ToString();
                    u.GSRutaAsignada = cbxRut.SelectedItem.ToString();
                    u.GSPermisoTransito = txtPer.Text.Trim();
                    u.GSFechaVigencia = txtFec.Value.ToString("dd/MM/yyyy");
                    String actual = tabla.CurrentRow.Cells[0].Value.ToString();
                    d.editarUnidades(actual, u);
                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccione una Unidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido realizar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Charge the inforation when a bus will be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tabla_MouseClick(object sender, MouseEventArgs e)
        {
            txtCod.Text= tabla.CurrentRow.Cells[0].Value.ToString();
            txtPla.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            txtMot.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            txtMod.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            txtCap.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            cbxCol.SelectedItem = tabla.CurrentRow.Cells[5].Value.ToString();
            cbxRut.SelectedItem = tabla.CurrentRow.Cells[6].Value.ToString();
            setFecha(tabla.CurrentRow.Cells[8].Value.ToString());
            txtPer.Text = tabla.CurrentRow.Cells[7].Value.ToString();


        }
        /// <summary>
        /// Allows to charge a combobox with colors
        /// </summary>
        private void cargarColores()
        {
            cbxCol.Items.Clear();
            cbxColor.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            cbxCol.Items.AddRange(colores);
            cbxColor.Items.AddRange(colores);

        }
        /// <summary>
        /// Allows to charge a combobox with colors
        /// </summary>
        private void CbxCol_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = cbxCol.Items[e.Index].ToString();
                Brush borde = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush pincel= new SolidBrush(color);
                Pen boli = new Pen(e.ForeColor);
                e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2,30, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 28, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 40, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Allows to charge a combobox with colors
        /// </summary>
        private void CbxColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = cbxColor.Items[e.Index].ToString();
                Brush borde = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush pincel = new SolidBrush(color);
                Pen boli = new Pen(e.ForeColor);
                e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 28, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 40, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
