using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion20_1
{
    public partial class Form1 : Form
    {
            bool flag = true;
            int maxWidth = 800;  // Ancho máximo deseado
            int maxHeight = 600; // Altura máxima deseada
            public Form1()
            {
                InitializeComponent();
                Timer timer1 = new Timer();
                timer1.Interval = 100; // Ajusta la velocidad de crecimiento
                timer1.Enabled = true;
                timer1.Tick += timer1_Tick;
                timer1.Start();
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                if (Width < maxWidth || Height < maxHeight)
                {
                    Width = Math.Min(Width + 10, maxWidth);  // Incrementa el ancho
                    Height = Math.Min(Height + 10, maxHeight); // Incrementa la altura
                }
                else
                {
                    (sender as Timer).Stop();
                }
            }
        }
}
