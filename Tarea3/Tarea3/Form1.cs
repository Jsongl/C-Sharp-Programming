using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class Form1 : Form
    {
        static int hombres = 0;
        static int mujeres = 0;
        static int[] clasificacion = { 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void rdbMujer_CheckedChanged(object sender, EventArgs e)
        {
            rdbHombre.Checked = false;
        }

        private void rdbHombre_CheckedChanged(object sender, EventArgs e)
        {
            rdbMujer.Checked = false;

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (rdbHombre.Checked)
            {
                hombres++;
                contadorEdad();
            }
            else if (rdbMujer.Checked)
            {
                mujeres++;
                contadorEdad();
            }
            else
                MessageBox.Show("Genero no definido", "Error");

            if ((hombres+mujeres) >= 5)
            {
                if (!lblTotal.Visible)
                    habilitarcampos();

                txtTotal.Text = (hombres + mujeres).ToString();
                txtMujeres.Text = mujeres.ToString();
                txtHombres.Text = hombres.ToString();
                txt18.Text = clasificacion[0].ToString();
                txt29.Text = clasificacion[1].ToString();
                txt30.Text = clasificacion[2].ToString();
            }

            txtNombre.Text = "";
            txtEdad.Text = "";
        }

        void habilitarcampos()
        {
            lblTotal.Visible = true;
            lblMujeres.Visible = true;
            lblHombres.Visible = true;
            lbl18.Visible = true;
            lbl29.Visible = true;
            lbl30.Visible = true;

            txtTotal.Visible = true;
            txtMujeres.Visible = true;
            txtHombres.Visible = true;
            txt18.Visible = true;
            txt29.Visible = true;
            txt30.Visible = true;

            txtBxMsg.Visible = false;
            btncalcular.Enabled = true;
        }

        void contadorEdad()
        {
            String Field = txtEdad.Text;
            int edad = int.Parse(Field);

            if (edad <= 18)
                clasificacion[0]++;
            else if (edad >= 19 && edad <= 29)
                clasificacion[1]++;
            else 
                clasificacion[2]++;
        }

        void calcular ()
        {
            txtTotal.Text = (hombres + mujeres).ToString();
            txtMujeres.Text = mujeres.ToString();
            txtHombres.Text = hombres.ToString();
            txt18.Text = clasificacion[0].ToString();
            txt29.Text = clasificacion[1].ToString();
            txt30.Text = clasificacion[2].ToString();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (hombres + mujeres).ToString();
            txtMujeres.Text = mujeres.ToString();
            txtHombres.Text = hombres.ToString();
            txt18.Text = clasificacion[0].ToString();
            txt29.Text = clasificacion[1].ToString(); 
            txt30.Text = clasificacion[2].ToString();
        }

    }
}
