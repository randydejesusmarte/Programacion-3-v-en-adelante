using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante.Atributos
{
    public class DB : Attribute
    {
        private readonly SqlConnection Connection = new SqlConnection("Data Source = RANDY\\SQLEXPRESS;  Initial Catalog = hidra; Integrated Security = True;");

        public void FillDB(string sql, DataGridView dataGridView)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                sqlData.SelectCommand = new SqlCommand(sql, Connection);
                sqlData.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                Connection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                Connection.Close();
            }
        }
    }
}
