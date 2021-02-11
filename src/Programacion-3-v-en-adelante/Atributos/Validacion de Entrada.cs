using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Programacion_3_v_en_adelante.Atributos
{
    public class Validacion_de_Entrada : Attribute
    {
        SqlConnection connection = new SqlConnection("Data Source = RANDY\\SQLEXPRESS; Initial Catalog = hidra; Integrated Security = True;");
        public void login(string tabla,string campo1, TextBox usuario, string campo2,TextBox clave,Form menu)
        {
            if (string.IsNullOrEmpty(usuario.Text) || string.IsNullOrEmpty(clave.Text))
            {
                MessageBox.Show("faltan ingresar el usuario u la contraceña");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select count(*) from {tabla} where {campo1} = '{usuario.Text}' and {campo2} = '{clave.Text}'", connection);
                    int valor = int.Parse(command.ExecuteScalar().ToString());
                    switch (valor)
                    {
                        case 0:
                            MessageBox.Show("el usuario no existe");
                            break;
                        case 1:
                            menu.Show();
                            break;
                    }
                    connection.Close();
                }catch(Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }

        }
    }
}
