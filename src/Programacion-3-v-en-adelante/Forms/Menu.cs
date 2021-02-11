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

        menu FormH = new menu();
        
        private void Con_Us_Click(object sender, EventArgs e)
        {
            FormH.Form_Heredado(new Consulta(),screen);
        }

        private void salir_Click(object sender, EventArgs e) => Application.Exit();
        
    }
}
