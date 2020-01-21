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
    public partial class Main : Form
    {
        private Usuario logueado;
        
        public Main()
        {
            
            Usuario s = new Usuario("ADTP001", "Chepe12", "12345");
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.HvTZ3P;
            this.StartPosition = FormStartPosition.CenterScreen;
            logueado = s;
        }
        
        public Main(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Properties.Resources.HvTZ3P;
            Timer t = new Timer();
            t.Interval = 6000;
            t.Tick += new EventHandler(imagen);
            t.Start();
            logueado = log;
            lblUsuario.Text = logueado.gsUsuario.ToString();
            permi(logueado);
            txtCerrar.Visible = true;
            
           
        }
        /// <summary>
        /// Allows to change the backgroundimage automatically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imagen(object sender, EventArgs e)
        {
            List<Bitmap> b = new List<Bitmap>();
            b.Add(Properties.Resources.ChZ7lj);
            b.Add(Properties.Resources.HvTZ3P);
            b.Add(Properties.Resources.thumb2_nefaz_5299_4k_russian_bus_2017_buses);
            b.Add(Properties.Resources.wp2120757);
            b.Add(Properties.Resources._1860x1050_Volvo_7900_Hybrid_nov_2017);
            b.Add(Properties.Resources.setra_home_neu);
            b.Add(Properties.Resources.Mercedes_Benz_Bus_2017_Tourismo_15_2_RHD_Motion_526455_1280x959);
            int index = DateTime.Now.Second % b.Count;
            this.BackgroundImage = b[index];
        }
        /// <summary>
        /// Allows to do visible the buttons which user has access
        /// </summary>
        /// <param name="lo"></param>
        public void permi(Usuario lo)
        {
             foreach(Control x in this.opciones.Controls)
                {
                    if (x is Button)
                    {
                    x.Visible = lo.tienePermiso(x.AccessibleName);
                    
                    }
                }
               
            }
            
        

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to open the frmTiquetes windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, EventArgs e)
        {
            frmTiquetes d = new frmTiquetes(logueado);
            d.Show();
        }
        /// <summary>
        /// allows to close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Cerrar Secion ?", "Cerrar Sesion", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose(true);
            }
           
            
        }
        /// <summary>
        /// Allows to open the admin windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin m = new frmAdmin(logueado);
            m.Show();
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        /// <summary>
        /// Allows to open the asistent windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, EventArgs e)
        {
            frmAsistente d = new frmAsistente();
            d.Show();
        }
        /// <summary>
        /// Allows to open the packages windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            frmEncomiendas d = new frmEncomiendas(logueado);
            d.Show();
        }
       /// <summary>
       /// Allows to put the hour in a label
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void TmHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            
        }
    }
}
