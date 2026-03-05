using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class CN_Docente
    {
        private CD_Docente objeto = new CD_Docente();
        public DataTable MostrarDocente()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarDocente();
            return tabla;
        }

        public void InsertarDocente(string nombre, string titulo, string correo, string telefono)
        {
            objeto.Insertar(nombre, titulo, correo, telefono);
        }

        public void EditarDocente(int docenteID, string nombre, string titulo, string correo, string telefono)
        {
            objeto.Editar(docenteID, nombre, titulo, correo, telefono);
        }

        //El metodo EliminarDocente no se va a utilizar, ya que no es necesario eliminar un docente,
        //ya que se pueden cambiar sus datos, pero no eliminarlo completamente de la base de datos, ya que esto podría afectar a los cursos que tiene asignados.
       
        /*public void EliminarDocente(int docenteID)
        {
            objeto.Eliminar(docenteID);
        }*/
    }
}
