using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace DAL
{
    public class UsuarioDAL
    {
        /// <summary>
        /// Allows to charge a list of all users of a specific terminal
        /// </summary>
        /// <param name="wwe">Object type Usuario</param>
        /// <returns> list of all users of a specific terminal</returns>
        public List<Usuario> CargarUsuarios(Usuario wwe)
        {
            List<Usuario> mas = new List<Usuario>();
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
                string path = Path.GetFullPath("usuarios.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Substring(3, 1).Equals(wwe.Codigo.Substring(3, 1))){

                        Usuario p = new Usuario();
                        p.Codigo = campos[0];
                        p.gsUsuario = campos[1];
                        p.Password = campos[2];
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
        /// Allows to validate if a User exists
        /// </summary>
        /// <param name="v"> UserCode</param>
        /// <returns></returns>
        public bool existeTiquetero(string v)
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
                string path = Path.GetFullPath("usuarios.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(v))
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
                return encontrado;
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
            return encontrado;

        }
        /// <summary>
        /// Allows to eliminate a access of an user
        /// </summary>
        /// <param name="s"><Username/param>
        public void quitarPermiso(Permiso s)
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
                string path = Path.GetFullPath("Permisos.txt");//para agregar carpetas afuera agrego ..\\
                string patho = Path.GetFullPath("temp.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                escribir = File.CreateText(patho);
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(s.GSUsuario) && campos[1].Trim().Equals(s.GSVentana))
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
        /// Allows to assign a new permission
        /// </summary>
        /// <param name="u">Username</param>
        public void asignarPermiso(Permiso u)
        {
            if (tienePermiso(u) != true)
            {
                string path = Path.GetFullPath("Permisos.txt");//para agregar carpetas afuera agrego ..\\
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
            else {
                throw new Exception("El usuario ya posee el permiso");
            }
        }
        /// <summary>
        /// allows to know if a user has a specific access
        /// </summary>
        /// <param name="u">Permission name</param>
        /// <returns>true if exist the access otherwise false</returns>
        private bool tienePermiso(Permiso u)
        {
            List<Permiso> mas = new List<Permiso>();
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
                string path = Path.GetFullPath("Permisos.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(u.GSUsuario) && campos[1].Trim().Equals(u.GSVentana))
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
        /// Allows to charge the access of the user logged in the system
        /// </summary>
        /// <param name="user">Username</param>
        /// <returns>list with the access of the user</returns>
        public List<Permiso> cargarPermisos(string user)
        {
            List<Permiso> mas = new List<Permiso>();
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
                string path = Path.GetFullPath("Permisos.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(user))
                    {
                        Permiso p = new Permiso();
                        p.GSUsuario = campos[0];
                        p.GSVentana = campos[1];
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
        /// Alows to find the user in the system throught the name and password
        /// </summary>
        /// <param name="user">Username</param>
        /// <param name="password">User Password</param>
        /// <returns>Object type User</returns>
        public Usuario usuarioLogueado(string user, string password)
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
                string path = Path.GetFullPath("usuarios.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                Usuario aaa = new Usuario();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[1].Trim().Equals(user) && campos[2].Trim().Equals(password))
                    {
                        Usuario per = new Usuario();
                        per.Codigo = campos[0];
                        per.gsUsuario = campos[1];
                        per.Password = campos[2];
                        per.GSAccesos = accesos(campos[1]);
                        aaa = per;
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
                return aaa;
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
            return null;
        }
        /// <summary>
        /// Allows to validate if an user is registered in the system
        /// </summary>
        /// <param name="Usuario">name of the user </param>
        /// <param name="contrasena">Password of the user</param>
        /// <returns>true if him is registered in the system otherwise return false</returns>
        public bool login(string usuario, string contrasena)
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
                    string path = Path.GetFullPath("usuarios.txt");//para agregar carpetas afuera agrego ..\\
                    lectura = File.OpenText(path);
                    //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                    // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                    cadena = lectura.ReadLine();
                    while (cadena != null)
                    {
                        campos = cadena.Split(separador);
                        if (campos[1].Trim().Equals(usuario) && campos[2].Trim().Equals(contrasena))
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
                return encontrado;
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
            return encontrado ;

            }



        /// <summary>
        /// Allows to update the information of a specific user
        /// </summary>
        /// <param name="actual">UserCode</param>
        /// <param name="u">Updated Information</param>
        public void editarUsuario(string actual, Usuario u)
        {
            //Editar
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado;
            bool encontrado;
            encontrado = false;
            string[] campos = new string[5];
            char[] separador = { ',' };
            try
            {
                string path = Path.GetFullPath("usuarios.txt");//para agregar carpetas afuera agrego ..\\
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
        /// Allows to eliminate an User
        /// </summary>
        /// <param name="nombre">Code of the User</param>
        public void eliminarUsuario(string nombre)
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
                string path = Path.GetFullPath("usuarios.txt");//para agregar carpetas afuera agrego ..\\
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
        /// Allows to register a new user
        /// </summary>
        /// <param name="u">User that will be registered</param>
        public void registrarUsuario(Usuario u)
        {
            if (existeUsuario(u) != true)
            {
                string path = Path.GetFullPath("usuarios.txt");//para agregar carpetas afuera agrego ..\\
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
            else
            {
                throw new Exception("El Usua ya se encuentra registrado!!");
            }
            
        }
        /// <summary>
        /// Allows to validate if an user exists
        /// </summary>
        /// <param name="u">Object type User</param>
        /// <returns>true if exist otherwise false</returns>
        private bool existeUsuario(Usuario u)
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
                string path = Path.GetFullPath("usuarios.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(u.Codigo) || campos[1].Trim().Equals(u.gsUsuario))
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
                if (encontrado == true)
                {

                    return true;

                }
                else
                {
                    return false;
                }
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
            return false;

        }
        /// <summary>
        /// Allows to generate a list of all access of a specific user
        /// </summary>
        /// <param name="user">UserCode</param>
        /// <returns>list of all access of a specific user</returns>
        private List<Permiso> accesos(string user)
        {
            List<Permiso> mas = new List<Permiso>();
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, empleado; 
            Boolean encontrado;
            encontrado = false;
            string[] campos = new string[5];
            char[] separador = { ',' };
            try
            {
                //lectura = File.OpenText(@"C:\Users\Usuario\Desktop\lol.txt");
                string path = Path.GetFullPath("Permisos.txt");//para agregar carpetas afuera agrego ..\\
                lectura = File.OpenText(path);
                //escribir = File.CreateText(@"C:\Users\Usuario\Desktop\temp.txt");
                // String Nombre = dataTabla.CurrentRow.Cells[0].Value.ToString();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(user))
                    {
                        Permiso p = new Permiso();
                        p.GSUsuario = campos[0];
                        p.GSVentana = campos[1];

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

    }
}

