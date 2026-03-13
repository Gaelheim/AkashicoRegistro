using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaNegocios
{
    //TODO: clase CN_Reportes para manejar las operaciones relacionadas con los reportes en la capa de negocios.
    public class CN_Reportes
    {
        //TODO: instancia de la clase CD_Reportes para acceder a los métodos de la capa de datos relacionados con los reportes.
        private CD_Reportes reporte = new CD_Reportes();

        //metodo para mostrar los datos de nuestra base de dato
        public DataTable ObtenerOcupacionPorCurso()
        {
            DataTable tabla = new DataTable();
            tabla = reporte.ObtenerOcupacionPorCurso();
            return tabla;
        }

        //metodo para mostrar los datos de nuestra base de dato
        public DataTable ObtenerTasaDesercion()
        {
            DataTable tabla = new DataTable();
             tabla = reporte.ObtenerTasaDesercion();
            return tabla;
        }
    }


}
