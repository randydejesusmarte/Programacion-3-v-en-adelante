using System;
using System.Windows.Forms;

namespace Programacion_3_v_en_adelante
{
    public class menu : Attribute
    {
        public void Form_Heredado(Form form, Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }
    }
}
