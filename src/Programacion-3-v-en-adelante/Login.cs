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

        private readonly Validacion_de_Entrada Entrada = new Validacion_de_Entrada();

        private void Btentrar_Click(object sender, EventArgs e)
        {
            Entrada.login(Tabla: "login", Campo1: "uid", Usuario: txtnombre, Campo2: "pass", Clave: txtclave, Menu: new Menu(),btentrar);
        }
    }
}
