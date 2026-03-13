using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CapaDatos
{
    //TODO: clase CD_Docente para manejar las operaciones relacionadas con la entidad Docente en la base de datos.
    public class CD_Docente
    {

        //TODO: clase CD_Docente para manejar las operaciones relacionadas con la entidad Docente en la base de datos.
        private CD_Conexion conexion = new CD_Conexion(); 
       

        //metodo para mostrar los datos de nuestra base de dato
        public DataTable MostrarDocente()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ObtenerDocente";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //metodo para insertar datos a nuestra base de datos
        public void Insertar(string nombre, string titulo, string correo, string telefono)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Docente (Nombre, Titulo, Correo, Telefono) VALUES (@Nombre, @Titulo, @Correo, @Telefono)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = titulo;
            comando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = correo;
            comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = telefono;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        //metodo para editar los datos de nuestra base de datos
        public void Editar(int docenteID, string nombre, string titulo, string correo, string telefono)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDocente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DocenteID", docenteID);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //El metodo eliminar se ha comentado porque no se ha implementado en la interfaz de usuario,
        //pero se puede descomentar y utilizar si se desea agregar la funcionalidad de eliminación de docentes en el futuro.
       
        /* public void Eliminar(int docenteID)
         {
             SqlCommand comando = new SqlCommand();
             comando.Connection = conexion.AbrirConexion();
             comando.CommandText = "EliminarDocente";
             comando.CommandType = CommandType.StoredProcedure;

             comando.Parameters.AddWithValue("@DocenteID", docenteID);

             comando.ExecuteNonQuery();
             comando.Parameters.Clear();

         }*/

    }
}
