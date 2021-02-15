using Programacion_3_v_en_adelante.Atributos;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante.Forms
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            new DB().FillDB(
                sql: "select * from login",
                dataGridView: dataGridView1);
        }
    }
}
