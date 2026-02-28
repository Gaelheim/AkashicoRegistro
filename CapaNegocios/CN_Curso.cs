using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Curso
    {
        private CD_Curso objeto = new CD_Curso();
        public DataTable MostrarCurso()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarCurso();
            return tabla;
        }

        public void InsertarCurso(string nombre, int capacidadMax, DateTime fechaInicio)
        {
            objeto.Insertar(nombre, capacidadMax, fechaInicio);
        }

        public void EditarCurso(string cursoID, string nombre, int capacidadMax, DateTime fechaInicio)
        {
            objeto.Editar(cursoID, nombre, capacidadMax, fechaInicio);
        }

        public void EliminarCurso(string cursoID)
        {
            objeto.Eliminar(cursoID);
        }

      
    }
}
