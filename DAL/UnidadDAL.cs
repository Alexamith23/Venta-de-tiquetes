using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using System.IO;

namespace DAL
{
    public class UnidadDAL
    {
        /// <summary>
        /// Allows to register a new bus
        /// </summary>
        /// <param name="t">Object type Unidad which will be registered</param>
        public void registrarUnidad(Unidad u)
        {
            if (existeUnidad(u) != true)
            {
                //string path = @"C:\Users\Usuario\Desktop\lol.txt";
                string path = Path.GetFullPath("unidades.txt");//para agregar carpetas afuera agrego ..\\
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(u.ToString());

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
            else
            {
                throw new Exception("Ya existe la Unidad");
            }
        }
        /// <summary>
        /// Allows to know if a bus exists
        /// </summary>
        /// <param name="u">Object type bus</param>
        /// <returns>true if exists otherwise false</returns>
        private bool existeUnidad(Unidad u)
        {
            List<Unidad> mas = new List<Unidad>();
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
                string path = Path.GetFullPath("unidades.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                   if(campos[0].Equals(u.Codigo) || campos[1].Equals(u.GSNumPlaca) || campos[2].Equals(u.GSNumMotor))
                    {
                        encontrado = true;
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
                return encontrado;
            }
            catch (FileNotFoundException fe)
            {

            }
            catch (Exception be)
            {

            }
            return encontrado;
        }
        /// <summary>
        /// Allows to charge a list of buses with the same route
        /// </summary>
        /// <param name="v">name of the route</param>
        /// <returns>list of buses with the same route</returns>
        public List<Unidad> cargarUnidadesRuta(string v)
        {
            List<Unidad> mas = new List<Unidad>();
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
                string path = Path.GetFullPath("unidades.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[6].Equals(v))
                    {
                        Unidad p = new Unidad();
                        p.Codigo = campos[0];
                        p.GSNumPlaca = campos[1];
                        p.GSNumMotor = campos[2];
                        p.GSModelo = campos[3];
                        p.GSCapacidad = Convert.ToInt32(campos[4]);
                        p.GSColor = campos[5];
                        p.GSRutaAsignada = campos[6];
                        p.GSPermisoTransito = campos[7];
                        p.GSFechaVigencia = campos[8];
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
        /// Allows to charge a list of all routes
        /// </summary>
        /// <returns>list of routes</returns>
        public List<Ruta> cargarRutas()
        {
            List<Ruta> mas = new List<Ruta>();
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
                string path = Path.GetFullPath("Rutas.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    // if (campos[0].Trim().Equals(txtUsuario.Text.Trim()) && campos[1].Trim().Equals(txtContraseña.Text.Trim()))
                    Ruta p = new Ruta();
                    p.Identificador = campos[0];
                    p.Nombre = campos[1];
                    p.Descripcion = campos[2];
                    
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
        /// Allows to update information of a specific bus
        /// </summary>
        /// <param name="actual">code of the bus </param>
        /// <param name="u">Updated information of the bus</param>
        public void editarUnidades(string actual, Unidad u)
        {
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[13];
            char[] separador = { ',' };
            try
            {
                string path = Path.GetFullPath("unidades.txt");//para agregar carpetas afuera agrego ..\\
                string patho = Path.GetFullPath("temp.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                escribir = File.CreateText(patho);
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(actual))
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
        /// Allows to eliminate a specific bus
        /// </summary>
        /// <param name="nombre">Code of the bus that will be eliminate</param>
        public void eliminarUnidad(string nombre)
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
                string path = Path.GetFullPath("unidades.txt");//para agregar carpetas afuera agrego ..\\
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
        /// Allows to charge a list of all buses
        /// </summary>
        /// <returns>list of buses</returns>
        public List<Unidad> cargarUnidades()
        {
            List<Unidad> mas = new List<Unidad>();
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
                    p.GSNumPlaca = campos[1];
                    p.GSNumMotor = campos[2];
                    p.GSModelo = campos[3];
                    p.GSCapacidad = Convert.ToInt32(campos[4]);
                    p.GSColor = campos[5];
                    p.GSRutaAsignada = campos[6];
                    p.GSPermisoTransito = campos[7];
                    p.GSFechaVigencia = campos[8];
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

    }
}
