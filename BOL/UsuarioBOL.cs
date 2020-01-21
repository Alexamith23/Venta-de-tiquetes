using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Enteties;

namespace BOL
{
    public class UsuarioBOL
    {
        /// <summary>
        /// Allows to charge a list of all users of a specific terminal
        /// </summary>
        /// <param name="wwe">Object type Usuario</param>
        /// <returns> list of all users of a specific terminal</returns>
        public List<Usuario> cargarUsuarios(Usuario wwe)
        {
            UsuarioDAL cu = new UsuarioDAL();
            List<Usuario> m = cu.CargarUsuarios(wwe);
            return m;

        }
        /// <summary>
        /// allows to validate that the data of a User are not null or incorrect.
        /// </summary>
        /// <param name="x">Object type Usuario</param>
        private void validarUsuario(Usuario x)
        {
            if (String.IsNullOrEmpty(x.Codigo))
            {
                throw new Exception("Codigo de Usuario Requerido");
            }
            if (String.IsNullOrEmpty(x.gsUsuario))
            {
                throw new Exception("Nombre de Usuario Requerido");
            }
            if (String.IsNullOrEmpty(x.Password))
            {
                throw new Exception("Contraseña de Usuario Requerida");
            }
        }
        /// <summary>
        /// Allows to register a new user
        /// </summary>
        /// <param name="u">User that will be registered</param>
        public void registrarUsuario(Usuario u)
        {
            validarUsuario(u);
            UsuarioDAL cu = new UsuarioDAL();
            cu.registrarUsuario(u);
        }
        /// <summary>
        /// Allows to validate if an user is registered in the system
        /// </summary>
        /// <param name="Usuario">name of the user </param>
        /// <param name="contrasena">Password of the user</param>
        /// <returns>true if him is registered in the system otherwise return false</returns>
        public Boolean login(string Usuario, string contrasena)
        {
            validarLogin(Usuario, contrasena);
            UsuarioDAL cu = new UsuarioDAL();
            if (cu.login(Usuario, contrasena) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Allows to charge a list of all users of a specific terminal
        /// </summary>
        /// <param name="usuario">name of the user</param>
        /// <param name="contrasena">Password of the user</param>
        private void validarLogin(string usuario, string contrasena)
        {
            if (String.IsNullOrEmpty(usuario))
            {
                throw new Exception("Digite el Nombre de Usuario");
            }
            if (String.IsNullOrEmpty(contrasena))
            {
                throw new Exception("Digite la Contraseña");
            }
        }
        /// <summary>
        /// Alows to find the user in the system throught the name and password
        /// </summary>
        /// <param name="user">Username</param>
        /// <param name="password">User Password</param>
        /// <returns>Object type User</returns>
        public Usuario usuarioLogueado(string user, string password)
        {
            UsuarioDAL cu = new UsuarioDAL();
            Usuario lo= cu.usuarioLogueado(user, password);
            return lo;
        }
        /// <summary>
        /// Allows to eliminate an User
        /// </summary>
        /// <param name="nombre">Code of the User</param>
        public void eliminarUsuario(string nombre)
        {
            UsuarioDAL cu = new UsuarioDAL();
            cu.eliminarUsuario(nombre);
        }
        /// <summary>
        /// Allows to validate if an user exist in the system
        /// </summary>
        /// <param name="v"> UserCode</param>
        /// <returns>true if exist, otherwise false</returns>
        public bool existeTiquetero(string v)
        {
            UsuarioDAL cu = new UsuarioDAL();
            if (cu.existeTiquetero(v) == true)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Allows to update the information of a specific user
        /// </summary>
        /// <param name="actual">UserCode</param>
        /// <param name="u">Updated Information</param>
        public void editarUsuarios(string actual, Usuario u)
        {
            UsuarioDAL cu = new UsuarioDAL();
            cu.editarUsuario(actual,u);
        }
        /// <summary>
        /// Allows to eliminate an specific user
        /// </summary>
        /// <param name="nombre">userCode</param>
        public void eliminarTerminal(string nombre)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Allows to charge the access of the user logged in the system
        /// </summary>
        /// <param name="user">Username</param>
        /// <returns>list with the access of the user</returns>
        public List<Permiso> cargarPermisos(string user)
        {
            UsuarioDAL cu = new UsuarioDAL();
            List<Permiso> m = cu.cargarPermisos(user);
            return m;
        }
        /// <summary>
        /// Allows to assign a new permission
        /// </summary>
        /// <param name="u">Username</param>
        public void AsignarPermiso(Permiso u)
        {
            UsuarioDAL cu = new UsuarioDAL();
            cu.asignarPermiso(u);
        }
        /// <summary>
        /// Allows to eliminate a access of an user
        /// </summary>
        /// <param name="s"><Username/param>
        public void quitarPermiso(Permiso s)
        {
            UsuarioDAL cu = new UsuarioDAL();
            cu.quitarPermiso(s);
        }
    }
}
