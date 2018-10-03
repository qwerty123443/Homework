using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2._1_Calculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProblem1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbNumber.Text);
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += i;
            }
            lblResult.Text = result.ToString();
        }

        private void btnProblem2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbNumber.Text);
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += i;
                lbResult.Items.Add($"Sum is {result}. {(result > 0 ? $"last added is {i - 1}" : "")}\n");
            }
        }

        private void btnProlblem3_Click(object sender, EventArgs e)
        {
            int limit = Convert.ToInt32(tbNumber.Text);
            int result = 0;
            int i = 0;
            for (i = 0; result < limit; i++)
            {
                result += i * i;
            }
            i--;
            result -= i * i;
            lblResult.Text = $"answer is {result.ToString()}\n and {i-1}"; // i-1 because we have to use the last used i (and this i is the next i)
            
            // apperantly we can't use while loops yet
            //while (result < limit)
            //{
            //    i++;
            //    result += i * i;
            //}
            //result -= i * i;
            //i--;
            //lblResult.Text = $"answer is {result.ToString()}\n and {i}";
        }
    }
}
