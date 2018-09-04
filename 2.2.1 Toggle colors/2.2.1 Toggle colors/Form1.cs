using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2._1_Toggle_colors
{
    public partial class fmColor : Form
    {
        public fmColor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fmColor.ActiveForm.BackColor == Color.Blue)
            {
                fmColor.ActiveForm.BackColor = Color.Green;
            } else {
                fmColor.ActiveForm.BackColor = Color.Blue;
            }
        }
    }
}
