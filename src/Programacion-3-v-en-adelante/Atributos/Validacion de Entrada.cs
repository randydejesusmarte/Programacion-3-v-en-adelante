using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante.Atributos
{
    public class Validacion_de_Entrada : Attribute
    {
        private readonly SqlConnection connection = new SqlConnection("Data Source = RANDY\\SQLEXPRESS; Initial Catalog = hidra; Integrated Security = True;");

        public void login(string Tabla, string Campo1, TextBox Usuario, string Campo2, TextBox Clave, Form Menu,Button button)
        {
            if (string.IsNullOrEmpty(Usuario.Text) || string.IsNullOrEmpty(Clave.Text))
            {
                MessageBox.Show("faltan ingresar el usuario u la contraceña");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select count(*) from {Tabla} where {Campo1} = '{Usuario.Text}' and {Campo2} = '{Clave.Text}'", connection);
                    int valor = int.Parse(command.ExecuteScalar().ToString());
                    switch (valor)
                    {
                        case 0:
                            MessageBox.Show("el usuario no existe");
                            break;
                        case 1:
                            Menu.ShowDialog();
                            Usuario.Enabled = Clave.Enabled = button.Enabled = false;
                            break;
                        default:
                            break;
                    }
                    connection.Close();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }

        }
    }
}
