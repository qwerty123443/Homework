﻿using System;
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
        private double[] profits = new double[MAX_DESTINATINOS];
        private bool[] booked = new bool[MAX_DESTINATINOS];
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
                destinations[index] = destination;
                prices[index] = price;
                profits[index] = profit;
                lstDestinations.Items.Add(destinations[index] + " costs " + prices[index].ToString("0.00") + ".\n Profit is " + profits[index]);
                index++;
                lblTotalProfit.Text = "Total Profit: €" + totalProfit;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            index--;
            lstDestinations.Items.RemoveAt(index);
            totalProfit -= profits[index];
            lblTotalProfit.Text = "Total Profit: €" + totalProfit;
        }

        private void btnBookDestination_Click(object sender, EventArgs e)
        {
            int i = lstDestinations.SelectedIndex;
            booked[i] = true;
        }
    }
}
