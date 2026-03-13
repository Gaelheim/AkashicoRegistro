using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Usuario : UsuarioBase
    {
       
        public Usuario(string nombre, string clave)
            : base(nombre, clave) { }

        
        public override string ObtenerRol()
        {
            return "Usuario";
        }

        
        public override string Bienvenida()
        {
            return "Hola " + Nombre + ", bienvenido al sistema.";
        }
    }
}
