using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using Enteties;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        /// <summary>
        /// Allows to validate if an user can enter to the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBOL c = new UsuarioBOL();
                Boolean res = c.login(txtUsuario.Text.Trim(), txtPassword.Text.Trim());
                if (res == true)
                {

                    Usuario loge = c.usuarioLogueado(txtUsuario.Text.Trim(), txtPassword.Text.Trim());
                    //MessageBox.Show(loge.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    Main frm = new Main(loge);
                    
                    frm.Show();
                    
                    this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }catch(Exception be)
            {
                MessageBox.Show(be.Message);
            }
        }
    }

}
    

