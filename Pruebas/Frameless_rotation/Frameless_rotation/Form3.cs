using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameless_rotation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        
        public void test(String x)
        {
            String picture = @"..\..\imgs\"+x+".png";
            pcbx.ImageLocation = (picture);

            txtTimer.Text = x;

        }

    }
}
