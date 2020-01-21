using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using DAL;

namespace BOL
{
    public class TerminalBOL
    {
        /// <summary>
        /// allows to validate that the data of a Terminal are not null or incorrect.
        /// </summary>
        /// <param name="x">Object type Terminal</param>
        private void validarTerminal(Terminal x)
        {
            if (String.IsNullOrEmpty(x.Codigo))
            {
                throw new Exception("Codigo de Terminal Requerido");
            }
            if (String.IsNullOrEmpty(x.Nombre))
            {
                throw new Exception("Nombre de Terminal Requerido");
            }
            if (String.IsNullOrEmpty(x.Ubicacion))
            {
                throw new Exception("Ubicacion de Terminal Requerida");
            }
        }
        /// <summary>
        /// Allows to register a new Terminal
        /// </summary>
        /// <param name="t">Object type Terminal which will be registered</param>
        public void registrarTerminal(Terminal t) {
            validarTerminal(t);
            TerminalesDAL c = new TerminalesDAL();
            c.registrarTerminal(t);
        }
        /// <summary>
        /// Allows to eliminate a especific Terminal
        /// </summary>
        /// <param name="nombre">Code of the terminal</param>
        public void eliminarTerminal(string nombre)
        {
            TerminalesDAL c = new TerminalesDAL();
            c.eliminarTerminal(nombre);
        }
        /// <summary>
        /// allows to generate a list of all terminals registered in the system 
        /// </summary>
        /// <returns>list of all terminals registered in the system </returns>
        public List<Terminal> cargarTerminales()
        {
            TerminalesDAL c = new TerminalesDAL();
            List<Terminal> m= c.cargarTerminales();
            
            return m;
        }
        /// <summary>
        /// Allows to edit a specific terminal
        /// </summary>
        /// <param name="actual">code of the terminal</param>
        /// <param name="u">terminal with the edited information</param>
        public void editarTerminales(string actual, Terminal u)
        {
            TerminalesDAL c = new TerminalesDAL();
            c.editarTerminal(actual, u);
        }
    }
}
