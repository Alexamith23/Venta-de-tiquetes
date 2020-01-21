using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class TiqueteInternacional
    {
        private int numTiquete;
        private string numPassport;
        private string fecha;
        private string asiento;
        private string codUnidad;
        private string horasalida;
        private string terminalSalida;
        private string terminalLLegada;
        private bool equipaje;
        private int numEquipaje;
        private double monto;
        private string vendedor;
        private string fechaVenta;

        public TiqueteInternacional()
        {
        }

        public TiqueteInternacional(int numTiquete, string numPassport, string fecha, string asiento, string codUnidad, string horasalida, string terminalSalida, string terminalLLegada, bool equipaje, int numEquipaje, double monto, string vendedor, string fechaVenta)
        {
            this.numTiquete = numTiquete;
            this.numPassport = numPassport;
            this.fecha = fecha;
            this.asiento = asiento;
            this.codUnidad = codUnidad;
            this.horasalida = horasalida;
            this.terminalSalida = terminalSalida;
            this.terminalLLegada = terminalLLegada;
            this.equipaje = equipaje;
            this.numEquipaje = numEquipaje;
            this.monto = monto;
            this.vendedor = vendedor;
            this.fechaVenta = fechaVenta;
        }

        public int NumTiquete { get => numTiquete; set => numTiquete = value; }
        public string NumPassport { get => numPassport; set => numPassport = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Asiento { get => asiento; set => asiento = value; }
        public string CodUnidad { get => codUnidad; set => codUnidad = value; }
        public string Horasalida { get => horasalida; set => horasalida = value; }
        public string TerminalSalida { get => terminalSalida; set => terminalSalida = value; }
        public string TerminalLLegada { get => terminalLLegada; set => terminalLLegada = value; }
        public bool Equipaje { get => equipaje; set => equipaje = value; }
        public int NumEquipaje { get => numEquipaje; set => numEquipaje = value; }
        public double Monto { get => monto; set => monto = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public string FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public override string ToString()
        {
            return numTiquete + "," +numPassport+","+ fecha + "," + asiento + "," +codUnidad+","+ horasalida + "," + terminalSalida + "," + terminalLLegada + "," + equipaje + "," + numEquipaje + "," + monto + "," + vendedor + "," + FechaVenta;
        }
    }
}
