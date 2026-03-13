using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    //TODO: clase CD_Inscripciones para manejar las operaciones relacionadas con la entidad Inscripcion en la base de datos.
    public class CD_Inscripciones
    {
        //TODO: instancia de la clase CD_Conexion para establecer la conexion a la base de datos.
        private CD_Conexion conexion = new CD_Conexion();

        //metodo para mostrar los datos de nuestra base de dato de la tablla Inscripcion
        public DataTable MostrarPrograma()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Inscripcion";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //metodo para mostrar los datos de nuestra base de dato de los participantes
        public DataTable ObtenerParticipante()
         {
            SqlCommand comando = new SqlCommand();
            DataTable tabla1 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT Matricula FROM Participante";
            SqlDataReader leer = comando.ExecuteReader();
            tabla1.Load(leer);
            conexion.CerrarConexion();
            return tabla1;

          }

        //metodo para mostrar los datos de nuestra base de dato de los programas
        public DataTable ObtenerPrograma()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla2 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT CodigoPrograma, Nombre FROM Programa";
            SqlDataReader leer = comando.ExecuteReader();
            tabla2.Load(leer);
            conexion.CerrarConexion();
            return tabla2;


        }

        //metodo para insertar datos a nuestra base de datos
        public void Insertar(String matricula, String codigoPrograma)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Inscripcion (Matricula, CodigoPrograma) VALUES ('" + matricula + "', '" + codigoPrograma + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        //metodo para eliminar datos de nuestra base de datos
        public void Eliminar(int inscripcionID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Delete From Inscripcion where InscripcionID = '" + inscripcionID + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        //metodo para modificar el estado de un participante a "Inscrito" en la base de datos
        public void ModificarAInscrito(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InscribirParticipante";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@InscripcionID", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        //metodo para modificar el estado de un participante a "Retirado" en la base de datos
        public void ModificarARetirado(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetirarParticipante";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@InscripcionID", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        //metodo para verificar si una inscripción ya existe en la base de datos antes de intentar insertarla, evitando así duplicados.
        public bool InscripcionExiste(string matricula, string codigoPrograma)
        {
            bool existe = false;
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT COUNT(*) FROM Inscripcion WHERE Matricula = @Matricula AND CodigoPrograma = @CodigoPrograma";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Matricula", matricula);
                comando.Parameters.AddWithValue("@CodigoPrograma", codigoPrograma);

                int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                existe = cantidad > 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return existe;
        }
    }

}
