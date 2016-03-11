using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int numero = 0, operacion = 5;
        String numerotxt = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt1_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0) 
                numerotxt = "1";
            else
                numerotxt = numerotxt + '1';
            txtpantalla.Text = numerotxt;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "2";
            else
                numerotxt = numerotxt + '2';
            txtpantalla.Text = numerotxt;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "3";
            else
                numerotxt = numerotxt + '3';
            txtpantalla.Text = numerotxt;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "4";
            else
                numerotxt = numerotxt + '4';
            txtpantalla.Text = numerotxt;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "5";
            else
                numerotxt = numerotxt + '5';
            txtpantalla.Text = numerotxt;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "6";
            else
                numerotxt = numerotxt + '6';
            txtpantalla.Text = numerotxt;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "7";
            else
                numerotxt = numerotxt + '7';
            txtpantalla.Text = numerotxt;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "8";
            else
                numerotxt = numerotxt + '8';
            txtpantalla.Text = numerotxt;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "9";
            else
                numerotxt = numerotxt + '9';
            txtpantalla.Text = numerotxt;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (numerotxt == "0" || operacion == 0)
                numerotxt = "0";
            else
                numerotxt = numerotxt + '0';
            txtpantalla.Text = numerotxt;
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            numero = int.Parse(numerotxt);
            numerotxt = "";
            operacion = 1;
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            numero = int.Parse(numerotxt);
            numerotxt = "";
            operacion = 2;
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            numero = int.Parse(numerotxt);
            numerotxt = "";
            operacion = 3;
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            numero = int.Parse(numerotxt);
            numerotxt = "";
            operacion = 4;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            int total; 

            if (int.Parse(numerotxt) == 0 && operacion == 4)
            {
                txtpantalla.Text = "# / 0 ";
                total = 0;
            }
            else
            {
                switch (operacion)
                {
                    case 1: total = numero + int.Parse(numerotxt); break;
                    case 2: total = numero - int.Parse(numerotxt); break;
                    case 3: total = numero * int.Parse(numerotxt); break;
                    case 4: total = numero / int.Parse(numerotxt); break;
                    default: total = int.Parse(numerotxt); break;
                }

                txtpantalla.Text = total.ToString();
            }

            numero = total;
            numerotxt = total.ToString();
            operacion = 0;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            numero = 0;
            operacion = 5;
            numerotxt = "0";
            txtpantalla.Text = "";
        }

        private void btnretroceder_Click(object sender, EventArgs e)
        {
            if (numerotxt != "0" && numerotxt.Length > 0)
            {
                numerotxt = numerotxt.Substring(0, numerotxt.Length - 1);
                txtpantalla.Text = numerotxt;
            }
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            numerotxt = "";
            txtpantalla.Text = numerotxt;
        }
    }
}
