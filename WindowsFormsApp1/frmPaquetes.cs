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
    public partial class frmPaquetes : Form
    {
        private Usuario logueado;
        public frmPaquetes(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar();
            cargarTerminales();
            cargarUnidaes();
            logueado = log;
            txtCodUser.Text = logueado.Codigo;
            numEncomienda();
        }
        /// <summary>
        /// Allows to generate the consecutive number of a package
        /// </summary>
        public void numEncomienda()
        {
            EncomiendaBOL us = new EncomiendaBOL();
            txtEncomienda.Text = Convert.ToString(us.numEncomienda());
        }
        /// <summary>
        /// Allows to charge a combobox with terminals
        /// </summary>
        public void cargarTerminales()
        {
            EncomiendaBOL us = new EncomiendaBOL();
            List<Terminal> lst = us.cargarTerminales();
            foreach(Terminal x in lst)
            {
                cbxTerminal.Items.Add(x.Codigo);
            }
        }
        /// <summary>
        /// Allows to charge a combobox with buses code
        /// </summary>
        public void cargarUnidaes()
        {
            EncomiendaBOL us = new EncomiendaBOL();
            List<Unidad> lst = us.cargarUnidades();
            foreach (Unidad x in lst)
            {
                cbxUnidad.Items.Add(x.Codigo);
            }
        }
        /// <summary>
        /// Allows to charge all packages registered in the system
        /// </summary>
        public void cargar()
        {
            EncomiendaBOL us = new EncomiendaBOL();
            List<Encomienda> lst = us.cargarEncomiendas();
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("# Encomienda", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Usuario", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Fecha", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Receptor", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Terminal", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Unidad", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Precio", typeof(double)));
            Tabla.Columns.Add(new DataColumn("Entregado", typeof(bool)));
            


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
            
            foreach (Encomienda a in lst)
            {
                Tabla.Rows.Add(a.GSNumEncomienda, a.GSCodUser, a.GSFecha,a.GSNomReceptor,a.GSCodTerminal,a.GSCodUnidad,a.GSPrecio,a.GSEntregado);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            tabla.DataSource = Tabla;

        }
        
        /// <summary>
        /// Allows to register a package as delivered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEntregado_Click(object sender, EventArgs e)
        {
            try
            {
                EncomiendaBOL d = new EncomiendaBOL();
                Encomienda u = new Encomienda();
                u.GSNumEncomienda = tabla.CurrentRow.Cells[0].Value.ToString();
                u.GSCodUser = tabla.CurrentRow.Cells[1].Value.ToString();
                u.GSFecha = tabla.CurrentRow.Cells[2].Value.ToString();
                u.GSNomReceptor = tabla.CurrentRow.Cells[3].Value.ToString();
                u.GSCodTerminal = tabla.CurrentRow.Cells[4].Value.ToString();
                u.GSCodUnidad = tabla.CurrentRow.Cells[5].Value.ToString();
                u.GSPrecio = Convert.ToDouble(tabla.CurrentRow.Cells[6].Value.ToString());
                u.GSEntregado = true;
                d.entregarEncomienda(u);
                cargar();

            }
            catch
            {
                MessageBox.Show("Entrega no realizada");
            }
        }
        /// <summary>
        /// Allows to register a new Package
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                EncomiendaBOL d = new EncomiendaBOL();
                Encomienda u = new Encomienda();
                u.GSNumEncomienda = txtEncomienda.Text.Trim();
                u.GSCodUser = logueado.Codigo;
                string Text = dtpFecha.Value.ToString("dd/MM/yyyy");
                u.GSFecha = Text;
                u.GSNomReceptor = txtNombre.Text.Trim();
                u.GSCodTerminal = cbxTerminal.SelectedItem.ToString();
                u.GSCodUnidad = cbxUnidad.SelectedItem.ToString();
                u.GSPrecio = Convert.ToDouble(txtPago.Text.Trim());
                u.GSEntregado = false;
                d.registrarEncomienda(u);
                MessageBox.Show("Encomienda Registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Allows to eliminate a package
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String Nombre =tabla.CurrentRow.Cells[0].Value.ToString();
                if (Nombre != null)
                {
                    EncomiendaBOL d = new EncomiendaBOL();
                    if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        d.eliminarEncomienda(Nombre);
                        this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una Encomienda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido eliminar la encomienda");
            }
        }
        /// <summary>
        /// Allows to resend a package
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEquivocada_Click(object sender, EventArgs e)
        {
            Encomienda u = new Encomienda();
            u.GSNumEncomienda = tabla.CurrentRow.Cells[0].Value.ToString();
            u.GSCodUser = tabla.CurrentRow.Cells[1].Value.ToString();
            u.GSFecha = tabla.CurrentRow.Cells[2].Value.ToString();
            u.GSNomReceptor = tabla.CurrentRow.Cells[3].Value.ToString();
            u.GSCodTerminal = tabla.CurrentRow.Cells[4].Value.ToString();
            u.GSCodUnidad = tabla.CurrentRow.Cells[5].Value.ToString();
            u.GSPrecio = Convert.ToDouble(tabla.CurrentRow.Cells[6].Value.ToString());
            u.GSEntregado = Convert.ToBoolean(tabla.CurrentRow.Cells[7].Value.ToString());
            devolverEncomienda x = new devolverEncomienda(u);
            x.Show();
            cargar();
            

        }
        /// <summary>
        /// Allows to charge the tables with packages using a filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            EncomiendaBOL us = new EncomiendaBOL();
            List<Encomienda> lst = us.cargarEncomiendas(txtFiltro.Text.Trim());
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("# Encomienda", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Usuario", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Fecha", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Receptor", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Terminal", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Unidad", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Precio", typeof(double)));
            Tabla.Columns.Add(new DataColumn("Entregado", typeof(bool)));



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

            foreach (Encomienda a in lst)
            {
                Tabla.Rows.Add(a.GSNumEncomienda, a.GSCodUser, a.GSFecha, a.GSNomReceptor, a.GSCodTerminal, a.GSCodUnidad, a.GSPrecio, a.GSEntregado);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            tabla.DataSource = Tabla;

        }
        /// <summary>
        /// Allows to input just numbers in a textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPago_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
