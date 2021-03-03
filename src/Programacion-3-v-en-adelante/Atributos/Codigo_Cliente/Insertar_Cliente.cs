using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Programacion_3_v_en_adelante.Atributos
{
    internal class Insertar_Cliente : Attribute
    {
        internal readonly Conexion conexion = new Conexion();
        internal SqlCommand command = new SqlCommand();
        internal void Insertar(string Nombre,string Telefono,string Direccion)
        {
            command.Connection = conexion.Open();
            command.CommandText = "sp_insertar_cliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Telefono", Telefono);
            command.Parameters.AddWithValue("@Direccion", Direccion);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.Close();
        }
    }
}
