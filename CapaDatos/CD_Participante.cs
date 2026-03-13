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
    //TODO: clase CD_Participantes para manejar las operaciones relacionadas con la entidad Participante en la base de datos.
    public class CD_Participantes
    {
        //TODO: instancia de la clase CD_Conexion para establecer la conexion a la base de datos.
        private CD_Conexion conexion = new CD_Conexion();

        //metodo para mostrar los datos de nuestra base de dato
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

        //metodo para insertar datos a nuestra base de datos
        public void Insertar(string nombre, string apellido, string cedula, string correo, string telefono)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Participante (Matricula, Nombre, Apellido, Cedula, Correo, Telefono) VALUES ('Temp', '" + nombre + "', '" + apellido + "', '" + cedula + "', '" + correo + "', '" + telefono + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        //metodo para editar los datos de nuestra base de datos
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

        //metodo para modificar el estatus de un participante a baja academica
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

        //metodo para modificar el estatus de un participante a activo
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

        //metodo para modificar el estatus de un participante a baja medica
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
