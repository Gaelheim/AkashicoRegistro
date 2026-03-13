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
    //TODO: clase CD_Programa para manejar las operaciones relacionadas con la entidad Programa en la base de datos.
    public class CD_Programa
    {
        //TODO: instancia de la clase CD_Conexion para establecer la conexion a la base de datos.
        private CD_Conexion conexion = new CD_Conexion();

        //metodo para mostrar los datos de nuestra base de dato
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

        //metodo para mostrar los datos de nuestra base de dato de los docentes y poder asignarlos aun cbx
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

        //metodo para mostrar los datos de nuestra base de dato de los cursos y poder asignarlos aun cbx
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

        //metodo para mostrar los datos de nuestra base de dato de los docentes
        public DataTable MostrarDocente()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla3 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ObtenerDocente";
            SqlDataReader leer = comando.ExecuteReader();
            tabla3.Load(leer);
            conexion.CerrarConexion();
            return tabla3;
        }

        //metodo para mostrar los datos de nuestra base de dato de los cursos
        public DataTable MostrarCurso()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla4 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ObtenerCursos";
            SqlDataReader leer = comando.ExecuteReader();
            tabla4.Load(leer);
            conexion.CerrarConexion();
            return tabla4;
        }


        //metodo para insertar datos a nuestra base de datos
        public void Insertar(string nombre, string cursoID, int docenteID, int duracion_Semana, string dia, TimeSpan horario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Programa (CodigoPrograma, Nombre, CursoID, DocenteID, Duracion_Semana, Dia, Horario) VALUES ('Temp', '" + nombre + "', '" + cursoID + "', '" + docenteID + "', '" + duracion_Semana + "', '" + dia + "', '" + horario + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }


        //metodo para editar los datos de nuestra base de datos
        public void Editar(string codigoPrograma, string nombre, string cursoID, int docenteID, int duracion_Semana, string dia, TimeSpan horario)
         {
             SqlCommand comando = new SqlCommand();
             comando.Connection = conexion.AbrirConexion();
             comando.CommandText = "EditarPrograma";
             comando.CommandType = CommandType.StoredProcedure;
             comando.Parameters.AddWithValue("@CodigoPrograma", codigoPrograma);
             comando.Parameters.AddWithValue("@Nombre", nombre);
             comando.Parameters.AddWithValue("@CursoID", cursoID);
             comando.Parameters.AddWithValue("@DocenteID", docenteID);
             comando.Parameters.AddWithValue("@Duracion_Semana", duracion_Semana);
             comando.Parameters.AddWithValue("@Dia", dia);
             comando.Parameters.Add("@Horario", SqlDbType.Time).Value = horario;
             comando.ExecuteNonQuery();
             comando.Parameters.Clear();
         }

        //metodo para eliminar datos de nuestra base de datos
        public void Eliminar(string codigoPrograma)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Delete From Programa where CodigoPrograma = '"+codigoPrograma+"'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
