using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2._2_Toggle_colors_extended
{
    public partial class fmColor : Form
    {
        public fmColor()
        {
            InitializeComponent();
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            if (fmColor.ActiveForm.BackColor == Color.Red)
            {
                fmColor.ActiveForm.BackColor = Color.White;
            }
            else if (fmColor.ActiveForm.BackColor == Color.White)
            {
                fmColor.ActiveForm.BackColor = Color.Blue;
            }
            else
            {
                fmColor.ActiveForm.BackColor = Color.Red;
            }

        }
    }
}
