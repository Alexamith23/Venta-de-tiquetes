using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using DAL;

namespace BOL
{
    public class HorarioBOL
    {
        /// <summary>
        /// It allows to validate that the data of a schedule are not null or incorrect.
        /// </summary>
        /// <param name="x">Objec type Horario </param>
        private void validarHorario(Horario x)
        {
            if (String.IsNullOrEmpty(x.GSidHorario))
            {
                throw new Exception("Codigo de Horario Requerido");
            }
            if (String.IsNullOrEmpty(x.GSidRuta))
            {
                throw new Exception("Codigo de Ruta Requerido");
            }
            if (String.IsNullOrEmpty(x.GSidTerminal))
            {
                throw new Exception("Codigo de Terminal Requerido");
            }
            if (String.IsNullOrEmpty(x.GSdia))
            {
                throw new Exception("Dia de la semana Requerida");
            }
            if (String.IsNullOrEmpty(x.GSHoraSalida))
            {
                throw new Exception("Hora de salida Requerida");
            }
            if (String.IsNullOrEmpty(x.GSHoraLlegada))
            {
                throw new Exception("Hora de llegada Requerida");
            }
        }
        /// <summary>
        /// Allows to generate a list of all available schedules
        /// </summary>
        /// <returns>list of all available schedules</returns>
        public List<Horario> cargarHorarios()
        {
            
            HorarioDAL m = new HorarioDAL();
            List<Horario> c = m.cargarHorarios();
            return c;
        }
        /// <summary>
        /// Allows to generate a list of all registered routes
        /// </summary>
        /// <returns>list of all registered routes</returns>
        public List<Ruta> cargarRutas()
        {
            HorarioDAL m = new HorarioDAL();
            List<Ruta> c = m.cargarRutas();
            return c;
        }
        /// <summary>
        /// Allows to generate a list of all registered terminals
        /// </summary>
        /// <returns>list of all registered terminals</returns>
        public List<Terminal> cargarTerminales()
        {
            HorarioDAL m = new HorarioDAL();
            List<Terminal> c = m.cargarTerminales();
            return c;
        }
        /// <summary>
        /// Allows to register a new Schedule
        /// </summary>
        /// <param name="u">Objec type Horario</param>
        public void registrarHorario(Horario u)
        {
            validarHorario(u);
            HorarioDAL m = new HorarioDAL();
            m.registrarHorario(u);
        }
        /// <summary>
        /// Allows to edit a specific Schedule
        /// </summary>
        /// <param name="actual">Horario Code </param>
        /// <param name="u">Horario Edited</param>
        public void editarHorarios(string actual, Horario u)
        {
            HorarioDAL m = new HorarioDAL();
            m.editarHorario(actual,u);
        }
        /// <summary>
        /// Allows to eliminate a specific schedule
        /// </summary>
        /// <param name="nombre">Code of the Horario</param>
        public void eliminarHorario(string nombre)
        {
            HorarioDAL m = new HorarioDAL();
            m.eliminarHorario(nombre);
        }
    }
}
