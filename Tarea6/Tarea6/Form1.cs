using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nuevo = new Form2();

            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 modificar = new Form3();

            modificar.MdiParent = this;
            modificar.Show();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 eliminar = new Form4();

            eliminar.MdiParent = this;
            eliminar.Show();
        }

        private void buscarPorCodigoNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 buscar = new Form5();

            buscar.MdiParent = this;
            buscar.Show();
        }

        private void verListadoTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 listado = new Form6();

            listado.MdiParent = this;
            listado.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VideoClub.prellenado();
        }
    }
}
