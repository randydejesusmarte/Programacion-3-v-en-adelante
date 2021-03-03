using Programacion_3_v_en_adelante.Atributos;
using Programacion_3_v_en_adelante.Atributos.Codigo_Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        private int id;
        private void Guardar_Click(object sender, EventArgs e)
        {
            new Insertar_Cliente().Insertar(Nombre: txt_Nombre.Text, Telefono: mtxt_Telefono.Text, Direccion: txt_Direccion.Text);
            MessageBox.Show("Registro Exitoso","Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            new Actualizar_Cliente().Acualizar(Nombre: txt_Nombre.Text, Telefono: mtxt_Telefono.Text, Direccion: txt_Direccion.Text, id: id);
            MessageBox.Show("Actualizacion Exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            txt_Nombre.Text = row.Cells[1].Value.ToString();
            mtxt_Telefono.Text = row.Cells[2].Value.ToString();
            txt_Direccion.Text = row.Cells[3].Value.ToString();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            dataGridView1.DataSource = new Listar_Clientes().Mostrar_Clientes();
        }
    }
}
