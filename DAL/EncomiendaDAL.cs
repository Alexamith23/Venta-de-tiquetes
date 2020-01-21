using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using System.IO;

namespace DAL
{
    public class EncomiendaDAL
    {
        /// <summary>
        /// Allows to charge a list of all packages registered in the system
        /// </summary>
        /// <returns>list of all packages registered in the system</returns>
        public List<Encomienda> CargarEncomiendas()
        {
            List<Encomienda> mas = new List<Encomienda>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[8];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);

                    Encomienda p = new Encomienda();
                    p.GSNumEncomienda = campos[0];
                    p.GSCodUser = campos[1];
                    p.GSFecha = campos[2];
                    p.GSNomReceptor = campos[3];
                    p.GSCodTerminal = campos[4];
                    p.GSCodUnidad = campos[5];
                    p.GSPrecio = Convert.ToDouble(campos[6]);
                    p.GSEntregado = Convert.ToBoolean(campos[7]);
                    mas.Add(p);

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
               
                return mas;
            }
            catch (FileNotFoundException fe)
            {
                throw new FileNotFoundException();
            }
            catch (Exception be)
            {
                throw new Exception();
            }
            return mas;
        }
        /// <summary>
        /// Allows to generate the consecutive number of the packages
        /// </summary>
        /// <returns>the high number of the packages</returns>
        public int numEncomienda()
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
                string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
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
        /// Allows to resend a package
        /// </summary>
        /// <param name="u">Object type Encomienda</param>
        public void reenviarEncomienda(Encomienda u)
        {
            //Editar
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[11];
            char[] separador = { ',' };
            try
            {
                string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
                string patho = Path.GetFullPath("temp.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                escribir = File.CreateText(patho);
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(u.GSNumEncomienda))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        escribir.WriteLine(cadena);
                    }

                    cadena = lectura.ReadLine();
                }
                lectura.Close();
                escribir.Close();

                File.AppendAllText(patho, u.ToString() + "\n");
                File.Delete(path);
                File.Move(patho, path);

            }
            catch (FileNotFoundException fe)
            {

            }
            catch (Exception be)
            {

            }
        }
        /// <summary>
        /// Allows to charge a list of packages using a filter to find a specific package
        /// </summary>
        /// <param name="v">name of the receiver</param>
        /// <returns>list of packages</returns>
        public List<Encomienda> cargarEncomiendas(string v)
        {
            List<Encomienda> mas = new List<Encomienda>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[8];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[3].ToLower().Contains(v.ToLower()))
                    {
                        Encomienda p = new Encomienda();
                        p.GSNumEncomienda = campos[0];
                        p.GSCodUser = campos[1];
                        p.GSFecha = campos[2];
                        p.GSNomReceptor = campos[3];
                        p.GSCodTerminal = campos[4];
                        p.GSCodUnidad = campos[5];
                        p.GSPrecio = Convert.ToDouble(campos[6]);
                        p.GSEntregado = Convert.ToBoolean(campos[7]);
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
        /// Allows to generate a list of CierreCaja did by a especific user
        /// </summary>
        /// <param name="v">Code of the user</param>
        /// <returns> list of CierreCaja</returns>
        public List<CierreCaja> cargarArqueoDeCaja(string v)
        {
            List<CierreCaja> mas = new List<CierreCaja>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[8];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("arqueoCaja.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].ToLower().Contains(v))
                    {
                        CierreCaja p = new CierreCaja();
                        p.GSUsuario = campos[0];
                        p.GSFecha = campos[1];
                        p.GSMonto = Convert.ToDouble(campos[2]);
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
                throw new Exception();
            }
            catch (Exception be)
            {

            }
            return mas;
        }
        /// <summary>
        /// allows to generate a list of all sent packages by a specific user
        /// </summary>
        /// <param name="info">Ocject type CierreCaja to find all sent packages by the user </param>
        /// <returns>list of all sent packages</returns>
        public List<Encomienda> cargarEncomiendasArq(CierreCaja info)
        {

            List<Encomienda> mas = new List<Encomienda>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[8];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[1].Equals(info.GSUsuario) && campos[2].Equals(info.GSFecha))
                    {
                        Encomienda p = new Encomienda();
                        p.GSNumEncomienda = campos[0];
                        p.GSCodUser = campos[1];
                        p.GSFecha = campos[2];
                        p.GSNomReceptor = campos[3];
                        p.GSCodTerminal = campos[4];
                        p.GSCodUnidad = campos[5];
                        p.GSPrecio = Convert.ToDouble(campos[6]);
                        p.GSEntregado = Convert.ToBoolean(campos[7]);
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
        /// Allows to register a new cash register when the amount of money is different to the system
        /// </summary>
        /// <param name="d">Object type CierreCaja which contains the information to create a new cash register</param>
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
        /// returns a CierreCaja Object list
        /// </summary>
        /// <returns>returns a CierreCaja Object list</returns>
        public List<CierreCaja> cargarArqueoCaja()
        {
            List<CierreCaja> mas = new List<CierreCaja>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[8];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("arqueoCaja.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);

                    CierreCaja p = new CierreCaja();
                    p.GSUsuario = campos[0];
                    p.GSFecha = campos[1];
                    p.GSMonto = Convert.ToDouble(campos[2]);
                    mas.Add(p);

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
        /// Allows to register a new cash Register
        /// </summary>
        /// <param name="d">Object type CierreCaja</param>
        public void registrarCierreCaja(CierreCaja d)
        {
            string path = Path.GetFullPath("CierresCaja.txt");//para agregar carpetas afuera agrego ..\\
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
        /// Allows to do the cash register
        /// </summary>
        /// <param name="user">user code who did the cash register</param>
        /// <returns>amount of money that the user registered during the day </returns>
        public double CierreCaja(string user)
        {
            double mas = 0;
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[8];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[1].Equals(user))
                    {
                        


                        mas += Convert.ToDouble(campos[6]);
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
        /// allows you to register that a package was delivered
        /// </summary>
        /// <param name="u">Object type Encomienda</param>
        public void entregarEncomienda(Encomienda u)
        {
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[5];
            char[] separador = { ',' };
            try
            {
                string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
                string patho = Path.GetFullPath("temp.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                escribir = File.CreateText(patho);
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(u.GSNumEncomienda))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        escribir.WriteLine(cadena);
                    }

                    cadena = lectura.ReadLine();
                }
                if (encontrado == true)
                {



                }
                else
                {

                }
                lectura.Close();
                escribir.Close();

                File.AppendAllText(patho, u.ToString() + "\n");
                File.Delete(path);
                File.Move(patho, path);

            }
            catch (FileNotFoundException fe)
            {

            }
            catch (Exception be)
            {

            }
        }
        /// <summary>
        /// Allows to eliminate a package registered in the system
        /// </summary>
        /// <param name="nombre">Number of Package code</param>
        public void eliminarEncomienda(string nombre)
        {
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[10];
            char[] separador = { ',' };
            try
            {
                string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
                string patho = Path.GetFullPath("temp.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                escribir = File.CreateText(patho);

                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(nombre))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        escribir.WriteLine(cadena);
                    }

                    cadena = lectura.ReadLine();
                }
                if (encontrado == true)
                {



                }
                else
                {

                }
                lectura.Close();
                escribir.Close();


                File.Delete(path);
                File.Move(patho, path);
            }
            catch (FileNotFoundException fe)
            {

            }
            catch (Exception be)
            {

            }
        }
        /// <summary>
        /// Allows to generate a LIST of object type Unidad
        /// </summary>
        /// <returns>LIST of object type Unidad</returns>
        public List<Unidad> cargarUnidades()
        {
            List<Unidad> mas = new List<Unidad>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[13];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("unidades.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    // if (campos[0].Trim().Equals(txtUsuario.Text.Trim()) && campos[1].Trim().Equals(txtContraseña.Text.Trim()))
                    Unidad p = new Unidad();
                    p.Codigo = campos[0];
                    

                    mas.Add(p);

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
        /// Allows to generate a list of all registered terminals
        /// </summary>
        /// <returns>list of all registered terminals</returns>
        public List<Terminal> cargarTerminales()
        {
            List<Terminal> mas = new List<Terminal>();
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
                string path = Path.GetFullPath("Terminales.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    // if (campos[0].Trim().Equals(txtUsuario.Text.Trim()) && campos[1].Trim().Equals(txtContraseña.Text.Trim()))
                    Terminal p = new Terminal();
                    p.Codigo = campos[0];
                    p.Nombre = campos[1];
                    p.Ubicacion = campos[2];

                    mas.Add(p);

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
        /// Allows registering a new Encomienda
        /// </summary>
        /// <param name="u">Object type Encomienda</param>
        public void registrarEncomienda(Encomienda u)
        {
            //string path = @"C:\Users\Usuario\Desktop\lol.txt";
            string path = Path.GetFullPath("Encomiendas.txt");//para agregar carpetas afuera agrego ..\\
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(u.ToString());
                    sw.Close();
                }

            }
            else
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(u.ToString()); //se agrega información al documento

                    file.Close();
                }
            }
           
        
    }
    }
}
