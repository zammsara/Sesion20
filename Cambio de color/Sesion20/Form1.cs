using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion20
{
    public partial class Form1 : Form
    {
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 3000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Text = "UAM";
                BackColor = Color.Red;
            }
            else
            {
                this.Text = "Hola";
                BackColor = Color.DarkGreen;
            }
            flag = !flag;

        }
    }
}
