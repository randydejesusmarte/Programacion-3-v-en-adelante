using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante.Atributos
{
    internal class DB : Attribute
    {
        private readonly Conexion Connection = new Conexion();

        public void FillDB(string sql, DataGridView dataGridView)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                sqlData.SelectCommand = new SqlCommand(sql, Connection.SqlConnectio);
                sqlData.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                Connection.SqlConnectio.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                Connection.SqlConnectio.Close();
            }
        }
    }
}
