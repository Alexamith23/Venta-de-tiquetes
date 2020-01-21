using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using DAL;

namespace BOL
{
    public class EncomiendaBOL
    {
        /// <summary>
        /// Allows to validate de schedule data
        /// </summary>
        /// <param name="x">Object that will be validated</param>
        private void validarHorario(Encomienda x)
        {
            if (String.IsNullOrEmpty(x.GSNumEncomienda))
            {
                throw new Exception("Codigo de Horario Requerido");
            }
            if (String.IsNullOrEmpty(x.GSCodUser))
            {
                throw new Exception("Codigo de Ruta Requerido");
            }
            if (String.IsNullOrEmpty(x.GSFecha))
            {
                throw new Exception("Codigo de Terminal Requerido");
            }
            if (String.IsNullOrEmpty(x.GSNomReceptor))
            {
                throw new Exception("Dia de la semana Requerida");
            }
            if (String.IsNullOrEmpty(x.GSCodTerminal))
            {
                throw new Exception("Hora de salida Requerida");
            }
            if (String.IsNullOrEmpty(x.GSCodUnidad))
            {
                throw new Exception("Hora de llegada Requerida");
            }
           
        }
        /// <summary>
        /// Allows to generate a continuos number of ships
        /// </summary>
        /// <returns>the number of the last ship plus one</returns>
        public int numEncomienda()
        {
            EncomiendaDAL c = new EncomiendaDAL();
            int x = c.numEncomienda() + 1;
            return x;
        }

        /// <summary>
        /// returns a CierreCaja Object list
        /// </summary>
        /// <returns>returns a CierreCaja Object list</returns>
        public List<CierreCaja> cargarArqueoDeCaja()
        {
            EncomiendaDAL c = new EncomiendaDAL();
            List<CierreCaja> s = c.cargarArqueoCaja();
            return s;
        }
        /// <summary>
        /// returns a Encomienda Object list
        /// </summary>
        /// <returns>returns a CierreCaja Object list</returns>
        public List<Encomienda> cargarEncomiendas()
        {
            EncomiendaDAL c = new EncomiendaDAL();
            List<Encomienda> s = c.CargarEncomiendas();
            return s;
        }
        /// <summary>
        /// Allows registering a new Encomienda
        /// </summary>
        /// <param name="u">Ocject type Encomienda</param>
        public void registrarEncomienda(Encomienda u)
        {
            validarHorario(u);
            EncomiendaDAL c = new EncomiendaDAL();
            c.registrarEncomienda(u);
        }
        /// <summary>
        /// Allows to resend a package 
        /// </summary>
        /// <param name="u"> Ocject type Encomienda</param>
        public void reenviarEncomienda(Encomienda u)
        {
            validarHorario(u);
            EncomiendaDAL c = new EncomiendaDAL();
            c.reenviarEncomienda(u);
        }
        /// <summary>
        /// allows to generate a list of all registered terminals
        /// </summary>
        /// <returns>list of all registered terminals</returns>
        public List<Terminal> cargarTerminales()
        {
            EncomiendaDAL c = new EncomiendaDAL();
            List<Terminal> s = c.cargarTerminales();
            return s;
        }
        /// <summary>
        /// allows to generate a list of all sent packages by a specific user
        /// </summary>
        /// <param name="user">Ocject type CierreCaja to find all sent packages by the user </param>
        /// <returns>list of all sent packages</returns>
        public List<Encomienda> cargarEncomiendasArq(CierreCaja user)
        {
            EncomiendaDAL c = new EncomiendaDAL();
            List<Encomienda> s = c.cargarEncomiendasArq(user);
            return s;
        }

        /// <summary>
        /// Allows to do the cash register
        /// </summary>
        /// <param name="user">user code who did the cash register</param>
        /// <returns>amount of money that the user registered during the day plus 5 thousand colons</returns>
        public double CierreCaja(string user)
        {
            try
            {
                EncomiendaDAL c = new EncomiendaDAL();
                double x = c.CierreCaja(user);
                x += 5000;
                return x;
            }catch(Exception be)
            {
                throw new Exception("El usuario no fue encntrado");
            }

        }
        /// <summary>
        /// Allows to register a new cash register when the amount of money is different to the system
        /// </summary>
        /// <param name="d">Object type CierreCaja which contains the information to create a new cash register</param>
        public void arqueoDeCaja(CierreCaja d)
        {
            EncomiendaDAL c = new EncomiendaDAL();
            c.arqueoDeCaja(d);
        }
        /// <summary>
        /// allows you to register that a package was delivered
        /// </summary>
        /// <param name="u">Object type Encomienda</param>
        public void entregarEncomienda(Encomienda u)
        {
            EncomiendaDAL c = new EncomiendaDAL();
            c.entregarEncomienda(u);
        }
        /// <summary>
        /// Allows to eliminate a package registered in the system
        /// </summary>
        /// <param name="nombre">Number of Package code</param>
        public void eliminarEncomienda(string nombre)
        {
            EncomiendaDAL c = new EncomiendaDAL();
            c.eliminarEncomienda(nombre);
        }
        /// <summary>
        /// Allows to register a new cash Register
        /// </summary>
        /// <param name="d">Object type CierreCaja</param>
        public void registrarCierreCaja(CierreCaja d)
        {
            EncomiendaDAL c = new EncomiendaDAL();
            c.registrarCierreCaja(d);
        }
        /// <summary>
        /// Allows to generate a LIST of object type Unidad
        /// </summary>
        /// <returns>LIST of object type Unidad</returns>
        public List<Unidad> cargarUnidades()
        {
            EncomiendaDAL c = new EncomiendaDAL();
            List<Unidad> s = c.cargarUnidades();
            return s;
        }
        /// <summary>
        /// Allows to  generate a LIST of Encomiendas using a filter 
        /// </summary>
        /// <param name="v">Name of the person who withdrew the package</param>
        /// <returns></returns>
        public List<Encomienda> cargarEncomiendas(string v)
        {
            EncomiendaDAL c = new EncomiendaDAL();
            List<Encomienda> s = c.cargarEncomiendas(v);
            return s;
        }
        /// <summary>
        /// Allows to generate a list of CierreCaja did by a especific user
        /// </summary>
        /// <param name="v">Code of the user</param>
        /// <returns> list of CierreCaja</returns>
        public List<CierreCaja> cargarArqueoDeCaja(string v)
        {
            EncomiendaDAL c = new EncomiendaDAL();
            List<CierreCaja> x=c.cargarArqueoDeCaja(v);
            return x;
        }
    }
}
