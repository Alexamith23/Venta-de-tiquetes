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
    public partial class frmEncomiendas : Form
    {
        private Usuario logueado;
        public frmEncomiendas(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logueado = log;
        }
        /// <summary>
        /// Allows to open a new user frmPaquetes windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPaquetes_Click(object sender, EventArgs e)
        {
            frmPaquetes b = new frmPaquetes(logueado);
            b.Show();
        }
        /// <summary>
        /// Allows to open a new frmCaja windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCaja_Click(object sender, EventArgs e)
        {
            frmCaja b = new frmCaja(logueado);
            b.Show();
        }
    }
}
