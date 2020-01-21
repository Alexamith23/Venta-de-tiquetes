using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class TiqueteNacional
    {
        private int numTiquete;
        private string fecha;
        private string asiento;
        private string horasalida;
        private string terminalSalida;
        private string terminalLLegada;
        private bool equipaje;
        private int numEquipaje;
        private double monto;
        private string vendedor;
        private string fechaVenta;

        public TiqueteNacional()
        {
        }

        public TiqueteNacional(int numTiquete, string fecha, string asiento, string horasalida, string terminalSalida, string terminalLLegada, bool equipaje, int numEquipaje,double monto,string vendedor,string fechaVenta)
        {
            this.numTiquete = numTiquete;
            this.fecha = fecha;
            this.asiento = asiento;
            this.horasalida = horasalida;
            this.terminalSalida = terminalSalida;
            this.terminalLLegada = terminalLLegada;
            this.equipaje = equipaje;
            this.numEquipaje = numEquipaje;
            this.monto = monto;
            this.vendedor = vendedor;
            this.fechaVenta = fechaVenta;
        }

        public int GSNumTiquete { get => numTiquete; set => numTiquete = value; }
        public string GSFecha { get => fecha; set => fecha = value; }
        public string GSAsiento { get => asiento; set => asiento = value; }
        public string GSHorasalida { get => horasalida; set => horasalida = value; }
        public string GSTerminalSalida { get => terminalSalida; set => terminalSalida = value; }
        public string GSTerminalLLegada { get => terminalLLegada; set => terminalLLegada = value; }
        public bool GSEquipaje { get => equipaje; set => equipaje = value; }
        public int GSNumEquipaje { get => numEquipaje; set => numEquipaje = value; }
        public double Monto { get => monto; set => monto = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public string FechaVenta { get => fechaVenta; set => fechaVenta = value; }

        public override string ToString()
        {
            return numTiquete + "," + fecha + "," + asiento + "," + horasalida + "," + terminalSalida + "," + terminalLLegada + "," + equipaje + "," + numEquipaje+","+monto+","+vendedor+","+FechaVenta;
        }
    }
}
