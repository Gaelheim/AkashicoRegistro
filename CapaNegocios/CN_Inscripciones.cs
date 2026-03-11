using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public DataTable MostrarPrograma()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objeto.ObtenerPrograma();
            return tabla2;
        }

        public void InsertarInscripcion(string matricula, string codigoPrograma)
        {
            objeto.Insertar(matricula, codigoPrograma);
        }

        public void EliminarInscripcion(int inscripcionID)
        {
            objeto.Eliminar(inscripcionID);
        }

        public void ModificarARetirado(int id)
        {
            objeto.ModificarARetirado(id);
        }

        public void ModificarAInscrito(int id)
        {
            objeto.ModificarAInscrito(id);
        }

        public bool InscripcionExiste(string matricula, string codigoPorgrama)
        {
            return objeto.InscripcionExiste(matricula, codigoPorgrama);
        }
    }
}
