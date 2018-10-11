using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2._2_Container_management
{
    public partial class Form1 : Form
    {
        private Harbour harbour = new Harbour("Rotterdam");
        private Transportable[] containers = new Transportable[100];
        private int transportableIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            containers[transportableIndex] = new Transportable(tbContainerContent.Text, Convert.ToInt32(tbContainerWeight.Text));
            lbContainers.Items.Add($"{transportableIndex}:  {containers[transportableIndex].getWeight()} Tons");
            transportableIndex++;
        }

        private void btnCreateShip_Click(object sender, EventArgs e)
        {
            harbour.CreateShip(tbShipName.Text, Convert.ToInt32(tbShipMaxWeight.Text));
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            int totalWeight = 0;
            int index = 0;
            while (totalWeight <= harbour.NumberOfTransportablesFitOnShip() && index < transportableIndex)
            {
                totalWeight += containers[index].getWeight();
                index++;
            }
            if (totalWeight > harbour.NumberOfTransportablesFitOnShip())    // Filled the ship completely, so we went 1 too far. 
            {                                   // Go back 1
                index--;
                totalWeight -= containers[index].getWeight();
            }

            label1.Text = "Number of containers to load on the ship is " + index + " weighing " + totalWeight;
        }
    }
}
