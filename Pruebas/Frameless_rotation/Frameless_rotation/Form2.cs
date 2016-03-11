using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Frameless_rotation
{
    public partial class Form2 : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();


        public Form2()
        {
            InitializeComponent();


            myTimer.Tick += new EventHandler(TimerEventProcessor);

            myTimer.Interval = 2000;
            myTimer.Start();
            Application.DoEvents();

        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }

        public  void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            txtTimer.Visible = !txtTimer.Visible;
        }


    }
}
