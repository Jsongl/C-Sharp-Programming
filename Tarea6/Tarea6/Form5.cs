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
    public partial class Form5 : Form
    {
        int index;

        public Form5()
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
            btnReiniciar.Visible = estado;
        }

        private void visibilidadBusqueda(Boolean estado)
        {
            txtBuscar.Visible = estado;
            lblBuscar.Visible = estado;
            btnBuscar.Visible = estado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtTitulo.Text = "";
            txtAño.Text = "";
            txtCalificacion.Text = "";
            txtClasificacion.Text = "";
            txtCategoria.Text = "";
            txtBuscar.Text = "";

            visibilidad(false);
            visibilidadBusqueda(true);
        }
    }
}
