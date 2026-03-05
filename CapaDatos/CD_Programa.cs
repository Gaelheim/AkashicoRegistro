using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaDatos
{
    public class CD_Programa
    {
        private CD_Conexion conexion = new CD_Conexion();

        public DataTable MostrarPrograma()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ObtenerPrograma";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        } 
        public DataTable ObtenerDocentes()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla1 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT DocenteID, Nombre FROM Docente";
            SqlDataReader leer = comando.ExecuteReader();
            tabla1.Load(leer);
            conexion.CerrarConexion();
            return tabla1;

        }

        public DataTable ObtenerCursos()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla2 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT CursoID, Nombre FROM Curso";
            SqlDataReader leer = comando.ExecuteReader();
            tabla2.Load(leer);
            conexion.CerrarConexion();
            return tabla2;
    
  
        }

        public void Insertar(string nombre, string cursoID, int docenteID, int duracion_Semana, string dia, TimeSpan horario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Programa (CodigoPrograma, Nombre, CursoID, DocenteID, Duracion_Semana, Dia, Horario) VALUES ('Temp', '" + nombre + "', '" + cursoID + "', '" + docenteID + "', '" + duracion_Semana + "', '" + dia + "', '" + horario + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

       

        /* public void Editar(string matricula, string nombre, string apellido, string cedula, string correo, string telefono)
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
             comando.Parameters.Clear();
         } */
    }
}
