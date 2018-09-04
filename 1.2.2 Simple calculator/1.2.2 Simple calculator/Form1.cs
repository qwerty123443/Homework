using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2._2_Simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToDouble(tbNum1.Text) + Convert.ToDouble(tbNum2.Text));
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToDouble(tbNum1.Text) - Convert.ToDouble(tbNum2.Text));

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToDouble(tbNum1.Text) * Convert.ToDouble(tbNum2.Text));

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToDouble(tbNum1.Text) / Convert.ToDouble(tbNum2.Text));

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tbInfo.Visible = true;
            btnShow.Visible = false;
            btnHide.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            tbInfo.Visible = false;
            btnShow.Visible = true;
            btnHide.Visible = false;
        }
    }
}
