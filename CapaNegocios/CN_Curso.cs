using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    //TODO: clase CN_Curso para manejar las operaciones relacionadas con los cursos en la capa de negocios.
    public class CN_Curso
    {
        //TODO: instancia de la clase CD_Curso para acceder a los métodos de la capa de datos relacionados con los cursos.
        private CD_Curso objeto = new CD_Curso();

        //metodo para mostrar los datos de nuestra base de dato
        public DataTable MostrarCurso()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarCurso();
            return tabla;
        }

        //metodo para insertar datos a nuestra base de datos
        public void InsertarCurso(string nombre, int capacidadMax, DateTime fechaInicio)
        {
            objeto.Insertar(nombre, capacidadMax, fechaInicio);
        }

        //metodo para editar los datos de nuestra base de datos
        public void EditarCurso(string cursoID, string nombre, int capacidadMax, DateTime fechaInicio)
        {
            objeto.Editar(cursoID, nombre, capacidadMax, fechaInicio);
        }

        //metodo para eliminar los datos de nuestra base de datos
        public void EliminarCurso(string cursoID)
        {
            objeto.Eliminar(cursoID);
        }

      
    }
}
