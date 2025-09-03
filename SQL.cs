using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Gestor_de_Inventario
{
    internal class SQL
    {
        private string cadena = "Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;";
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
