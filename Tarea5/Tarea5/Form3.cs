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
    public partial class Form3 : Form
    {
        Class1 registro = new Class1();
        int index;

        public Form3()
        {
            InitializeComponent();
            visibilidad(false);


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registro.cedula = int.Parse(txtCedula.Text);
            registro.nombre = txtNombre.Text;
            registro.apellido = txtApellido.Text;
            registro.edad = int.Parse(txtEdad.Text);
            registro.salario = int.Parse(txtSalario.Text);
            registro.prestamos = chkPrestamos.Checked;
            registro.anoslabor = int.Parse(txtAnosLabo.Text);
            registro.email = txtEmail.Text;
            registro.oficina = txtOficina.Text;


            //Form1.lista.Add(registro);
            Form1.lista.RemoveAt(index);
            Form1.lista.Insert(index, registro);

            visibilidad(false);
        }

        private void visibilidad(Boolean estado)
        {
            lblAñosLabo.Visible = estado;
            lblApellido.Visible = estado;
            lblCedula.Visible = estado;
            lblEdad.Visible = estado;
            lblEmail.Visible = estado;
            lblNombre.Visible = estado;
            lblOficina.Visible = estado;
            lblPrestamos.Visible = estado;
            lblSalario.Visible = estado;



            lblDeducciones.Visible = estado;
            lblDedu.Visible = estado;
            lblIncentivos.Visible = estado;
            lblInce.Visible = estado;
            lblSalarioTotal.Visible = estado;
            lblSala.Visible = estado;
            lblSalaTitulo.Visible = estado;


            txtAnosLabo.Visible = estado;
            txtApellido.Visible = estado;
            txtCedula.Visible = estado;
            txtEdad.Visible = estado;
            txtEmail.Visible = estado;
            txtNombre.Visible = estado;
            txtOficina.Visible = estado;
            txtSalario.Visible = estado;

            chkPrestamos.Visible = estado;

            btnGuardar.Visible = estado;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            double deducciones = 0, incentivos = 0, total = 0;
            index = -1;

            foreach (Class1 registro2 in Form1.lista)
            {
                if (registro2.cedula == int.Parse(txtBuscar.Text))
                {
                    visibilidad(true);
                    

                    txtCedula.Text = registro2.cedula.ToString();
                    txtNombre.Text = registro2.nombre;
                    txtApellido.Text = registro2.apellido;
                    txtEdad.Text = registro2.edad.ToString();
                    txtSalario.Text = registro2.salario.ToString();
                    chkPrestamos.Checked = registro2.prestamos;
                    txtAnosLabo.Text = registro2.anoslabor.ToString();
                    txtEmail.Text = registro2.email;
                    txtOficina.Text = registro2.oficina;

                    if (registro2.prestamos) 
                    {
                        lblDedu.Text = "28%";
                        deducciones = 28;
                    }
                    else
                    {
                        lblDedu.Text = "18%";
                        deducciones = 18;
                    }

                    if (registro2.salario >= 500000)
                        incentivos = 5;

                    if (registro2.anoslabor >= 10)
                        incentivos = incentivos + 10;

                    lblInce.Text = incentivos.ToString()+"%";

                    total = registro2.salario;
                    total = registro2.salario - (total * (deducciones / 100)) + (total * (incentivos / 100));
                    
                    lblSala.Text = total.ToString();

                    index = Form1.lista.IndexOf(registro2);
                }
            }

            if (index == -1)
                MessageBox.Show("La cedula no existe en el registro", "No existente");
        }


    }
}
