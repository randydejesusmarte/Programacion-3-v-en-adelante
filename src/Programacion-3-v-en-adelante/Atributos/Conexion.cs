using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Programacion_3_v_en_adelante.Atributos
{
    internal class Conexion
    {
        internal SqlConnection SqlConnectio = new SqlConnection();
        internal string cadena = ConfigurationManager.ConnectionStrings["Properties.Settings.Conecctionstring"].ConnectionString;

        internal Conexion()
        {
            SqlConnectio.ConnectionString = cadena;
        }
        public SqlConnection Open()
        {
            if (SqlConnectio.State == ConnectionState.Closed)
            { 
                SqlConnectio.Open(); 
            }
            return SqlConnectio;
        }

        public SqlConnection Close()
        {
            if (SqlConnectio.State == ConnectionState.Open)
            {
                SqlConnectio.Close(); 
            }
            return SqlConnectio;
        }
    }
}
