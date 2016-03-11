using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6
{
    public partial class Form2 : Form
    {
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
            Clase temporal = new Clase();

            try
            {
                temporal.codigo = int.Parse(txtCodigo.Text);
                temporal.titulo = txtTitulo.Text;
                temporal.ano = int.Parse(txtAño.Text);
                temporal.calificacion = int.Parse(txtCalificacion.Text);
                temporal.clasificacion = txtClasificacion.Text;
                temporal.categoria = txtCategoria.Text;
                VideoClub.Agregar(temporal); 
            }
            catch
            {
                MessageBox.Show("Error al guardar. Revise todos los campos", "Error");

                return;
            }

            MessageBox.Show("Guardado exitoso", "Info");

            Close();
        }

    }
}
