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
    //TODO: clase CN_Inscripciones para manejar las operaciones relacionadas con las inscripciones en la capa de negocios.
    public class CN_Inscripciones
    {
        //TODO: instancia de la clase CD_Inscripciones para acceder a los métodos de la capa de datos relacionados con las inscripciones.
        private CD_Inscripciones objeto = new CD_Inscripciones();

        //metodo para mostrar los datos de nuestra base de dato
        public DataTable MostrarInscripciones()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarPrograma();
            return tabla;
        }

        //metodo para mostrar los datos de nuestra base de dato de los participantes
        public DataTable MostrarParticipante()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objeto.ObtenerParticipante();
            return tabla1;
        }

        //metodo para mostrar los datos de nuestra base de dato de los programas
        public DataTable MostrarPrograma()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objeto.ObtenerPrograma();
            return tabla2;
        }

        //metodo para insertar datos a nuestra base de datos
        public void InsertarInscripcion(string matricula, string codigoPrograma)
        {
            objeto.Insertar(matricula, codigoPrograma);
        }

        //metodo para eliminar los datos de nuestra base de datos
        public void EliminarInscripcion(int inscripcionID)
        {
            objeto.Eliminar(inscripcionID);
        }

        //metodo para modificar el estado de una inscripcion a retirado
        public void ModificarARetirado(int id)
        {
            objeto.ModificarARetirado(id);
        }

        //metodo para modificar el estado de una inscripcion a inscrito
        public void ModificarAInscrito(int id)
        {
            objeto.ModificarAInscrito(id);
        }

        //metodo para verificar si una inscripcion ya existe en la base de datos
        public bool InscripcionExiste(string matricula, string codigoPorgrama)
        {
            return objeto.InscripcionExiste(matricula, codigoPorgrama);
        }
    }
}
