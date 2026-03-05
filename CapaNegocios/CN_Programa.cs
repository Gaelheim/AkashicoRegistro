using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Programa
    {
        private CD_Programa objeto = new CD_Programa();
        public DataTable MostrarPrograma()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarPrograma();
            return tabla;
        }

        public DataTable MostrarDocente()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objeto.ObtenerDocentes();
            return tabla1;
        }

        public DataTable MostrarCurso()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objeto.ObtenerCursos();
            return tabla2;
        }
        public void InsertarEstudiante(string nombre, string cursoID, int docenteID, int duracion_Semana, string dia, TimeSpan horario)
        {
            objeto.Insertar(nombre, cursoID, docenteID, duracion_Semana, dia, horario);
        }

       /* public void EditarParticipante(string matricula, string nombre, string apellido, string cedula, string correo, string telefono)
        {
            objeto.Editar(matricula, nombre, apellido, cedula, correo, telefono);
        } */
    }
}
