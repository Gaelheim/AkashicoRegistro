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
    public class CN_Reportes
    {
        private CD_Reportes reporte = new CD_Reportes();

        public DataTable ObtenerOcupacionPorCurso()
        {
            DataTable tabla = new DataTable();
            tabla = reporte.ObtenerOcupacionPorCurso();
            return tabla;
        }

        public DataTable ObtenerTasaDesercion()
        {
            DataTable tabla = new DataTable();
             tabla = reporte.ObtenerTasaDesercion();
            return tabla;
        }
    }


}
