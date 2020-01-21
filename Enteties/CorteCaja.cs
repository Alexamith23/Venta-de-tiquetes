using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class CorteCaja
    {
        private int numCorte;
        private string codUser;
        private string fecha;
        private string hora;
        private int canTiquetes;
        private double montoVendido;

        public CorteCaja()
        {
        }

        public CorteCaja(int numCorte, string codUser, string fecha, string hora, int canTiquetes, double montoVendido)
        {
            this.numCorte = numCorte;
            this.codUser = codUser;
            this.fecha = fecha;
            this.hora = hora;
            this.canTiquetes = canTiquetes;
            this.montoVendido = montoVendido;
        }

        public int NumCorte { get => numCorte; set => numCorte = value; }
        public string CodUser { get => codUser; set => codUser = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public int CanTiquetes { get => canTiquetes; set => canTiquetes = value; }
        public double MontoVendido { get => montoVendido; set => montoVendido = value; }

        public override string ToString()
        {
            return numCorte + "," + codUser + "," + fecha + "," + hora + "," + canTiquetes + "," + montoVendido;
        }
    }
}
