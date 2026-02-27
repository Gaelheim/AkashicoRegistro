using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class CN_Participantes
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarParticipantes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * From Participante";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
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
    }

}
