using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2._3_BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(tbWeight.Text);
            double length = Convert.ToDouble(tbHeight.Text);
            double bmi = weight / (length * length);
            lblBMI.Text = "Your BMI is: " + bmi.ToString("0.00");
            if(bmi < 18.5)
            {
                lblExplanation.Text = "You are underweight";
            }
            else if (bmi < 25)
            {
                lblExplanation.Text = "You are normal weight";
            }
            else if (bmi < 30)
            {
                lblExplanation.Text = "You are overweight";
            }
            else
            {
                lblExplanation.Text = "You are obese";
            }
        }
    }
}
