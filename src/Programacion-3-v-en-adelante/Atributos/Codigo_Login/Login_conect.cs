using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante.Atributos.Codigo_Login
{
    internal class Login_conect : Attribute
    {
        private readonly Conexion conexion = new Conexion();
        internal int Logear(string Nombre, string Contraceña)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand("sp_Login", conexion.SqlConnectio);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Clave", Contraceña);

                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    return dataReader.GetInt32(0);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
                
            }
            finally
            {
                conexion.Close();
            }
            return -1;
        }
    }
}
