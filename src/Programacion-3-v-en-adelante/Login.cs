using Programacion_3_v_en_adelante.Atributos;
using System;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Validacion_de_Entrada Entrada = new Validacion_de_Entrada();

        private void btentrar_Click(object sender, EventArgs e)
        {

            Entrada.login("login", "uid", txtnombre, "pass", txtclave, new Menu());
            Hide();
        }
    }
}
