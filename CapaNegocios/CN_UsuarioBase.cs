using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public abstract class UsuarioBase
    {
        public string Nombre;
        public string Clave;

        
        public UsuarioBase(string nombre, string clave)
        {
            Nombre = nombre;
            Clave = clave;
        }

       
        public virtual string Bienvenida()
        {
            return "Bienvenido, " + Nombre;
        }

        
        public abstract string ObtenerRol();
    }

}
