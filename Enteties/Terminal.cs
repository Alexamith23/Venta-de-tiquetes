using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Terminal
    {
        private String codigo;
        private string nombre;
        private string ubicacion;

        public Terminal()
        {

        }
        public Terminal(string codigo, string nombre, string ubicacion)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.ubicacion = ubicacion;

        }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }

        public override string ToString()
        {
            return codigo + "," + nombre + "," + ubicacion;
        }
    }
}
