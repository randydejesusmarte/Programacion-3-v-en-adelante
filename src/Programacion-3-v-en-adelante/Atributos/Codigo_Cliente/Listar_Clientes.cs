using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante.Atributos.Codigo_Cliente
{
    internal class Listar_Clientes : Attribute
    {
        private readonly Conexion conexion = new Conexion();
        private readonly SqlCommand command = new SqlCommand();
        private readonly DataTable datos = new DataTable();
        internal DataTable Mostrar_Clientes()
        {
                command.Connection = conexion.Open();
                command.CommandText = "sp_mostrar_cliente";
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader leer = command.ExecuteReader();
                datos.Load(leer);
                conexion.Close();
                return datos;
        }
    }
}
