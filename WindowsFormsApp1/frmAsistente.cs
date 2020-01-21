using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAsistente : Form
    {
        public frmAsistente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Allows to open a new routes Register windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRutas_Click(object sender, EventArgs e)
        {
            CrudRutas z = new CrudRutas();
            z.Show();
        }
        /// <summary>
        /// Allows to open a new schedule Register windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHorarios_Click(object sender, EventArgs e)
        {
            CrudHorario z = new CrudHorario();
            z.Show();
        }
        /// <summary>
        /// Allows to open a new buses Register windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUnidades_Click(object sender, EventArgs e)
        {
            CrudUnidad z = new CrudUnidad();
            z.Show();
        }
        /// <summary>
        /// Allows to open a new terminals Register windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTerminales_Click(object sender, EventArgs e)
        {
            CrudTerminales z = new CrudTerminales();
            z.Show();
        }
        /// <summary>
        /// Allows to open a new frmArqueo windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnArqueo_Click(object sender, EventArgs e)
        {
            try
            {
                frmArqueo x = new frmArqueo();
                x.Show();
            }catch(Exception be)
            {
                MessageBox.Show("Accion no ejecutada");
            }
        }
        /// <summary>
        /// Allows to open a new user Reports windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes x = new Reportes();
                x.Show();
            }catch(Exception be)
            {
                MessageBox.Show("Accion no ejecutada");
            }
        }
    }
}
