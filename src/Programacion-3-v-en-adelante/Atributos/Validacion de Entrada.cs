using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante.Atributos
{
    internal class Validacion_de_Entrada : Attribute
    {
        private readonly Conexion Confi = new Conexion();
        
        internal void login(string Tabla, string Campo1, TextBox Usuario, string Campo2, TextBox Clave, Form Menu,Button button)
        {
            if (string.IsNullOrEmpty(Usuario.Text) || string.IsNullOrEmpty(Clave.Text))
            {
                MessageBox.Show("faltan ingresar el usuario u la contraceña");
            }
            else
            {
                try
                {
                    Confi.Open();
                    SqlCommand command = new SqlCommand($"select count(*) from {Tabla} where {Campo1} = '{Usuario.Text}' and {Campo2} = '{Clave.Text}'", Confi.SqlConnectio);
                    int valor = int.Parse(command.ExecuteScalar().ToString());
                    switch (valor)
                    {
                        case 0:
                            MessageBox.Show("el usuario no existe");
                            break;
                        case 1:
                            Menu.Show();
                            Usuario.Enabled = Clave.Enabled = button.Enabled = false;
                            break;
                        default:
                            MessageBox.Show("el usuario no existe");
                            break;
                    }
                    Confi.Close();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                    Confi.Close();
                }
            }

        }
    }
}
