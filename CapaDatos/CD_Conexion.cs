using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        //TODO: cadena de conexion a la base de datos.
        private SqlConnection Conexion = new SqlConnection("Server=.;DataBase= ProgramaInscripciones;Integrated Security=true");

        //TODO: metodo para abrir la conexion a la base de datos, y retornar la conexion abierta.
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
           
        }

        //TODO: metodo para cerrar la conexion a la base de datos, y retornar la conexion cerrada.
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }
    }
}
