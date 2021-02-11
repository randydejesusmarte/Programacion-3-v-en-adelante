using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Programacion_3_v_en_adelante.Atributos
{
    public class DB : Attribute
    {
        SqlConnection connection = new SqlConnection("Data Source = RANDY\\SQLEXPRESS;  Initial Catalog = hidra; Integrated Security = True;");
        public void FillDB(string sql, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                sqlData.SelectCommand = new SqlCommand(sql, connection);
                sqlData.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                connection.Close();
            }
        }
    }
}
