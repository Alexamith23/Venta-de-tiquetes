using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace DAL
{
    public class TiquetesDAL
    {
        /// <summary>
        /// Allows to charge the availables bus seats for a specific date 
        /// </summary>
        /// <param name="fec">specific date </param>
        /// <param name="hora">specific Hour </param>
        /// <returns>List of numbers of the available bus seats</returns>
        public List<int> camposDisponibles(string fec,string hora)
        {
            List<int> mas = new List<int>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[10];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("tiqNacional.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[1].Equals(fec) && campos[3].Equals(hora))
                    {
                        mas.Add(Convert.ToInt32(campos[0]));
                    }
                    

                    /*
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                    */
                    cadena = lectura.ReadLine();
                }

                lectura.Close();
                //escribir.Close();
                /*
                File.AppendAllText(@"C:\Users\Usuario\Desktop\temp.txt", "Your Text" + "\n");
                File.Delete(@"C:\Users\Usuario\Desktop\lol.txt");
                File.Move(@"C:\Users\Usuario\Desktop\temp.txt", @"C:\Users\Usuario\Desktop\lol.txt");
                */
                return mas;
            }
            catch (FileNotFoundException fe)
            {

            }
            catch (Exception be)
            {

            }
            return mas;
        }
        /// <summary>
        /// Allows to generate the consecutive number of each cash register
        /// </summary>
        /// <returns>num of the consecutive cash register </returns>
        public int numeroCorte()
        {
            int mayor = 0;
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[11];
            char[] separador = { ',' };
            try
            {
                DateTime fecha = DateTime.Now;
                string Text = fecha.ToString("dd/MM/yyyy");
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("corteCaja.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    
                    int sig = Convert.ToInt32(campos[0]);
                    if (sig > mayor)
                    {
                        mayor = sig;
                    }
                    /*
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                    */
                    cadena = lectura.ReadLine();
                }

                lectura.Close();
                //escribir.Close();
                /*
                File.AppendAllText(@"C:\Users\Usuario\Desktop\temp.txt", "Your Text" + "\n");
                File.Delete(@"C:\Users\Usuario\Desktop\lol.txt");
                File.Move(@"C:\Users\Usuario\Desktop\temp.txt", @"C:\Users\Usuario\Desktop\lol.txt");
                */
                return mayor;

            }
            catch (FileNotFoundException fe)
            {
                throw new Exception();
            }
            catch (Exception be)
            {

            }
            return mayor;
        }
        /// <summary>
        /// Allows to register a new Passenger
        /// </summary>
        /// <param name="d">Object Type Pasajero</param>
        public void registrarPasajero(Pasajero d)
        {
            string path = Path.GetFullPath("pasajeros.txt");//para agregar carpetas afuera agrego ..\\
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(d.ToString());
                    sw.Close();
                }

            }
            else
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(d.ToString()); //se agrega información al documento

                    file.Close();
                }
            }
        }
        /// <summary>
        /// Allows to register a new international ticket
        /// </summary>
        /// <param name="z">Object Type TiqueteInternacional</param>
        public void registrarTiqInter(TiqueteInternacional z)
        {
            string path = Path.GetFullPath("tiqInter.txt");//para agregar carpetas afuera agrego ..\\
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(z.ToString());
                    sw.Close();
                }

            }
            else
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(z.ToString()); //se agrega información al documento

                    file.Close();
                }
            }
        }
        /// <summary>
        /// Allows to charge the availables bus seats for a specific date 
        /// </summary>
        /// <param name="fec">specific date </param>
        /// <param name="v">specific Hour </param>
        /// <returns>List of numbers of the available bus seats</returns>
        public List<int> camposDisponiblesInter(string fec, string v)
        {
            List<int> mas = new List<int>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[14];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("tiqInter.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[2].Equals(fec) && campos[5].Equals(v))
                    {
                        mas.Add(Convert.ToInt32(campos[0]));
                    }


                    /*
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                    */
                    cadena = lectura.ReadLine();
                }

                lectura.Close();
                //escribir.Close();
                /*
                File.AppendAllText(@"C:\Users\Usuario\Desktop\temp.txt", "Your Text" + "\n");
                File.Delete(@"C:\Users\Usuario\Desktop\lol.txt");
                File.Move(@"C:\Users\Usuario\Desktop\temp.txt", @"C:\Users\Usuario\Desktop\lol.txt");
                */
                return mas;
            }
            catch (FileNotFoundException fe)
            {

            }
            catch (Exception be)
            {

            }
            return mas;
        }

        /// <summary>
        /// Allows to charge a list of all international tickets sold in a specific date to make an cash register
        /// </summary>
        /// <param name="info"> Object type CierreCaja to find the specific tickets</param>
        /// <returns>list of international tickets</returns>
        public List<TiqueteInternacional> cargarTiquetesInterArq(CierreCaja info)
        {
            List<TiqueteInternacional> mas = new List<TiqueteInternacional>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[14];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("tiqInter.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[11].Equals(info.GSUsuario) && campos[12].Equals(info.GSFecha))
                    {
                        TiqueteInternacional p= new TiqueteInternacional();
                        p.NumTiquete = Convert.ToInt32(campos[0]);
                        p.NumPassport = campos[1];
                        p.Fecha = campos[2];
                        p.Asiento = campos[3];
                        p.CodUnidad = campos[4];
                        p.Horasalida = campos[5];
                        p.TerminalSalida = campos[6];
                        p.TerminalLLegada = campos[7];
                        p.Equipaje = Convert.ToBoolean(campos[8]);
                        p.NumEquipaje = Convert.ToInt32(campos[9]);
                        p.Monto = Convert.ToDouble(campos[10]);
                        p.Vendedor = campos[11];
                        p.FechaVenta = campos[12];
                        mas.Add(p);
                    }
                    /*
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                    */
                    cadena = lectura.ReadLine();
                }

                lectura.Close();
                //escribir.Close();
                /*
                File.AppendAllText(@"C:\Users\Usuario\Desktop\temp.txt", "Your Text" + "\n");
                File.Delete(@"C:\Users\Usuario\Desktop\lol.txt");
                File.Move(@"C:\Users\Usuario\Desktop\temp.txt", @"C:\Users\Usuario\Desktop\lol.txt");
                */
                return mas;
            }
            catch (FileNotFoundException fe)
            {

            }
            catch (Exception be)
            {

            }
            return mas;
        }
        /// <summary>
        /// Allows to charge a list of all sold national tickets  in a specific date to make an cash register
        /// </summary>
        /// <param name="info"> Object type CierreCaja to find the specific tickets</param>
        /// <returns>list of national tickets</returns>
        public List<TiqueteNacional> cargarTiquetesNacArq(CierreCaja info)
        {
            List<TiqueteNacional> mas = new List<TiqueteNacional>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[11];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("tiqNacional.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[9].Equals(info.GSUsuario) && campos[10].Equals(info.GSFecha))
                    {
                        TiqueteNacional p = new TiqueteNacional();
                        p.GSNumTiquete =Convert.ToInt32(campos[0]);
                        p.GSFecha = campos[1];
                        p.GSAsiento = campos[2];
                        p.GSHorasalida = campos[3];
                        p.GSTerminalSalida = campos[4];
                        p.GSTerminalLLegada = campos[5];
                        p.GSEquipaje = Convert.ToBoolean(campos[6]);
                        p.GSNumEquipaje= Convert.ToInt32(campos[7]);
                        p.Monto = Convert.ToDouble(campos[8]);
                        p.Vendedor = campos[9];
                        p.FechaVenta = campos[10];
                        mas.Add(p);
                    }
                    /*
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                    */
                    cadena = lectura.ReadLine();
                }

                lectura.Close();
                //escribir.Close();
                /*
                File.AppendAllText(@"C:\Users\Usuario\Desktop\temp.txt", "Your Text" + "\n");
                File.Delete(@"C:\Users\Usuario\Desktop\lol.txt");
                File.Move(@"C:\Users\Usuario\Desktop\temp.txt", @"C:\Users\Usuario\Desktop\lol.txt");
                */
                return mas;
            }
            catch (FileNotFoundException fe)
            {

            }
            catch (Exception be)
            {

            }
            return mas;
        }
        /// <summary>
        /// Allows to register a new arqueoCaja
        /// </summary>
        /// <param name="d">Object type CierreCaja to generate a new arqueoCaja</param>
        public void arqueoDeCaja(CierreCaja d)
        {
            string path = Path.GetFullPath("arqueoCaja.txt");//para agregar carpetas afuera agrego ..\\
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(d.ToString());
                    sw.Close();
                }

            }
            else
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(d.ToString()); //se agrega información al documento

                    file.Close();
                }
            }
        }
        /// <summary>
        /// Allows to register a new cash register
        /// </summary>
        /// <param name="d">Username who do the cash register </param>
        public void registrarCierreCaja(CierreCaja d)
        {
            string path = Path.GetFullPath("CierresCajaTiq.txt");//para agregar carpetas afuera agrego ..\\
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(d.ToString());
                    sw.Close();
                }

            }
            else
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(d.ToString()); //se agrega información al documento

                    file.Close();
                }
            }
        }
        /// <summary>
        /// Allows to generate the amount of money that a user has generate during the day
        /// </summary>
        /// <param name="user">Username who will do the cahs register </param>
        public double MontoUsuario(string user)
        {
            double mas = 0;
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[11];
            char[] separador = { ',' };
            try
            {
                DateTime fecha = DateTime.Now;
                string Text = fecha.ToString("dd/MM/yyyy");
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("tiqNacional.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[9].Equals(user) && campos[10].Equals(Text))
                    {



                        mas += Convert.ToDouble(campos[8]);
                    }
                    /*
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                    */
                    cadena = lectura.ReadLine();
                }

                lectura.Close();
                //escribir.Close();
                /*
                File.AppendAllText(@"C:\Users\Usuario\Desktop\temp.txt", "Your Text" + "\n");
                File.Delete(@"C:\Users\Usuario\Desktop\lol.txt");
                File.Move(@"C:\Users\Usuario\Desktop\temp.txt", @"C:\Users\Usuario\Desktop\lol.txt");
                */
                return mas;

            }
            catch (FileNotFoundException fe)
            {
                throw new Exception();
            }
            catch (Exception be)
            {

            }
            return mas;
        }
        /// <summary>
        /// Allows to register a new cash register
        /// </summary>
        /// <param name="d">Object type CorteCaja</param>
        public void registrarCorteCaja(CorteCaja d)
        {

            string path = Path.GetFullPath("corteCaja.txt");//para agregar carpetas afuera agrego ..\\
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(d.ToString());
                    sw.Close();

                }

            }
            else
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(d.ToString()); //se agrega información al documento

                    file.Close();
                }
            }
        }
        /// <summary>
        /// Allows to register a new TiqueteNacional
        /// </summary>
        /// <param name="t">Object type TiqueteNacional which will be registered</param>
        public void registrarTiqNac(TiqueteNacional d)
        {
            
                string path = Path.GetFullPath("tiqNacional.txt");//para agregar carpetas afuera agrego ..\\
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(d.ToString());
                        sw.Close();

                    }

                }
                else
                {
                    using (StreamWriter file = new StreamWriter(path, true))
                    {
                        file.WriteLine(d.ToString()); //se agrega información al documento

                        file.Close();
                    }
                }
          
        }
    }
}
