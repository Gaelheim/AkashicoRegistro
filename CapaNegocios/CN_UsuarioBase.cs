using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    //TODO: clase abstracta UsuarioBase para representar a los usuarios en la capa de negocios.
    public abstract class UsuarioBase
    {
        //TODO: propiedades públicas para almacenar el nombre y la clave del usuario
        public string Nombre;
        public string Clave;

        //TODO: constructor de la clase UsuarioBase para inicializar el nombre y la clave del usuario.
        public UsuarioBase(string nombre, string clave)
        {
            Nombre = nombre;
            Clave = clave;
        }

        //TODO: método virtual Bienvenida que devuelve un mensaje de bienvenida genérico para el usuario, utilizando su nombre.
        public virtual string Bienvenida()
        {
            return "Bienvenido, " + Nombre;
        }

        //TODO: método abstracto ObtenerRol que debe ser implementado por las clases derivadas para devolver el rol del usuario.
        public abstract string ObtenerRol();
    }

}
