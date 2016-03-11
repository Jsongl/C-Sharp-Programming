using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5
{
    public partial class Form1 : Form
    {
        public static List<Class1> lista = new List<Class1>();
        Class1 registro = new Class1();




        public Form1()
        {
            demo();
            InitializeComponent();

        }

        private void demo ()
        {
            registro = new Class1();
            registro.cedula = 123;
            registro.nombre = "test";
            registro.apellido = "test";
            registro.edad = 123;
            registro.salario = 123;
            registro.prestamos = true;
            registro.anoslabor = 123;
            registro.email = "test";
            registro.oficina = "test";

            lista.Add(registro);

            registro = new Class1();
            registro.cedula = 1234;
            registro.nombre = "test";
            registro.apellido = "test";
            registro.edad = 123;
            registro.salario = 123;
            registro.prestamos = true;
            registro.anoslabor = 123;
            registro.email = "test";
            registro.oficina = "test";

            
            lista.Add(registro);
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formu2 = new Form2();

            formu2.MdiParent = this;

            formu2.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formu3 = new Form3();

            formu3.MdiParent = this;
            formu3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 formu4 = new Form4();

            formu4.MdiParent = this;
            formu4.Show();
        }
    }
}
