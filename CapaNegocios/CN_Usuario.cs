using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    //TODO: clase Usuario con herencia de UsuarioBase para manejar las operaciones relacionadas con los usuarios en la capa de negocios.
    public class Usuario : UsuarioBase
    {

        //TODO: constructor de la clase Usuario que llama al constructor de la clase base UsuarioBase para inicializar el nombre y la clave del usuario.    
        public Usuario(string nombre, string clave)
            : base(nombre, clave) { }


        //TODO: método ObtenerRol que devuelve el rol del usuario, en este caso "Usuario".
        //Este método se puede utilizar para determinar los permisos y funcionalidades disponibles para el usuario en la aplicación.
        public override string ObtenerRol()
        {
            return "Usuario";
        }

        //TODO: método Bienvenida que devuelve un mensaje de bienvenida personalizado para el usuario, utilizando su nombre.
        //Este método se puede utilizar para mostrar un mensaje de bienvenida en la interfaz de usuario después de que el usuario inicie sesión correctamente.
        public override string Bienvenida()
        {
            return "Hola " + Nombre + ", bienvenido al sistema.";
        }
    }
}
