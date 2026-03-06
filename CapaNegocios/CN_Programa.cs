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

        public DataTable MostrarDocentes()
        {
            DataTable tabla3 = new DataTable();
            tabla3 = objeto.MostrarDocente();
            return tabla3;
        }

        public DataTable MostrarCursos()
        {
            DataTable tabla4 = new DataTable();
            tabla4 = objeto.MostrarCurso();
            return tabla4;
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

       public void EditarParticipante(string codigoPrograma, string nombre, string cursoID, int docenteID, int duracion_Semana, string dia, TimeSpan horario)
        {
            objeto.Editar(codigoPrograma, nombre, cursoID, docenteID, duracion_Semana, dia, horario);
        }
    }
}
