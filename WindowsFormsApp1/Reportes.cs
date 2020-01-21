using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BOL;
using Enteties;

namespace WindowsFormsApp1
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            ReportesBOL c = new ReportesBOL();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            chart1.Titles.Add("Prueba");

           // chart1.Series["Rutas"].Points.AddXY("Enero", "1000");
            //chart1.Series["Rutas"].Points.AddXY("2", "150");
           
            unidadesVencidas();
            unidadesVigentes();
            ;
            


        }
      
        /// <summary>
        /// Allows to charge the amount of money 
        /// </summary>
        public void ventaPorDia() {
            ReportesBOL v = new ReportesBOL();
           // List<TiqueteNacional> x = v.ventaPorDia();
        }
        /// <summary>
        /// Allows to show the buses without available permission
        /// </summary>
        public void unidadesVencidas()
        {
            ReportesBOL v = new ReportesBOL();
            List<Unidad> x = v.UnidadesSinPermiso();
            
            foreach (Unidad a in x)
            {
                chart4.Series["Vencidos"].Points.AddXY(a.Codigo, "150");
            }
        }
        /// <summary>
        /// Allows to show the buses with available permission
        /// </summary>
        public void unidadesVigentes()
        {
            ReportesBOL v = new ReportesBOL();
            List<Unidad> x = v.UnidadesConPermiso();
            foreach (Unidad a in x)
            {
                chart5.Series["Activos"].Points.AddXY(a.Codigo, "150");
            }
        }
        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Chart2_Click(object sender, EventArgs e)
        {

        }

        private void Chart4_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
       
      
       

        private void Reportes_Load(object sender, EventArgs e)
        {

        }
     
        
           
        
        private void TabPage4_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
