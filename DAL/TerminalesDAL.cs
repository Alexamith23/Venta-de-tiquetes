using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using System.IO;

namespace DAL
{
    public class TerminalesDAL
    {
        /// <summary>
        /// Allows to register a new Terminal
        /// </summary>
        /// <param name="u">Object type Terminal which will be registered</param>
        public void registrarTerminal(Terminal u)
        {
            if (existeTerminal(u) != true)
            {
                string path = Path.GetFullPath("Terminales.txt");//para agregar carpetas afuera agrego ..\\
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
                throw new Exception("La terminal ya se encuentra Registrada");
            }
            //this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            //StreamWriter fichero;

            //fichero = File.AppendText("prueba.txt");
            //fichero.WriteLine(bv.ToString());
            //fichero.Close();
            //MessageBox.Show(bv.ToString(), "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// Allows to validate if a terminal exist
        /// </summary>
        /// <param name="u">objec type terminal</param>
        /// <returns>trueif exist otherwise false</returns>
        private bool existeTerminal(Terminal u)
        {
            List<Terminal> mas = new List<Terminal>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[5];
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
                    if (campos[0].Equals(u.Codigo))
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
        /// Allows to edit a specific terminal
        /// </summary>
        /// <param name="actual">code of the terminal</param>
        /// <param name="u">terminal with the edited information</param>
        public void editarTerminal(string actual, Terminal u)
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
                string path = Path.GetFullPath("Terminales.txt");//para agregar carpetas afuera agrego ..\\
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
        /// allows to generate a list of all terminals registered in the system 
        /// </summary>
        /// <returns>list of all terminals registered in the system </returns>
        public List<Terminal> cargarTerminales()
        {
            List<Terminal> mas = new List<Terminal>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[5];
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
        /// Allows to eliminate a especific Terminal
        /// </summary>
        /// <param name="nombre">Code of the terminal</param>
        public void eliminarTerminal(string nombre)
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
                string path = Path.GetFullPath("Terminales.txt");//para agregar carpetas afuera agrego ..\\
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
        
    }
    }

