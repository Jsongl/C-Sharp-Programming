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

namespace Frameless_rotation
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static Form3 rotacion2 = new Form3();
        static Form4 rotacion3 = new Form4();
        static Form5 rotacion4 = new Form5();
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 rotacion1 = new Form2();

            rotacion1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rotacion2.Show();
            rotacion3.Show();
            rotacion4.Show();

            rotacion2.Left = 700;
            rotacion3.Left = 850;
            rotacion4.Left = 1000;
            rotacion2.Top = 400;
            rotacion3.Top = 400;
            rotacion4.Top = 400;


            myTimer.Tick += new EventHandler(TimerEventProcessor);

            myTimer.Interval = 1000;
            myTimer.Start();
            Application.DoEvents();
        }

        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            rotacion2.test(Class1.arreglo[contador]);
            rotacion3.test(Class1.arreglo[incrementa(contador)]);
            rotacion4.test(Class1.arreglo[incrementa(incrementa(contador))]);
            contador = incrementa(contador);
        }

        public int incrementa(int x)
        {
            if (x == Class1.arreglo.Length-1)
                return 0;
            else
                return x+1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png"; 
            dialog.Multiselect = false;
 
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                String path = dialog.FileName; 

                FileStream Destino = new FileStream(@"C:\\test.png", FileMode.CreateNew);

                using (FileStream source = File.Open(path, FileMode.Open))
                {
                    source.CopyTo(Destino);
                   
                }

                Destino.Close();
                

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 rotacion5 = new Form6();

            rotacion5.Show();
        }



    }
}
