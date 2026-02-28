using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Participantes
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

        public void Insertar(string nombre, string apellido, string cedula, string correo, string telefono)
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
            comando.Parameters.Clear();
        }

        public void ModificarEstatusA(string matricula)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BajaAcademica";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Matricula", matricula);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void ActivarParticipante(string matricula)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Activar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Matricula", matricula);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void ModificarEstatusM(string matricula)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BajaMedica";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Matricula", matricula);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
