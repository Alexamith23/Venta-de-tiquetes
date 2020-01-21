using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class CierreCaja
    {
        private string usuario;
        private string fecha;
        private double monto;

        public CierreCaja()
        {
        }

        public CierreCaja(string usuario, string fecha, double monto)
        {
            this.usuario = usuario;
            this.fecha = fecha;
            this.monto = monto;
        }

        public string GSUsuario { get => usuario; set => usuario = value; }
        public string GSFecha { get => fecha; set => fecha = value; }
        public double GSMonto { get => monto; set => monto = value; }
        public override string ToString()
        {
            return usuario + "," + fecha + "," + monto;
        }

       
    }
}
