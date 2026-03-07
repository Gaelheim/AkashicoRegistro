using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Inscripciones
    {
        private CD_Inscripciones objeto = new CD_Inscripciones();
        public DataTable MostrarInscripciones()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarPrograma();
            return tabla;
        }


        public DataTable MostrarParticipante()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objeto.ObtenerParticipante();
            return tabla1;
        }

        public DataTable MostrarCurso()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objeto.ObtenerPrograma();
            return tabla2;
        }

        public void InsertarInscripcion(string matricula, string cursoID)
        {
            objeto.Insertar(matricula, cursoID);
        }

        public void EliminarInscripcion(int inscripcionID)
        {
            objeto.Eliminar(inscripcionID);
        }
    }
}
