using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using DAL;

namespace BOL
{
    public class UnidadBOL
    {
        /// <summary>
        /// allows to validate that the data of a bus are not null or incorrect.
        /// </summary>
        /// <param name="x">Object type Unidad</param>
        private void validarunidad(Unidad x)
        {
            if (String.IsNullOrEmpty(x.Codigo))
            {
                throw new Exception("Codigo de Unidad Requerido");
            }
            if (String.IsNullOrEmpty(x.GSNumMotor))
            {
                throw new Exception("Numero de Motor Requerido");
            }
            if (String.IsNullOrEmpty(x.GSNumPlaca))
            {
                throw new Exception("Placa Requerida");
            }
            if (String.IsNullOrEmpty(x.GSModelo))
            {
                throw new Exception("Modelo Requerido");
            }
            if (String.IsNullOrEmpty(x.GSFechaVigencia))
            {
                throw new Exception("Fecha Requerido");
            }
            if (String.IsNullOrEmpty(x.GSColor))
            {
                throw new Exception("Color Requerido");
            }
            if (String.IsNullOrEmpty(x.GSRutaAsignada))
            {
                throw new Exception("Ruta Requerida");
            }
            if (String.IsNullOrEmpty(x.GSPermisoTransito))
            {
                throw new Exception("Permiso Requerido");
            }
            if(x.GSCapacidad>70 || x.GSCapacidad < 1)
            {
                throw new Exception("La capacidad del autobus no puede\n" +
                    " ser mayor a 70 ni menor de 1");
            }
        }
        /// <summary>
        /// Allows to register a new bus
        /// </summary>
        /// <param name="t">Object type Unidad which will be registered</param>
        public void registrarUnidad(Unidad u)
        {
            validarunidad(u);
            UnidadDAL m = new UnidadDAL();
            m.registrarUnidad(u);
        }
        /// <summary>
        /// Allows to charge a list of all buses
        /// </summary>
        /// <returns>list of buses</returns>
        public List<Unidad> cargarUnidades()
        {
            UnidadDAL m = new UnidadDAL();
            List<Unidad> n= m.cargarUnidades();
            return n;
        }
        /// <summary>
        /// Allows to eliminate a specific bus
        /// </summary>
        /// <param name="nombre">Code of the bus that will be eliminate</param>
        public void eliminarUnidad(string nombre)
        {
            UnidadDAL m = new UnidadDAL();
            m.eliminarUnidad(nombre);
        }
        /// <summary>
        /// Allows to charge a list of all routes
        /// </summary>
        /// <returns>list of routes</returns>
        public List<Ruta> cargarRutas()
        {
            UnidadDAL m = new UnidadDAL();
            List<Ruta> n = m.cargarRutas();
            return n;
        }
        /// <summary>
        /// Allows to update information of a specific bus
        /// </summary>
        /// <param name="actual">code of the bus </param>
        /// <param name="u">Updated information of the bus</param>
        public void editarUnidades(string actual, Unidad u)
        {
            validarunidad(u);
            UnidadDAL m = new UnidadDAL();
            m.editarUnidades(actual, u);
        }
        /// <summary>
        /// Allows to charge a list of buses with the same route
        /// </summary>
        /// <param name="v">name of the route</param>
        /// <returns>list of buses with the same route</returns>
        public List<Unidad> cargarUnidadesRuta(string v)
        {
            UnidadDAL m = new UnidadDAL();
            List<Unidad> d=m.cargarUnidadesRuta(v);
            return d;
        }
    }
}
