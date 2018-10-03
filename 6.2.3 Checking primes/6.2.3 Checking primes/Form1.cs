using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2._3_Checking_primes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckPrime_Click(object sender, EventArgs e)
        {
            
            ulong numberToCheck = Convert.ToUInt64(tbPrime.Text);
            ulong i = 1;
            bool numberFound = false;
            while (i+2 < numberToCheck && !numberFound)
            {
                i += 2;
                numberFound = numberToCheck % i == 0;
            }
            if (!numberFound)
            {
                MessageBox.Show($"{numberToCheck} is a prime number");
            }
            else
            {
                MessageBox.Show($"{numberToCheck} is not a prime number, it has divisor {i}");
            }
        }
    }
}
