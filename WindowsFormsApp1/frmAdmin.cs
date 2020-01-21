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

namespace WindowsFormsApp1
{
    public partial class frmAdmin : Form
    {
        private Usuario admin;
       
        public frmAdmin()
        {
            Usuario s = new Usuario("ADTZ001", "Chepe12", "12345");
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            admin = s;
        }
        public frmAdmin(Usuario d)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            admin = d;
        }
        /// <summary>
        /// Allows to open a new user Register windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            CrudUsuario v = new CrudUsuario(admin);
            v.Show();
        }
        /// <summary>
        /// Allows to open a new Access windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Accesos x = new Accesos(admin);
            x.Show();
        }
        /// <summary>
        /// Allows to open a new reports windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes x = new Reportes();
                x.Show();
            }
            catch(Exception be)
            {
                MessageBox.Show("Accion no ejecutada");
            }
        }
    }
}
