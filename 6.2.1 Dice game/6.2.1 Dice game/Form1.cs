using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2._1_Dice_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayOnce_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profit is €" + runGame(1));
        }
        private void btnPlayX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average profit is €" + runGame(Convert.ToInt32(textBox1.Text)));
        }
        private int runGame(int x)
        {
            int amountOfGames = x;
            int profit;
            int profits = 0;
            for (; x > 0; x--)
            {
                Random random = new Random();
                profit = -4;
                while (random.Next(1, 7) != 6)
                {
                    profit++;
                }
                profits += profit;
                
            }
            return profits/amountOfGames;
        }


    }
}
