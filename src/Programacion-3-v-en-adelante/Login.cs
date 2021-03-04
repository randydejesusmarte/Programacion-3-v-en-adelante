using Programacion_3_v_en_adelante.Atributos;
using Programacion_3_v_en_adelante.Atributos.Codigo_Login;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private Login_conect login = new Login_conect();

        private void Btentrar_Click(object sender, EventArgs e)
        {

            int result = login.Logear(txtnombre.Text, txtclave.Text);
            if (result == 1)
            {
                new Menu().Show();
                Hide();

            }
            else if (result == 0)
            {
                MessageBox.Show("Contraseña o Usuario son incorrecto");
            }
        }
    }
}
