using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Pasajero
    {
        private string passport;
        private string nombre;
        private string vigencia;
        private string fecViaje;
        private string fecRegreso;
        private string motivoViaje;
        private string horaSalida;
        private string lugarSalida;
        private string destino;

        public Pasajero()
        {
        }

        public Pasajero(string passport, string nombre, string vigencia, string fecViaje, string fecRegreso, string motivoViaje, string horaSalida, string lugarSalida, string destino)
        {
            this.passport = passport;
            this.nombre = nombre;
            this.vigencia = vigencia;
            this.fecViaje = fecViaje;
            this.fecRegreso = fecRegreso;
            this.motivoViaje = motivoViaje;
            this.horaSalida = horaSalida;
            this.lugarSalida = lugarSalida;
            this.destino = destino;
        }

        public string Passport { get => passport; set => passport = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Vigencia { get => vigencia; set => vigencia = value; }
        public string FecViaje { get => fecViaje; set => fecViaje = value; }
        public string FecRegreso { get => fecRegreso; set => fecRegreso = value; }
        public string MotivoViaje { get => motivoViaje; set => motivoViaje = value; }
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string LugarSalida { get => lugarSalida; set => lugarSalida = value; }
        public string Destino { get => destino; set => destino = value; }
        public override string ToString()
        {
            return passport + "," + nombre + "," + vigencia + "," + fecViaje + "," + fecRegreso + "," + motivoViaje + "," + horaSalida + "," + lugarSalida + "," + destino;
        }
    }
}
