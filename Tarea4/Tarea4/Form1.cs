using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;

namespace Tarea4
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String numero, empresa;

            AllocConsole();

            Console.WriteLine("---Registro de Aviones---\n\n");
            Console.WriteLine("El nuevo avion ira al hangar con espacio disponible.\n\n");


            Console.Write("Numero: ");
            numero = Console.ReadLine();

            Console.Write("Empresa: ");
            empresa = Console.ReadLine();

            acomodarnuevo(numero, empresa);
            FreeConsole();
        }

        void acomodarnuevo (String numero, String empresa)
        {
            if ((lstHangar1.Items.Count + lstHangar2.Items.Count + lstHangar3.Items.Count) < 30)
            {
                if (lstHangar1.Items.Count > lstHangar2.Items.Count || lstHangar1.Items.Count > lstHangar3.Items.Count)
                    if (lstHangar2.Items.Count > lstHangar3.Items.Count)
                        lstHangar3.Items.Add(numero + " - " + empresa);
                    else
                        lstHangar2.Items.Add(numero + " - " + empresa);
                else
                    lstHangar1.Items.Add(numero + " - " + empresa);
            }
            else if ((lstPista1.Items.Count + lstPista2.Items.Count + lstPista3.Items.Count) < 9)
            {
                if (lstPista1.Items.Count > lstPista2.Items.Count || lstPista1.Items.Count > lstPista3.Items.Count)
                    if (lstPista2.Items.Count > lstPista3.Items.Count)
                        lstPista3.Items.Add(numero + " - " + empresa);
                    else
                        lstPista2.Items.Add(numero + " - " + empresa);
                else
                    lstPista1.Items.Add(numero + " - " + empresa);
            }
            else
                MessageBox.Show("No queda espacio en el aeropuerto", "No espacio");
        }


        Boolean moverPista (object valor)
        {
            if ((lstPista1.Items.Count + lstPista2.Items.Count + lstPista3.Items.Count) < 9)
            {
                if (lstPista1.Items.Count > lstPista2.Items.Count || lstPista1.Items.Count > lstPista3.Items.Count)
                    if (lstPista2.Items.Count > lstPista3.Items.Count)
                        lstPista3.Items.Add(valor);
                    else
                        lstPista2.Items.Add(valor);
                else
                    lstPista1.Items.Add(valor);

                return true;
            }
            else
            {
                MessageBox.Show("No queda espacio en las pistas", "No espacio");

                return false;
            }
        }


        Boolean moverHangar(object valor)
        {
            if ((lstHangar1.Items.Count + lstHangar2.Items.Count + lstHangar3.Items.Count) < 30)
            {
                if (lstHangar1.Items.Count > lstHangar2.Items.Count || lstHangar1.Items.Count > lstHangar3.Items.Count)
                    if (lstHangar2.Items.Count > lstHangar3.Items.Count)
                        lstHangar3.Items.Add(valor);
                    else
                        lstHangar2.Items.Add(valor);
                else
                    lstHangar1.Items.Add(valor);

                return true;
            }
            else
            {
                MessageBox.Show("No queda espacio en los Hangares", "No espacio");

                return false;
            }
        }


        private void btnHangar_Click(object sender, EventArgs e)
        {
            while ((lstHangar1.SelectedIndex + lstHangar2.SelectedIndex + lstHangar3.SelectedIndex) > -3)
            {
                if (lstHangar1.SelectedIndex != -1)
                {
                    if (moverPista(lstHangar1.SelectedItem))
                        lstHangar1.Items.Remove(lstHangar1.SelectedItem);
                    else
                        break;
                }
                if (lstHangar2.SelectedIndex != -1)
                {
                    if (moverPista(lstHangar2.SelectedItem))
                        lstHangar2.Items.Remove(lstHangar2.SelectedItem);
                    else 
                        break;
                }
                if (lstHangar3.SelectedIndex != -1)
                {
                    if (moverPista(lstHangar3.SelectedItem))
                        lstHangar3.Items.Remove(lstHangar3.SelectedItem);
                    else 
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstHangar1.Items.Add("1-1");
            lstHangar1.Items.Add("2-2");
            lstHangar2.Items.Add("3-3");
            lstHangar2.Items.Add("4-4");
            lstHangar3.Items.Add("5-5");
            lstHangar3.Items.Add("6-6");
        }

        private void btnPista_Click(object sender, EventArgs e)
        {
            while ((lstPista1.SelectedIndex + lstPista2.SelectedIndex + lstPista3.SelectedIndex) > -3)
            {
                if (lstPista1.SelectedIndex != -1)
                {
                    if (moverHangar(lstPista1.SelectedItem))
                        lstPista1.Items.Remove(lstPista1.SelectedItem);
                    else
                        break;
                }
                if (lstPista2.SelectedIndex != -1)
                {
                    if (moverHangar(lstPista2.SelectedItem))
                        lstPista2.Items.Remove(lstPista2.SelectedItem);
                    else 
                        break;
                }
                if (lstPista3.SelectedIndex != -1)
                {
                    if (moverHangar(lstPista3.SelectedItem))
                        lstPista3.Items.Remove(lstPista3.SelectedItem);
                    else 
                        break;
                }
            }
        }

        private void agregarDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstHangar1.Items.Add("1 - Avianca");
            lstHangar1.Items.Add("2 - Lacsa");
            lstHangar2.Items.Add("3 - Spirit");
            lstHangar2.Items.Add("4 - Sansa");
            lstHangar3.Items.Add("5 - Lacsa");
            lstHangar3.Items.Add("6 - Demo");
            lstPista1.Items.Add("7 - American");
            lstPista2.Items.Add("8 - Sansa");
            lstPista3.Items.Add("9 - Avianca");
        }

    }
}
