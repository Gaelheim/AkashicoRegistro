using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    //TODO: clase CD_Reportes para manejar las operaciones relacionadas con la generación de reportes en la base de datos.
    public class CD_Reportes
    {
        //TODO: instancia de la clase CD_Conexion para establecer la conexion a la base de datos.
        private CD_Conexion conexion = new CD_Conexion();

        //metodo para obtener el reporte de ocupacion por curso
        public DataTable ObtenerOcupacionPorCurso()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_OcupacionPorCurso";
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        //metodo para obtener el reporte de tasa de desercion
        public DataTable ObtenerTasaDesercion()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_TasaDesercion";
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
