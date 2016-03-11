using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Frameless_rotation
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            cargar_datos();
        }

        private void cargar_datos ()
        {
            try
            {
                StreamReader archivo = new StreamReader(@"../../sqlConexion.txt");

                txtServidor.Text = archivo.ReadLine();
                txtNombreDB.Text = archivo.ReadLine();
                txtUsuario.Text = archivo.ReadLine();
                txtPassword.Text = archivo.ReadLine();

                archivo.Close();
            }
            catch
            {
                MessageBox.Show("Conexion a DB no configurada", "Error");
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }


        private void Connect_db ()
        {
            string connetionString = null;

            connetionString = "Data Source=172.16.6.115;Initial Catalog=Cine;User ID=sa;Password=sa";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    //MessageBox.Show("Connection Open ! ");

                    using (SqlCommand command = new SqlCommand("SELECT * FROM USUARIOS", cnn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           lstResultados.Items.Add(reader.GetString(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2) + "\t" + reader.GetInt32(3));
                        }
                    }


                        cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter(@"../../sqlConexion.txt", true);

            archivo.WriteLine(txtServidor.Text);
            archivo.WriteLine(txtNombreDB.Text);
            archivo.WriteLine(txtUsuario.Text);
            archivo.WriteLine(txtPassword.Text);

            archivo.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect_db();
            
        }


    }
}
