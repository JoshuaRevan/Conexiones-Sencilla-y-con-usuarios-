using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexion_SQL_Server.Clases
{
    internal class Conexion
    {
        SqlConnection conex = new SqlConnection();

         static string servidor = "DESKTOP-SG8MU6B";
         static string bd= "Supermercado";
         /*static string usuario="se";
         static string password= "admin12345";
         static string puerto= "1433";*/

        // instancia usada para conexiones sencillas
        string cadenaConexion = $"Data Source={servidor};Initial Catalog={bd};Integrated Security=True;";

        //en dado caso esta linea de codigo se puede usar en conexiones que requieran usuarios
        //string cadenaConexion = $"Data Source={servidor},{puerto};Initial Catalog={bd};User ID={usuario};Password={password};";

        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString= cadenaConexion;
                conex.Open();
                MessageBox.Show("Se Conecto correctamente a la base de datos");

            }
            catch(SqlException e)
            {
                MessageBox.Show("No se logro conectar a la base de datos " + e.ToString());
            }
            return conex;
        }
    }
}
