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
    public partial class Accesos : Form
    {
        private Usuario uslo;
        
        public Accesos()
        {
            Usuario s = new Usuario("ADTS001", "Chepe12", "12345");
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            uslo = s;
            cargar(uslo);
        }
        public Accesos(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            uslo=log;
            cargar(uslo);
        }
        /// <summary>
        /// Allows to charge a datatable with Users data
        /// </summary>
        /// <param name="wwe">user logged in the system</param>
        public void cargar(Usuario wwe)
        {
            UsuarioBOL us = new UsuarioBOL();
            List<Usuario> lst = us.cargarUsuarios(wwe);
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;

            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Codigo", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Usuario", typeof(string)));
            Tabla.Columns.Add(new DataColumn("Contraseña", typeof(string)));


            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon = Tabla.NewRow();

            
            foreach (Usuario a in lst)
            {
                Tabla.Rows.Add(a.Codigo, a.gsUsuario, a.Password);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            table.DataSource = Tabla;

        }
       /// <summary>
       /// Allows to assign an access to a user
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBOL us = new UsuarioBOL();
                String user = table.CurrentRow.Cells[1].Value.ToString();
                String permi = lbtPermiso.SelectedItem.ToString();
                Permiso u = new Permiso();
                u.GSUsuario = user;
                u.GSVentana = permi;
                us.AsignarPermiso(u);
                cargarPermiso(user);
                

            }
            catch(Exception z)
            {
                MessageBox.Show(z.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Allows to charge the access of a specific user
        /// </summary>
        /// <param name="user">UserCode</param>
        private void cargarPermiso(string user)
        {
            ltbUser.Items.Clear();
            UsuarioBOL us = new UsuarioBOL();
            List<Permiso> t = us.cargarPermisos(user);
            foreach (Permiso x in t)
            {
                
                ltbUser.Items.Add(x);

            }
        }
        private void Table_MouseClick(object sender, MouseEventArgs e)
        {
            ltbUser.Items.Clear();
            String user= table.CurrentRow.Cells[1].Value.ToString();
            cargarPermiso(user);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBOL us = new UsuarioBOL();
                Permiso s = new Permiso();
                String user = table.CurrentRow.Cells[1].Value.ToString();
                string[] permi;
                string q = ltbUser.SelectedItem.ToString();
                permi = q.Split(',');
                s.GSUsuario = user;
                s.GSVentana = permi[1];
                us.quitarPermiso(s);
                cargarPermiso(user);
                


            }
            catch (Exception z)
            {

            }
        }

        private void Accesos_Load(object sender, EventArgs e)
        {

        }
    }
}
