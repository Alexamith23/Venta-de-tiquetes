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
    public partial class CrudUsuario : Form
    {
        private Usuario uslo;

        public CrudUsuario()
        {
            Usuario s = new Usuario("ADTZ001", "Chepe12", "12345");
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            uslo = s;
            cargar(uslo);
        }

        public CrudUsuario(Usuario sa)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            uslo = sa;
            cargar(uslo);
        }
        /// <summary>
        /// Allows to charge a table with Users
        /// </summary>
        /// <param name="wwe">User Logge in the system</param>
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

            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 

            foreach (Usuario a in lst)
            {
                Tabla.Rows.Add(a.Codigo,a.gsUsuario,a.Password);

            }


            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            tabla.DataSource = Tabla;
            
        }


        private void CrudUsuario_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to convert the ocupation with less words 
        /// </summary>
        /// <returns>abbreviation of the ocupation</returns>
        public string seleccionArea()
        {
            string ocu = cbxArea.SelectedItem.ToString();
            string ba = uslo.Codigo.Substring(3, 1); 
            
            string us = txtCodigo.Text.ToString();
            string res = "";
            switch (ocu)
            {

                case "Administrador":
                    res = "ADT"+ba+us;
                    return res ;
                    
                case "Encomiendas":
                    res = "ENC" +ba+ us;
                    return res;
                    
                case "Tiquetes":
                    res = "TIQ" +ba+ us;
                    return res;
                    
                case "Asistente":
                    res = "ASI" +ba+ us;
                    return res;
                    
            }
            return res;
        }
        /// <summary>
        /// Allows to convert the ocupation with less words 
        /// </summary>
        /// <returns>abbreviation of the ocupation</returns>
        public string seleccionAreaEdi()
        {
            string ocu = cbxAre.SelectedItem.ToString();
            string ba = uslo.Codigo.Substring(3, 1);

            string us = txtCod.Text.ToString();
            string res = "";
            switch (ocu)
            {

                case "Administrador":
                    res = "ADT" + ba + us;
                    return res;

                case "Encomiendas":
                    res = "ENC" + ba + us;
                    return res;

                case "Tiquetes":
                    res = "TIQ" + ba + us;
                    return res;

                case "Asistente":
                    res = "ASI" + ba + us;
                    return res;

            }
            return res;
        }
        /// <summary>
        /// Allows to convert the ocupation with less words 
        /// </summary>
        /// <returns>abbreviation of the ocupation</returns>
        private string sede(Usuario v)
        {
            string sed = v.Codigo.Substring(0,4);
            if (sed.Equals("ADTS"))
            {
                return ((cbxArea.SelectedItem.ToString().Substring(0, 4)) + "S");
            }
            return "hola";
        }
        
        /// <summary>
        /// Allows to eliminate an user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            String Nombre = tabla.CurrentRow.Cells[0].Value.ToString();
            if (Nombre != null)
            {
                UsuarioBOL d = new UsuarioBOL();
                if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    d.eliminarUsuario(Nombre);
                    this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                    cargar(uslo);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Allows to select the area to register a new user
        /// </summary>
        /// <returns></returns>
        public int selArea()
        {
            string a=tabla.CurrentRow.Cells[0].Value.ToString().Substring(0,3);
            //baaa.Substring(0,4));
            //Console.WriteLine(baaa.Substring(4, 3));
            int c = 0;
            if (a.Equals("ADT"))
            {
                c = 0;
            }
            else if (a.Equals("ENC"))
            {
                c = 1;
            }
            else if (a.Equals("TIQ"))
            {
                c = 2;
            }
            else if (a.Equals("ASI"))
            {
                c = 3;
            }
            return c;
        }
       /// <summary>
       /// Allows to update an user
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try {
                if (tabla.CurrentRow != null)
                {
                    UsuarioBOL d = new UsuarioBOL();
                    Usuario u = new Usuario();
                    u.Codigo = seleccionAreaEdi();
                    u.gsUsuario = txtUser.Text.Trim();
                    u.Password = txtPas.Text.Trim();
                    String actual = tabla.CurrentRow.Cells[0].Value.ToString();
                    d.editarUsuarios(actual, u);
                    this.tabUsuarios.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                    cargar(uslo);
                }
                else
                {
                    MessageBox.Show("Seleccione un Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception be)
            {
                MessageBox.Show(be.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Allows to charge the information when a user will be update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarUsuario(object sender, MouseEventArgs e)
        {
            cbxAre.SelectedIndex = selArea();
            txtCod.Text = tabla.CurrentRow.Cells[0].Value.ToString().Substring(4, 3);
            txtUser.Text= tabla.CurrentRow.Cells[1].Value.ToString();
            txtPas.Text = tabla.CurrentRow.Cells[2].Value.ToString();

        }
        /// <summary>
        /// Allows to divided a string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            string cas = uslo.Codigo.Substring(0, 4);
            txtUsuario.Text = cas;
        }
        /// <summary>
        /// Allows to register a new User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                UsuarioBOL d = new UsuarioBOL();
                Usuario u = new Usuario();
                //string cas = uslo.Codigo.Substring(0,4);
                string res = "";



                u.Codigo = seleccionArea();
                u.gsUsuario = txtUsuario.Text.Trim();
                u.Password = txtPassword.Text.Trim();
                d.registrarUsuario(u);
                MessageBox.Show("Usuario Registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabUsuarios.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                cargar(uslo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
        }
    }
}
