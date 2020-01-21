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
    public partial class frmArqueo : Form
    {
        public frmArqueo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar();
        }
        /// <summary>
        /// Allows to chare the cash register
        /// </summary>
        public void cargar()
        {
            EncomiendaBOL us = new EncomiendaBOL();
            List<CierreCaja> lst = us.cargarArqueoDeCaja();
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Codigo Usuario", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Fecha", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Monto", typeof(double)));


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
            foreach (CierreCaja a in lst)
            {
                Tabla.Rows.Add(a.GSUsuario, a.GSFecha, a.GSMonto);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            dtArqueo.DataSource = Tabla;

        }
        private void FrmArqueo_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to charge all the tickets or packages that represents the cash register
        /// </summary>
        /// <param name="info"></param>
        public void cargarArqueoUsuario(CierreCaja info)
        {
            if (info.GSUsuario.Contains("ENC"))
            {
                EncomiendaBOL us = new EncomiendaBOL();
                List<Encomienda> lst = us.cargarEncomiendasArq(info);
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
                dtDatos.DataSource = Tabla;
            }
            else
            {
                TiquetesBOL us = new TiquetesBOL();
                List<TiqueteNacional> lst = us.cargarTiquetesArq(info);
                DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
                DataRow Renglon;

                //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
                Tabla.Columns.Add(new DataColumn("#Tiquete", typeof(int)));
                Tabla.Columns.Add(new DataColumn("FechaViaje", typeof(string)));
                Tabla.Columns.Add(new DataColumn("Asiento", typeof(string)));
                Tabla.Columns.Add(new DataColumn("HoraSalida", typeof(string)));
                Tabla.Columns.Add(new DataColumn("TerminalSalida", typeof(string)));
                Tabla.Columns.Add(new DataColumn("TerminalLlegada", typeof(string)));
                Tabla.Columns.Add(new DataColumn("Equipaje", typeof(bool)));
                Tabla.Columns.Add(new DataColumn("#Equipaje", typeof(int)));
                Tabla.Columns.Add(new DataColumn("Monto", typeof(double)));
                Tabla.Columns.Add(new DataColumn("Vendedor", typeof(string)));
                Tabla.Columns.Add(new DataColumn("FechaDeCompra", typeof(string)));



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

                foreach (TiqueteNacional a in lst)
                {
                    Tabla.Rows.Add(a.GSNumTiquete, a.GSFecha, a.GSAsiento, a.GSHorasalida, a.GSTerminalSalida, a.GSTerminalLLegada, a.GSEquipaje, a.GSNumEquipaje,a.Monto,a.Vendedor,a.FechaVenta);

                }


                //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
                dtDatos.DataSource = Tabla;

                
                List<TiqueteInternacional> ls = us.cargarTiquetesInterArq(info);
                DataTable Tables = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
                DataRow Renglo;

                //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
                Tables.Columns.Add(new DataColumn("#Tiquete", typeof(int)));
                Tables.Columns.Add(new DataColumn("#Pasaporte", typeof(string)));
                Tables.Columns.Add(new DataColumn("FechaViaje", typeof(string)));
                Tables.Columns.Add(new DataColumn("Asiento", typeof(string)));
                Tables.Columns.Add(new DataColumn("Unidad", typeof(string)));
                Tables.Columns.Add(new DataColumn("HoraSalida", typeof(string)));
                Tables.Columns.Add(new DataColumn("TerminalSalida", typeof(string)));
                Tables.Columns.Add(new DataColumn("TerminalLlegada", typeof(string)));
                Tables.Columns.Add(new DataColumn("Equipaje", typeof(bool)));
                Tables.Columns.Add(new DataColumn("#Equipaje", typeof(int)));
                Tables.Columns.Add(new DataColumn("Monto", typeof(double)));
                Tables.Columns.Add(new DataColumn("Vendedor", typeof(string)));
                Tables.Columns.Add(new DataColumn("FechaDeCompra", typeof(string)));



                //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
                Renglo = Tables.NewRow();

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
                
                foreach (TiqueteInternacional a in ls)
                {
                    Tables.Rows.Add(a.NumTiquete, a.NumPassport,a.Fecha, a.Asiento,a.CodUnidad, a.Horasalida, a.TerminalSalida, a.TerminalLLegada, a.Equipaje, a.NumEquipaje, a.Monto, a.Vendedor, a.FechaVenta);

                }


                //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
                dtInter.DataSource = Tables;

                
            }

        }
        /// <summary>
        /// Allows to select the cash register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtArqueo_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                CierreCaja z = new CierreCaja();
                z.GSUsuario= dtArqueo.CurrentRow.Cells[0].Value.ToString();
                z.GSFecha = dtArqueo.CurrentRow.Cells[1].Value.ToString();
                z.GSMonto =Convert.ToDouble(dtArqueo.CurrentRow.Cells[2].Value.ToString());
                cargarArqueoUsuario(z);
            }
            catch
            {

            }
        }
        /// <summary>
        /// Allows to charge the cash registers using a filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EncomiendaBOL us = new EncomiendaBOL();
                List<CierreCaja> lst = us.cargarArqueoDeCaja(txtFiltro.Text.Trim());
                DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
                DataRow Renglon;

                //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
                Tabla.Columns.Add(new DataColumn("Codigo Usuario", typeof(string)));
                Tabla.Columns.Add(new DataColumn("Fecha", typeof(string)));
                Tabla.Columns.Add(new DataColumn("Monto", typeof(double)));


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
                foreach (CierreCaja a in lst)
                {
                    Tabla.Rows.Add(a.GSUsuario, a.GSFecha, a.GSMonto);

                }


                //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
                dtArqueo.DataSource = Tabla;

            }
            catch(Exception be) 
            {

            }
        }
    }
}
