using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2._3_Image_animation
{
    public partial class Form1 : Form
    {
        int dX = 20;
        int dY = -20;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                btnTest.Text = "Stop the show";
            }
            else
            {
                btnTest.Text = "Start the show";
            }
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = pbHero.Location;
            if (p.X <= 0 || p.X >= ClientSize.Width - pbHero.Width)
            {
                dX *= -1;
            }
            if (p.Y <= 0 || p.Y >= ClientSize.Height - pbHero.Height)
            {
                dY *= -1;
            }
            p.X += dX;
            p.Y += dY;
            pbHero.Location = p;
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tbSpeed.Value;
        }
    }
}
