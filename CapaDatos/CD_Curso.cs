using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Curso
    {
        private CD_Conexion conexion = new CD_Conexion(); //instancia de la capa Conexion de datos, para poder hacer uso de nuestra cadena que llama la base de datos.


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

        public void Insertar(string nombre, int capacidadMax, DateOnly fechaInicio)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Curso (CursoID, Nombre, CapacidadMax, FechaInicio) VALUES ('TEMP', '"+nombre+"', "+capacidadMax+", '"+fechaInicio+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        public void Editar(string cursoID, string nombre, int capacidadMax, DateOnly fechaInicio)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCurso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CursoID", cursoID);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@CapacidadMax", capacidadMax);
            comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
          
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

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

