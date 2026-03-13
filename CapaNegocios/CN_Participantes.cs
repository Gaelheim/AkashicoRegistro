using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace CapaNegocios
{
    //TODO: clase CN_Participantes para manejar las operaciones relacionadas con los participantes en la capa de negocios.
    public class Estudiantes
    {

        //TODO: instancia de la clase CD_Participantes para acceder a los métodos de la capa de datos relacionados con los participantes.
        private CD_Participantes objeto = new CD_Participantes();

        //metodo para mostrar los datos de nuestra base de dato
        public DataTable MostrarEstudiantes()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarParticipantes();
            return tabla;
        }

        //metodo para insertar datos a nuestra base de datos

        public void InsertarEstudiante(string nombre, string apellido, string cedula, string correo, string telefono)
        {
            objeto.Insertar(nombre,apellido,cedula,correo,telefono);
        }

        //metodo para editar los datos de nuestra base de datos
        public void EditarParticipante(string matricula, string nombre, string apellido, string cedula, string correo, string telefono)
        {
            objeto.Editar(matricula, nombre, apellido, cedula, correo, telefono);
        }

        // metodo para modificar el estatus de un participante a baja academica
        public void CambiarEstatusA(string matricula)
        {
            objeto.ModificarEstatusA(matricula);
        }

        // metodo para modificar el estatus de un participante a activo
        public void ActivarEstudiante(string matricula)
        {
            objeto.ActivarParticipante(matricula);
        }

        // metodo para modificar el estatus de un participante a baja administrativa
        public void CambiarEstatusM(string matricula)
        {
            objeto.ModificarEstatusM(matricula);
        }
    }

}
