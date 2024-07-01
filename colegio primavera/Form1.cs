using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colegio_primavera
{
    public partial class Form1 : Form
    {
        int poc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dataGridViewDatos.Rows.Add();

            dataGridViewDatos.Rows[n].Cells[0].Value = textBoxNombre.Text;
            dataGridViewDatos.Rows[n].Cells[1].Value = textboxApellido.Text;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dataGridViewDatos[0, poc].Value = textBoxNombre.Text;
            dataGridViewDatos[1, poc].Value = textboxApellido.Text;

        }

        private void dataGridViewDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridViewDatos.CurrentRow.Index;

            textBoxNombre.Text = dataGridViewDatos[0, poc].Value.ToString();
            textboxApellido.Text = dataGridViewDatos[1, poc].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridViewDatos.Rows.RemoveAt(poc);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textboxApellido.Text = "";
            
        }
    }
}
