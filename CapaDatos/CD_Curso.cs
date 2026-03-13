using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    //TODO: clase CD_Curso para manejar las operaciones relacionadas con la entidad Curso en la base de datos.
    public class CD_Curso
    {
        //TODO: instancia de la clase CD_Conexion para establecer la conexion a la base de datos.
        private CD_Conexion conexion = new CD_Conexion(); 


        //metodo para mostrar los datos de nuestra base de dato
        public DataTable MostrarCurso()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ObtenerCursos";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //metodo para insertar datos a nuestra base de datos
        public void Insertar(string nombre, int capacidadMax, DateTime fechaInicio)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Curso (CursoID, Nombre, CapacidadMax, FechaInicio) VALUES ('TEMP', @nombre, @capacidad, @fecha)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            comando.Parameters.Add("@capacidad", SqlDbType.Int).Value = capacidadMax;
            comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fechaInicio.Date;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        //metodo para editar los datos de nuestra base de datos
        public void Editar(string cursoID, string nombre, int capacidadMax, DateTime fechaInicio)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCurso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CursoID", cursoID);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@CapacidadMax", capacidadMax);
            comando.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = fechaInicio.Date;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //metodo para eliminar los datos de nuestra base de datos
        public void Eliminar(string cursoID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCurso";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@CursoID", cursoID);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        
    }
}

