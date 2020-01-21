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
    public partial class frmPasajero : Form
    {
        public frmPasajero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Allows to register a new Passenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            TiquetesBOL x = new TiquetesBOL();
            Pasajero d = new Pasajero();
            d.Passport = txtPassport.Text.Trim();
            d.Nombre = txtNombre.Text.Trim();
            d.Vigencia = dtVigencia.Value.ToString("dd/MM/yyyy");
            d.FecViaje = dtFechaViaje.Value.ToString("dd/MM/yyyy");
            d.FecRegreso = dtFechaRegreso.Value.ToString("dd/MM/yyyy");
            d.MotivoViaje= txtMotViaje.Text.Trim();
            d.HoraSalida = txtHoraSalida.Text.Trim();
            d.LugarSalida = cbxTerSalida.SelectedItem.ToString();
            d.Destino= cbxTerSalida.SelectedItem.ToString();
            x.registrarPasajero(d);



        }
    }
}
