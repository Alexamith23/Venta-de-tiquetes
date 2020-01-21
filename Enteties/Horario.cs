using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Horario
    {
        private string ideHorario;
        private string idRuta;
        private string idTerminal;
        private string dia;
        private string horaSalida;
        private string horaLlegada;

        public Horario()
        {
        }

        public Horario(string ideHorario, string idRuta, string idTerminal, string dia, string horaSalida, string horaLlegada)
        {
            this.ideHorario = ideHorario;
            this.idRuta = idRuta;
            this.idTerminal = idTerminal;
            this.dia = dia;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }
        public string GSidHorario { get => ideHorario; set => ideHorario = value; }
        public string GSidRuta { get => idRuta; set => idRuta = value; }
        public string GSidTerminal { get => idTerminal; set => idTerminal = value; }
        public string GSdia { get => dia; set => dia = value; }
        public string GSHoraSalida{ get => horaSalida; set => horaSalida = value; }
        public string GSHoraLlegada { get => horaLlegada; set => horaLlegada = value; }

        public override string ToString()
        {
            return ideHorario + "," + idRuta + "," + idTerminal + "," + dia + "," + horaSalida+","+horaLlegada;
        }
    }
}
