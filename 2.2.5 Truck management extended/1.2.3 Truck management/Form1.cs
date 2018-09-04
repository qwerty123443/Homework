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
            int boxesPerPallet = Convert.ToInt32(tbBoxes.Text);
            int truckCapacity = Convert.ToInt32(tbCapacity.Text);

            int remainingboxes = boxes % boxesPerPallet;
            int remainingPallets = (boxes / boxesPerPallet) % truckCapacity;
            int fulltrucks = boxes / boxesPerPallet / truckCapacity;
            MessageBox.Show(fulltrucks + " full truck(s)\n" + remainingPallets + " remaining pallets\n" + remainingboxes + " remaining boxes");
        }
    }
}
