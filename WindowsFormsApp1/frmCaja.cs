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
    public partial class frmCaja : Form
    {
        private Usuario logueado;
        public frmCaja(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logueado = log;
            txtUsuario.Text = log.Codigo;
        }
        /// <summary>
        /// Allows to find the user that will do the cash register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                EncomiendaBOL x = new EncomiendaBOL();
                string user = txtUsuario.Text.Trim();
                double monto = x.CierreCaja(user);
                txtMonto.Text = Convert.ToString(monto);

            }
            catch(Exception be)
            {
                MessageBox.Show(be.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Allows to register the cash register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtMonto.Text.Trim()) == Convert.ToDouble(txtMonUser.Text.Trim()))
                {
                    EncomiendaBOL x = new EncomiendaBOL();
                    CierreCaja d = new CierreCaja();
                    d.GSUsuario = txtUsuario.Text.Trim();
                    DateTime fecha = DateTime.Now;
                    string Text = fecha.ToString("dd/MM/yyyy");
                    d.GSMonto = Convert.ToDouble(txtMonUser.Text.Trim());
                    d.GSFecha = Text;
                    x.registrarCierreCaja(d);
                    MessageBox.Show("Cierre de Caja Realizado", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EncomiendaBOL x = new EncomiendaBOL();
                    CierreCaja d = new CierreCaja();
                    d.GSUsuario = txtUsuario.Text.Trim();
                    DateTime fecha = DateTime.Now;
                    string Text = fecha.ToString("dd/MM/yyyy");
                    d.GSMonto = Convert.ToDouble(txtMonUser.Text.Trim());
                    d.GSFecha = Text;
                    x.arqueoDeCaja(d);
                    MessageBox.Show("El monto no coincide con los cortes de caja\nSe realizara un Arqueo de la caja ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception be)
            {
                MessageBox.Show(be.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Allows to input just numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMonUser_KeyPress(object sender, KeyPressEventArgs e)
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
