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
        private Destination[] destinations = new Destination[35];
        private double totalProfit = 0;
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (index <= 35)
            {
                string destination = tbDestination.Text;
                double price = Convert.ToDouble(tbPrice.Text);
                double profit = Convert.ToDouble(tbProfit.Text);

                totalProfit += profit;
                destinations[index] = new Destination(destination, price, profit);
                lstDestinations.Items.Add(destinations[index].getDestination() + " costs " + destinations[index].getPrice().ToString("0.00") + ".\n Profit is " + destinations[index++].getProfit());
                lblTotalProfit.Text = "Total Profit: €" + totalProfit;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstDestinations.Items.RemoveAt(--index);
            totalProfit -= destinations[index].getProfit();
            lblTotalProfit.Text = "Total Profit: €" + totalProfit;
        }

        private void btnBookDestination_Click(object sender, EventArgs e)
        {
            int i = lstDestinations.SelectedIndex;
            destinations[i].book(1);
        }
    }
}
