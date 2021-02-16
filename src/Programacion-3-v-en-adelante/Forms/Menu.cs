using Programacion_3_v_en_adelante.Forms;
using System;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private readonly menu FormH = new menu();

        private void Con_Us_Click(object sender, EventArgs e)
        {
            FormH.Form_Heredado(form: new Consulta(), panel: screen);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
