using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2._3_Truck_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int boxes = Convert.ToInt32(tbOrderAmount.Text);
            
            
            int remainingboxes;
            int remainingPallets;
            int fulltrucks;
            double price = 0;
            if (rbCompanyA.Checked)
            {
                int boxesPerPallet = 30;
                int truckCapacity = 20;
                remainingboxes = boxes % boxesPerPallet;
                remainingPallets = (boxes / boxesPerPallet) % truckCapacity;
                fulltrucks = boxes / boxesPerPallet / truckCapacity;
                price = 400 * fulltrucks + 25 * remainingPallets + 1.5 * remainingboxes;
            }
            else if (rbCompanyB.Checked)
            {
                int boxesPerPallet = 30;
                int truckCapacity = 24;
                remainingboxes = boxes % boxesPerPallet;
                remainingPallets = (boxes / boxesPerPallet) % truckCapacity;
                fulltrucks = boxes / boxesPerPallet / truckCapacity;
                price = 430 * fulltrucks + 19 * remainingPallets + 1.25 * remainingboxes;
            }
            else if (rbCompanyC.Checked)
            {
                int boxesPerPallet = 35;
                int truckCapacity = 28;
                remainingboxes = boxes % boxesPerPallet;
                remainingPallets = (boxes / boxesPerPallet) % truckCapacity;
                fulltrucks = boxes / boxesPerPallet / truckCapacity;
                price = 500 * fulltrucks + 34 * remainingPallets + 2.5 * remainingboxes;
            }
            else
            {
                MessageBox.Show("Please select a shipping company");
                return;
            }
            MessageBox.Show(fulltrucks + " full truck(s)\n" + remainingPallets + " remaining pallets\n" + remainingboxes + " remaining boxes\n€ " + price.ToString("0.00") + " shipping ");
        }
    }
}
