using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2._2_Travel_agency
{
    public partial class Form1 : Form
    {
        private static int MAX_DESTINATINOS = 35;

        private string[] destinations = new string[MAX_DESTINATINOS];
        private double[] prices = new double[MAX_DESTINATINOS];
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index <= 35)
            {
                string destination = tbDestination.Text;
                double price = Convert.ToDouble(tbPrice.Text);
                destinations[index] = destination;
                lstDestinations.Items.Add(destinations[index] + " costs " + prices[index]);
                prices[index] = price;
                index++;
            }
        }
    }
}
