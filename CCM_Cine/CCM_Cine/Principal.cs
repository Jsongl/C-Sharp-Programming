using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCM_Cine
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            Lista_peliculas.cargarDB();

            btnSync.Visible = false;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Peliculas formPeliculas = new Form_Peliculas();

            formPeliculas.MdiParent = this;
            formPeliculas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista_peliculas.guardarCambiosDB();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        public void Cambios_pendientes()
        {
            
            btnSync.Visible = true;
        }

        private static void asd()
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cambios_pendientes();
        }
    }
}
