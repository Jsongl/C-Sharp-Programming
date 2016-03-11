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
    public partial class Form3 : Form
    {
        int index;

        public Form3()
        {
            InitializeComponent();
            visibilidad(false);
            visibilidadBusqueda(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                index = VideoClub.BuscarCodigo(int.Parse(txtBuscar.Text));

                if (index == -1)
                {
                    MessageBox.Show("Codigo no encontrado", "Error");
                }
                else
                    rellenarcampos();
            }
            catch
            {
                MessageBox.Show("Formato de codigo incorrecto", "Error");
            }
        }

        private void rellenarcampos ()
        {
            Clase temporal = new Clase();

            temporal = VideoClub.RetornarRegistro(index);

            txtCodigo.Text = temporal.codigo.ToString();
            txtTitulo.Text = temporal.titulo;
            txtAño.Text = temporal.ano.ToString();
            txtCalificacion.Text = temporal.calificacion.ToString();
            txtClasificacion.Text = temporal.clasificacion;
            txtCategoria.Text = temporal.categoria;

            visibilidad(true);
            visibilidadBusqueda(false);
        }

        private void visibilidad (Boolean estado)
        {
            txtCodigo.Visible = estado;
            txtTitulo.Visible = estado;
            txtAño.Visible = estado;
            txtCalificacion.Visible = estado;
            txtClasificacion.Visible = estado;
            txtCategoria.Visible = estado;
            lblCodigo.Visible = estado;
            lblTitulo.Visible = estado;
            lblAño.Visible = estado;
            lblCalificacion.Visible = estado;
            lblClasificacion.Visible = estado;
            lblCategoria.Visible = estado;
            btnGuardar.Visible = estado;
        }

        private void visibilidadBusqueda(Boolean estado)
        {
            txtBuscar.Visible = estado;
            lblBuscar.Visible = estado;
            btnBuscar.Visible = estado;
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
                VideoClub.Modificar(index, temporal);
            }
            catch
            {
                MessageBox.Show("Error al guardar. Revise todos los campos", "Error");
                return;
            }

            MessageBox.Show("Modificacion exitosa", "Info");
            Close();
        }
    }
}
