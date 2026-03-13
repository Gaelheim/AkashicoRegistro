using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{

    //TODO: clase CN_Programa para manejar las operaciones relacionadas con los programas en la capa de negocios.
    public class CN_Programa
    {
        //TODO: instancia de la clase CD_Programa para acceder a los métodos de la capa de datos relacionados con los programas.
        private CD_Programa objeto = new CD_Programa();

        //metodo para mostrar los datos de nuestra base de dato
        public DataTable MostrarPrograma()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarPrograma();
            return tabla;
        }

        //metodo para mostrar los datos de nuestra base de dato de los docentes en el dgv
        public DataTable MostrarDocentes()
        {
            DataTable tabla3 = new DataTable();
            tabla3 = objeto.MostrarDocente();
            return tabla3;
        }

        //metodo para mostrar los datos de nuestra base de dato de los cursos en el dgv
        public DataTable MostrarCursos()
        {
            DataTable tabla4 = new DataTable();
            tabla4 = objeto.MostrarCurso();
            return tabla4;
        }

        //metodo para mostrar los datos de nuestra base de dato de los docentes en el cbx
        public DataTable MostrarDocente()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objeto.ObtenerDocentes();
            return tabla1;
        }

        //metodo para mostrar los datos de nuestra base de dato de los cursos en el cbx
        public DataTable MostrarCurso()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objeto.ObtenerCursos();
            return tabla2;
        }

        //metodo para insertar datos a nuestra base de datos
        public void InsertarPrograma(string nombre, string cursoID, int docenteID, int duracion_Semana, string dia, TimeSpan horario)
        {
            objeto.Insertar(nombre, cursoID, docenteID, duracion_Semana, dia, horario);
        }

        //metodo para editar los datos de nuestra base de datos
        public void EditarPrograma(string codigoPrograma, string nombre, string cursoID, int docenteID, int duracion_Semana, string dia, TimeSpan horario)
        {
            objeto.Editar(codigoPrograma, nombre, cursoID, docenteID, duracion_Semana, dia, horario);
        }

        //metodo para eliminar los datos de nuestra base de datos
        public void EliminarPrograma(string codigoPrograma)
        {
            objeto.Eliminar(codigoPrograma);
        }
    }
}
