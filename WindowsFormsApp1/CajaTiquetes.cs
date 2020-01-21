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
    public partial class CajaTiquetes : Form
    {
        private Usuario logueado;
        public CajaTiquetes(Usuario log)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logueado = log;
            txtUsuario.Text = logueado.Codigo;
        }

        private void CajaTiquetes_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
       
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtMonSis.Text.Trim()) == Convert.ToDouble(txtMonUser.Text.Trim()))
            {
                TiquetesBOL x = new TiquetesBOL();
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
                TiquetesBOL x = new TiquetesBOL();
                CierreCaja d = new CierreCaja();
                d.GSUsuario = txtUsuario.Text.Trim();
                DateTime fecha = DateTime.Now;
                string Text = fecha.ToString("dd/MM/yyyy");
                d.GSMonto = Convert.ToDouble(txtMonUser.Text.Trim());
                d.GSFecha = Text;
                x.arqueoDeCaja(d);
                MessageBox.Show("El monto no coincide con los cortes de caja\nSe realizara un Arqueo de la caja ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            TiquetesBOL x = new TiquetesBOL();
            string user = txtUsuario.Text.Trim();
            double monto = x.CierreCaja(user);
            txtMonSis.Text = Convert.ToString(monto);
        }

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
