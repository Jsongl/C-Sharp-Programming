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
    public partial class Form4 : Form
    {
        int index;

        public Form4()
        {
            InitializeComponent();
            visibilidad(false);
            visibilidadBusqueda(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void visibilidad(Boolean estado)
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
            btnReiniciar.Visible = estado;
        }

        private void visibilidadBusqueda(Boolean estado)
        {
            txtBuscar.Visible = estado;
            lblBuscar.Visible = estado;
            btnBuscar.Visible = estado;
        }

        private void rellenarcampos()
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

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            VideoClub.Eliminar(index);

            MessageBox.Show("Borrado Exitoso", "Info");
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtClasificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClasificacion_Click(object sender, EventArgs e)
        {

        }

        private void txtCalificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCalificacion_Click(object sender, EventArgs e)
        {

        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAño_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
