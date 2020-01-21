using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Permiso
    {
        private string usuario;
        private string ventana;

        public Permiso()
        {

        }

        public Permiso(string usuario, string ventana)
        {
            this.usuario = usuario;
            this.ventana = ventana;
        }
        public string GSUsuario { get => usuario; set => usuario = value; }
        public string GSVentana { get => ventana; set => ventana = value; }
        public override string ToString()
        {
            return usuario+","+ventana;
        }
    }
}
