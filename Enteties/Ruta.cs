using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
   public class Ruta
    {
        private String identificador;
        private string nombre;
        private string descripcion;

        public Ruta()
        {

        }
        public Ruta(string identificador, string nombre, string descripcion)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.descripcion = descripcion;

        }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return identificador + "," + nombre + "," + descripcion;
        }
    }
}
