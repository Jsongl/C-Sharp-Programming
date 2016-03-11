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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void lstGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int numeroregistros;
            String registro;

            numeroregistros = VideoClub.Tamaño()-1;
                     

            registro = "Codigo\tTitulo\tAño\tCalificacion\tClasificacion\tCategoria";

            lstGeneral.Items.Add(registro);

            if (numeroregistros >= 0)
            {
                Clase temporal = new Clase();

                for (int index = 0; index <= numeroregistros; index++)
                {
                    temporal = VideoClub.RetornarRegistro(index);

                    registro = temporal.codigo.ToString() + "\t" + temporal.titulo + "\t" + temporal.ano.ToString() + "\t" + temporal.calificacion.ToString() + "\t\t" +
                                 temporal.clasificacion + "\t\t" + temporal.categoria;

                    lstGeneral.Items.Add(registro);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
