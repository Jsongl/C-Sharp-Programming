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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            String registro;

            registro = "Cedula\tNombre\tApellido\tEdad\tSalario\tPrestamo\t\tAños Labor\tEmail\tOficina";

            lstGeneral.Items.Add(registro);

            foreach (Class1 registro2 in Form1.lista)
            {
                registro = registro2.cedula.ToString() + "\t" + registro2.nombre + "\t" + registro2.apellido + "\t" + registro2.edad.ToString() + "\t" + registro2.salario.ToString() + "\t" + registro2.prestamos + "\t\t" + registro2.anoslabor.ToString() + "\t\t" + registro2.email + "\t" + registro2.oficina;

               lstGeneral.Items.Add(registro);
            }
        }


    }
}
