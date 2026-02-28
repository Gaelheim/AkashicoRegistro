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
    public class Estudiantes
    {
        private CD_Participantes objeto = new CD_Participantes();
        public DataTable MostrarEstudiantes()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarParticipantes();
            return tabla;
        }

        public void InsertarEstudiante(string nombre, string apellido, string cedula, string correo, string telefono)
        {
            objeto.Insertar(nombre,apellido,cedula,correo,telefono);
        }

        public void EditarParticipante(string matricula, string nombre, string apellido, string cedula, string correo, string telefono)
        {
            objeto.Editar(matricula, nombre, apellido, cedula, correo, telefono);
        }

        public void CambiarEstatusA(string matricula)
        {
            objeto.ModificarEstatusA(matricula);
        }

        public void ActivarEstudiante(string matricula)
        {
            objeto.ActivarParticipante(matricula);
        }
        public void CambiarEstatusM(string matricula)
        {
            objeto.ModificarEstatusM(matricula);
        }
    }

}
