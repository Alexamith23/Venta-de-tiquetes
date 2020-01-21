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
    public partial class frmTiquetes : Form
    {
        private Usuario logueado;
        public frmTiquetes(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logueado = log;
        }
        /// <summary>
        /// Allows to open the CajaTiquetes Windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            CajaTiquetes x = new CajaTiquetes(logueado);
            x.Show();
        }
        /// <summary>
        /// Allows to open the VentaTiquetes Windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            VentaTiquetes x = new VentaTiquetes(logueado);
            x.Show();
        }
        /// <summary>
        /// Allows to open the corteCaja Windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            corteCaja x = new corteCaja(logueado);
            x.Show();
        }
    }
}
