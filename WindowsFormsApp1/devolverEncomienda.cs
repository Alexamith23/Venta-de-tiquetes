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
    public partial class devolverEncomienda : Form
    {
        private Encomienda enco;
        public devolverEncomienda(Encomienda enc)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            enco = enc;
            cargarTerminales();
            cargarUnidaes();
            cargar();
        }
        public void cargarTerminales()
        {
            EncomiendaBOL us = new EncomiendaBOL();
            List<Terminal> lst = us.cargarTerminales();
            foreach (Terminal x in lst)
            {
                cbxTerminal.Items.Add(x.Codigo);
            }
        }
        public void cargarUnidaes()
        {
            EncomiendaBOL us = new EncomiendaBOL();
            List<Unidad> lst = us.cargarUnidades();
            foreach (Unidad x in lst)
            {
                cbxUnidad.Items.Add(x.Codigo);
            }
        }
        private void cargar()
        {
            txtEncomienda.Text = enco.GSNumEncomienda;
            txtCodUser.Text = enco.GSCodUser;
            txtNombre.Text = enco.GSNomReceptor;
            txtPago.Text = Convert.ToString(enco.GSPrecio);
            cbxTerminal.SelectedItem = enco.GSCodTerminal;
            cbxUnidad.SelectedItem = enco.GSCodUnidad;
            DateTime userDate = DateTime.ParseExact(enco.GSFecha, "dd/MM/yyyy", null);
            dtpFecha.Value = userDate;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                EncomiendaBOL d = new EncomiendaBOL();
                Encomienda u = new Encomienda();
                u.GSNumEncomienda = txtEncomienda.Text.Trim();
                u.GSCodUser = txtCodUser.Text.Trim();
                string Text = dtpFecha.Value.ToString("dd/MM/yyyy");
                u.GSFecha = Text;
                u.GSNomReceptor = txtNombre.Text.Trim();
                u.GSCodTerminal = cbxTerminal.SelectedItem.ToString();
                u.GSCodUnidad = cbxUnidad.SelectedItem.ToString();
                u.GSPrecio = Convert.ToDouble(txtPago.Text.Trim());
                u.GSEntregado = Convert.ToBoolean(enco.GSEntregado);
                d.reenviarEncomienda(u);
                Dispose();

            }
            catch(Exception be)
            {
                MessageBox.Show("Accion no ejecutada");
            }
        }
    }
}
