using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using DAL;

namespace BOL
{
    public class TiquetesBOL
    {
        /// <summary>
        /// allows to validate that the data of a TiqueteNacional are not null or incorrect.
        /// </summary>
        /// <param name="z">Object type TiqueteNacional</param>
        public void validarTiqNac(TiqueteNacional z)
        {
            DateTime fecha = Convert.ToDateTime(z.GSFecha);
            int numerodias = (fecha - DateTime.Now).Days;

            if (String.IsNullOrEmpty(z.GSFecha))
            {
                throw new Exception("Fecha de viaje Requerida");
            }
           
            if (numerodias < 0)
            {
                throw new Exception("El tiquete debe de poseer una Fecha Vigente");
            }
            if (String.IsNullOrEmpty(z.GSAsiento))
            {
                throw new Exception("Numero de asiento Requerido");
            }
            if (String.IsNullOrEmpty(z.FechaVenta))
            {
                throw new Exception("Fecha de venta Requerido");
            }
            if (String.IsNullOrEmpty(Convert.ToString(z.Monto)))
            {
                throw new Exception("Monto Requerido");
            }
            if (String.IsNullOrEmpty(z.GSTerminalLLegada))
            {
                throw new Exception("Terminal de Llegada Requerida");
            }
            if (String.IsNullOrEmpty(z.GSTerminalSalida))
            {
                throw new Exception("Terminal de Salida Requerida");
            }
            if (z.Monto<0)
            {
                throw new Exception("El monto debe ser Positivo");
            }
        }
        /// <summary>
        /// Allows to generate the consecutive number of each cash register
        /// </summary>
        /// <returns>num of the consecutive cash register </returns>
        public int numeroCorte()
        {
            TiquetesDAL x = new TiquetesDAL();
            int a=x.numeroCorte()+1;
            return a;
        }
        /// <summary>
        /// Allows to register a new TiqueteNacional
        /// </summary>
        /// <param name="t">Object type TiqueteNacional which will be registered</param>
        public void registrarTiqueteNac(TiqueteNacional d)
        {
            validarTiqNac(d);
            TiquetesDAL x = new TiquetesDAL();
            x.registrarTiqNac(d);
        }
        /// <summary>
        /// Allows to charge the availables bus seats for a specific date 
        /// </summary>
        /// <param name="fec">specific date </param>
        /// <param name="hora">specific Hour </param>
        /// <returns>List of numbers of the available bus seats</returns>
        public List<int> camposDisponibles(string fec,string hora)
        {
            TiquetesDAL x = new TiquetesDAL();
            List<int> c=x.camposDisponibles(fec,hora);
            List<int> a = x.camposDisponiblesInter(fec, hora);
            foreach(int az in a)
            {
                c.Add(az);
            }
            return c;
        }
        /// <summary>
        /// Allows to register a new cash register
        /// </summary>
        /// <param name="d">Object type CorteCaja</param>
        public void registrarCorteCaja(CorteCaja d)
        {
            validarCorte(d);
            TiquetesDAL x = new TiquetesDAL();
            x.registrarCorteCaja( d);
        }
        /// <summary>
        /// allows to validate that the data of a CorteCaja are not null or incorrect.
        /// </summary>
        /// <param name="d">Object type CorteCaja</param>
        public void validarCorte(CorteCaja d)
        {
            if (String.IsNullOrEmpty(d.CodUser))
            {
                throw new Exception("Codigo de Usuario Requerido");
            }
            if (String.IsNullOrEmpty(d.Fecha))
            {
                throw new Exception("Fecha Requerida");
            }
            if (String.IsNullOrEmpty(Convert.ToString(d.MontoVendido)))
            {
                throw new Exception("Monto Requerido");
            }

        }
        /// <summary>
        /// Allows to register a new Passenger
        /// </summary>
        /// <param name="d">Object Type Pasajero</param>
        public void registrarPasajero(Pasajero d)
        {
            validarPasajero(d);
            TiquetesDAL x = new TiquetesDAL();
            x.registrarPasajero(d);
        }
        /// <summary>
        /// allows to validate that the data of a TiqueteInternacional are not null or incorrect.
        /// </summary>
        /// <param name="ti">Object type TiqueteInternacional</param>
        private void validarTiqInter(TiqueteInternacional ti)
        {
            DateTime fecha = Convert.ToDateTime(ti.Fecha);
            int numerodias = (fecha - DateTime.Now).Days;
            
            if (String.IsNullOrEmpty(ti.Fecha))
            {
                throw new Exception("Fecha de viaje Requerida");
            }
            if (numerodias < 6)
            {
                throw new Exception("El tiquete debe de poseer una semana de anticipación");
            }
            if (numerodias < 0)
            {
                throw new Exception("El tiquete debe de poseer una Fecha Vigente");
            }
            if (String.IsNullOrEmpty(ti.Asiento))
            {
                throw new Exception("Numero de asiento Requerido");
            }
            if (String.IsNullOrEmpty(ti.CodUnidad))
            {
                throw new Exception("Codigo de unidad Requerido");
            }
            if (String.IsNullOrEmpty(ti.FechaVenta))
            {
                throw new Exception("Fecha de Venta Requerida");
            }
            if (String.IsNullOrEmpty(ti.Horasalida))
            {
                throw new Exception("Hora de Salida Requerida");
            }
            if (String.IsNullOrEmpty(Convert.ToString(ti.Monto)))
            {
                throw new Exception("Monto Requerido");
            }
            if (String.IsNullOrEmpty(ti.NumPassport))
            {
                throw new Exception("Numero de Pasaporte Requerido");
            }
            if (ti.Monto < 0)
            {
                throw new Exception("El monto debe ser Positivo Requerido");
            }
            if (String.IsNullOrEmpty(ti.TerminalLLegada))
            {
                throw new Exception("Destino Requerido");
            }
            if (String.IsNullOrEmpty(ti.TerminalSalida))
            {
                throw new Exception("Terminal De Salida Requerida");
            }


        }
        /// <summary>
        /// allows to validate that the data of a Passenger are not null or incorrect.
        /// </summary>
        /// <param name="d">Object type Pasajero</param>
        private void validarPasajero(Pasajero d)
        {
            int asd = Math.Abs((DateTime.Now.Month - DateTime.ParseExact(d.Vigencia, "dd/MM/yyyy", null).Month) + 12 * (DateTime.Now.Year - DateTime.ParseExact(d.Vigencia, "dd/MM/yyyy", null).Year));
            if (String.IsNullOrEmpty(d.Passport))
            {
                throw new Exception("Digite el numero de Pasaporte");
            }
            if (String.IsNullOrEmpty(d.Vigencia))
            {
                throw new Exception("Fecha de Vigencia de pasaporte Requerida");
            }
            if (String.IsNullOrEmpty(d.Nombre))
            {
                throw new Exception("Nombre de Pasajero Requerido");
            }
            if (String.IsNullOrEmpty(d.MotivoViaje))
            {
                throw new Exception("Motivo de viaje Requerido");
            }
            if (String.IsNullOrEmpty(d.LugarSalida))
            {
                throw new Exception("Terminal de Salida Requerida");
            }
            if (String.IsNullOrEmpty(d.FecRegreso))
            {
                throw new Exception("Fecha de Regreso Requerida");
            }
            if (String.IsNullOrEmpty(d.FecViaje))
            {
                throw new Exception("Fecha de Viaje Requerida");
            }
            if (String.IsNullOrEmpty(d.HoraSalida))
            {
                throw new Exception("Hora de Salida Requerida");
            }
            if (asd<6)
            {
                throw new Exception("La fecha Del Pasaporte se encuentra a menos de 6 meses de vencerse");
            }

        }
        /// <summary>
        /// Allows to generate the amount of money that a user has generate during the day
        /// </summary>
        /// <param name="user">Username who will do the cahs register </param>
        public double CierreCaja(string user)
        {
            TiquetesDAL x = new TiquetesDAL();
            double d=x.MontoUsuario(user);
            d+= 20000;
            return d;
        }
        /// <summary>
        /// Allows to register a new cash register
        /// </summary>
        /// <param name="d">Username who do the cash register </param>
        public void registrarCierreCaja(CierreCaja d)
        {
            TiquetesDAL x = new TiquetesDAL();
            x.registrarCierreCaja(d);
        }
        /// <summary>
        /// Allows to register a new arqueoCaja
        /// </summary>
        /// <param name="d">Object type CierreCaja to generate a new arqueoCaja</param>
        public void arqueoDeCaja(CierreCaja d)
        {
            TiquetesDAL x = new TiquetesDAL();
            x.arqueoDeCaja(d);
        }
        /// <summary>
        /// Allows to charge a list of all international tickets sold in a specific date to make an cash register
        /// </summary>
        /// <param name="info"> Object type CierreCaja to find the specific tickets</param>
        /// <returns>list of international tickets</returns>
        public List<TiqueteInternacional> cargarTiquetesInterArq(CierreCaja info)
        {
            TiquetesDAL x = new TiquetesDAL();
            List<TiqueteInternacional> d = x.cargarTiquetesInterArq(info);
            return d;
        }
        /// <summary>
        /// Allows to charge a list of all sold national tickets  in a specific date to make an cash register
        /// </summary>
        /// <param name="info"> Object type CierreCaja to find the specific tickets</param>
        /// <returns>list of national tickets</returns>
        public List<TiqueteNacional> cargarTiquetesArq(CierreCaja info)
        {
            TiquetesDAL x = new TiquetesDAL();
            List<TiqueteNacional> d=x.cargarTiquetesNacArq(info);
            return d;
        }

        /// <summary>
        /// Allows to charge the availables bus seats for a specific date 
        /// </summary>
        /// <param name="fec">specific date </param>
        /// <param name="v">specific Hour </param>
        /// <returns>List of numbers of the available bus seats</returns>
        public List<int> camposDisponiblesInter(string fec, string v)
        {
            TiquetesDAL x = new TiquetesDAL();
            List<int> c = x.camposDisponiblesInter(fec, v);
            List<int> a = x.camposDisponibles(fec, v);
            foreach(int za in a)
            {
                c.Add(za);
            }
            return c;
        }
        /// <summary>
        /// Allows to register a new international ticket
        /// </summary>
        /// <param name="z">Object Type TiqueteInternacional</param>
        public void registrarTiqInt(TiqueteInternacional z)
        {
            validarTiqInter(z);
            TiquetesDAL x = new TiquetesDAL();
            x.registrarTiqInter(z);
        }
 
    }
}
