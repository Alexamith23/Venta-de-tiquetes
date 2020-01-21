using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Encomienda
    {
        private string numEncomienda;
        private string codUser;
        private string fecha;
        private string nomReceptor;
        private string codTerminal;
        private string codUnidad;
        private double precio;
        private bool entregado;

        public Encomienda()
        {
        }

        public Encomienda(string numEncomienda, string codUser, string fecha, string nomReceptor, string codTerminal, string codUnidad, double precio, bool entregado)
        {
            this.numEncomienda = numEncomienda;
            this.codUser = codUser;
            this.fecha = fecha;
            this.nomReceptor = nomReceptor;
            this.codTerminal = codTerminal;
            this.codUnidad = codUnidad;
            this.precio = precio;
            this.entregado = entregado;
        }

        public string GSNumEncomienda { get => numEncomienda; set => numEncomienda = value; }
        public string GSCodUser { get => codUser; set => codUser = value; }
        public string GSFecha { get => fecha; set => fecha = value; }
        public string GSCodTerminal { get => codTerminal; set => codTerminal = value; }
        public string GSCodUnidad { get => codUnidad; set => codUnidad = value; }
        public double GSPrecio { get => precio; set => precio = value; }
        public string GSNomReceptor { get => nomReceptor; set => nomReceptor = value; }
        public bool GSEntregado { get => entregado; set => entregado = value; }
        

        public override string ToString()
        {
            return numEncomienda + "," + codUser + "," + fecha + "," +nomReceptor+","+ codTerminal + "," + codUnidad + "," + precio + "," +entregado;
        }
    }
}
