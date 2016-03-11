using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExamenPractica3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader archivo = new StreamReader(@"C:\\test2.txt");

            txtbxGeneral.Text = archivo.ReadToEnd();

            archivo.Close();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            StreamReader archivo = new StreamReader(@"C:\\test2.txt");

            while (archivo.Peek() >= 0)
            {
                contador++;
                archivo.Read();
            }

            txtContador.Text = contador.ToString();

            archivo.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
