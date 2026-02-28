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
    public class CN_Participantes
    {
        private CD_Conexion conexion = new CD_Conexion();

        public DataTable MostrarParticipantes()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ObtenerParticipantes";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar( string nombre, string apellido, string cedula, string correo, string telefono)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Participante (Matricula, Nombre, Apellido, Cedula, Correo, Telefono) VALUES ('Temp', '" + nombre + "', '" + apellido + "', '" + cedula + "', '" + correo + "', '" + telefono + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        public void Editar(string matricula, string nombre, string apellido, string cedula, string correo, string telefono)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarParticipante";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Matricula", matricula);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.ExecuteNonQuery();
        }
    }

    public class Estudiantes
    {
        private CN_Participantes objeto = new CN_Participantes();
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
    }

}
