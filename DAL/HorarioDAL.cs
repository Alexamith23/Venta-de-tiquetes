using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using System.IO;

namespace DAL
{
    public class HorarioDAL
    {
        /// <summary>
        /// Allows to generate a list of all available schedules
        /// </summary>
        /// <returns>list of all available schedules</returns>
        public List<Horario> cargarHorarios()
        {
            List<Horario> mas = new List<Horario>();
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
                string path = Path.GetFullPath("horarios.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    // if (campos[0].Trim().Equals(txtUsuario.Text.Trim()) && campos[1].Trim().Equals(txtContraseña.Text.Trim()))
                    Horario p = new Horario();
                    p.GSidHorario = campos[0];
                    p.GSidRuta = campos[1];
                    p.GSidTerminal = campos[2];
                    p.GSdia = campos[3];
                    p.GSHoraSalida = campos[4];
                    p.GSHoraLlegada = campos[5];

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
        /// Allows to eliminate a specific schedule
        /// </summary>
        /// <param name="nombre">Code of the Horario</param>
        public void eliminarHorario(string nombre)
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
                string path = Path.GetFullPath("horarios.txt");//para agregar carpetas afuera agrego ..\\
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
        /// Allows to edit a specific Schedule
        /// </summary>
        /// <param name="actual">Horario Code </param>
        /// <param name="u">Horario Edited</param>
        public void editarHorario(string actual, Horario u)
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
                string path = Path.GetFullPath("horarios.txt");//para agregar carpetas afuera agrego ..\\
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
        /// Allows to register a new Schedule
        /// </summary>
        /// <param name="u">Objec type Horario</param>
        public void registrarHorario(Horario u)
        {
            if (existeHorario(u) != true)
            {
                string path = Path.GetFullPath("horarios.txt");//para agregar carpetas afuera agrego ..\\
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
                throw new Exception("El horario ya se encuentra registrado");
            }
        }
        /// <summary>
        /// Allows to validate if a schedule exist
        /// </summary>
        /// <param name="u">Object type Horario</param>
        /// <returns></returns>
        private bool existeHorario(Horario u)
        {
            List<Horario> mas = new List<Horario>();
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
                string path = Path.GetFullPath("horarios.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Equals(u.GSidHorario))
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
            return encontrado; ;
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
        /// Allows to generate a list of all registered routes
        /// </summary>
        /// <returns>list of all registered routes</returns>
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
