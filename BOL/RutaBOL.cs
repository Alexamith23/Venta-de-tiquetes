using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using DAL;

namespace BOL
{
    public class RutaBOL
    {
        /// <summary>
        /// It allows to validate that the data of a Route are not null or incorrect.
        /// </summary>
        /// <param name="x">Object type Ruta</param>
        private void validarRuta(Ruta x)
        {
            if (String.IsNullOrEmpty(x.Identificador))
            {
                throw new Exception("Identificador de Ruta Requerida");
            }
            if (String.IsNullOrEmpty(x.Nombre))
            {
                throw new Exception("Nombre de Ruta Requerido");
            }
            if (String.IsNullOrEmpty(x.Descripcion))
            {
                throw new Exception("Descripcion de Ruta Requerido");
            }
        }
        /// <summary>
        /// Allows registering a new Route
        /// </summary>
        /// <param name="u">Object type Ruta</param>
        public void registrarRuta(Ruta u)
        {
            validarRuta(u);
            RutaDAL d = new RutaDAL();
            d.registrarRuta(u);
        }
        /// <summary>
        ///  allows to generate a list of all Routes registered in the system
        /// </summary>
        /// <returns>list of all Routes registered in the system</returns>
        public List<Ruta> cargarRutas()
        {
            RutaDAL d = new RutaDAL();
            List<Ruta> m = d.cargarRutas();
            return m;
        }
        /// <summary>
        /// Allows to eliminate a specific Route
        /// </summary>
        /// <param name="nombre">code of the route</param>
        public void eliminarRuta(string nombre)
        {
            RutaDAL d = new RutaDAL();
            d.eliminarRuta(nombre);
        }
        /// <summary>
        /// Allows to edit a Route
        /// </summary>
        /// <param name="actual">Code of the Route</param>
        /// <param name="u">Route who was edited</param>
        public void editarRuta(string actual, Ruta u)
        {
            RutaDAL d = new RutaDAL();
            d.editarRuta(actual,u);
        }
    }
}
