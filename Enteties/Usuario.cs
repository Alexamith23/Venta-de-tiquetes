using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Usuario
    {
        private String codigo;
        private string usuario;
        private string password;
        private List<Permiso> accesos;

        public Usuario()
        {
            accesos = new List<Permiso>();
        }
        public Usuario(string codigo, string usuario, string password)
        {
            this.codigo = codigo;
            this.usuario = usuario;
            this.password = password;
            accesos = new List<Permiso>();
        }
        public Boolean tienePermiso(string acceso)
        {
            foreach(Permiso x in accesos)
            {
                if (x.GSVentana.Equals(acceso))
                {
                    return true;
                }
            }
            return false;
        }
        public string Codigo { get => codigo; set => codigo = value; }
        public string gsUsuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public List<Permiso> GSAccesos { get => accesos; set => accesos = value; }
        public override string ToString()
        {
            return codigo + "," + usuario + "," + password;
        }

    }
}
