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
    public partial class Form2 : Form
    {
        Class1 registro = new Class1();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
            

            Form1.lista.Add(registro);

            Close();
        }
    }
}
