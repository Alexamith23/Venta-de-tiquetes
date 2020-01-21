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
    public partial class corteCaja : Form
    {
        private Usuario logueado;
        public corteCaja(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtHora.Text= DateTime.Now.ToString("h:mm");
            logueado = log;
            txtUser.Text = logueado.Codigo;
            numCorte();
            
        }
        /// <summary>
        /// Allows to put the consecutive number of cash register number in the txtCorte
        /// </summary>
        public void numCorte()
        {
            TiquetesBOL x = new TiquetesBOL();
            txtCorte.Text = Convert.ToString(x.numeroCorte());
        } 
        private void CorteCaja_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Allows to register a new Cash Register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (existeTiquetero(txtUser.Text.ToString().Trim()))
                {
                    TiquetesBOL x = new TiquetesBOL();
                    CorteCaja d = new CorteCaja();
                    d.NumCorte = Convert.ToInt32(txtCorte.Text.ToString().Trim());
                    d.CodUser = txtUser.Text.ToString().Trim();
                    d.Hora = txtHora.Text.ToString().Trim();
                    d.Fecha = dtFecha.Value.ToString("dd/MM/yyyy");
                    d.CanTiquetes = Convert.ToInt32(txtVendidos.Text.ToString().Trim());
                    d.MontoVendido = Convert.ToDouble(txtMonto.Text.ToString().Trim());
                    x.registrarCorteCaja(d);
                    MessageBox.Show("Corte Registrado", "Cortes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Usuario No Existe", "Cortes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception be)
            {
                MessageBox.Show(be.Message);
            }
        }
        /// <summary>
        /// Allows to know if a user exist
        /// </summary>
        /// <param name="v">userCode</param>
        /// <returns>true if exist otherwise false</returns>
        private bool existeTiquetero(string v)
        {
            UsuarioBOL x = new UsuarioBOL();
           if( x.existeTiquetero(v) == true)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Allows to validate that the user insert only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
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
