using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS1MockExam
{
    public partial class Form1 : Form
    {
        private static int NrOfBirdWatchers = 3;
        private BirdWatcher[] birdWatchers = new BirdWatcher[NrOfBirdWatchers];
        private BirdWatcher selectedBirdWatcher;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpotBird_Click(object sender, EventArgs e)
        {
            selectedBirdWatcher.AddBird(cmbSpottedBird.Text);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lblWatcherInfo.Text = selectedBirdWatcher.GetInfo();
            lblSeenToday.Text = $"Today he has seen {selectedBirdWatcher.getNrOfBirds().ToString()} birds";
            lblLastBirdSeen.Text = $"The last bird he saw was a {selectedBirdWatcher.GetLastBird()}";
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = selectedBirdWatcher.getNrOfBirds(); i<=selectedBirdWatcher.GetMaxBirds(); i++)
            {
                int j = random.Next(cmbSpottedBird.Items.Count);
                selectedBirdWatcher.AddBird(cmbSpottedBird.Items[j].ToString());
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            int total = 0;
            for(int i = 0; i < NrOfBirdWatchers; i++)
            {
                lbOutput.Items.Add(birdWatchers[i].GetSpottedBirds());
                total += birdWatchers[i].getNrOfBirds();
            }
            lbOutput.Items.Add($"\nIn total, {total} birds have been spotted today.");
        }

        private void btnShowAllBirds_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            for (int i = 0; i < NrOfBirdWatchers; i++)
            {
                lbOutput.Items.Add(birdWatchers[i].GetName());
                lbOutput.Items.Add("");
                int nrOfBirds = birdWatchers[i].getNrOfBirds();
                for (int j = 0; j < nrOfBirds; j++)
                {
                    lbOutput.Items.Add(birdWatchers[i].GetBird(j));
                }
                lbOutput.Items.Add("");
                lbOutput.Items.Add("***********");
            }
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{selectedBirdWatcher.GetBirdCountByName(cmbBirdToCount.Text)} {cmbBirdToCount.Text}s have been spotted today.");
        }

        private void btnSpecies_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();

            int maxBirds = 0;
            string maxBirdsSpotter = "";

            for (int i = 0; i < NrOfBirdWatchers; i++)
            {
                int uniqueBirds = birdWatchers[i].GetUniqueSpecies();
                if (uniqueBirds > maxBirds)
                {
                    maxBirds = uniqueBirds;
                    maxBirdsSpotter = birdWatchers[i].GetName() + " is the winner!";
                }
                else if (uniqueBirds == maxBirds)
                {
                    maxBirdsSpotter = "It's a tie!";
                }
                lbOutput.Items.Add($"{birdWatchers[i].GetName()} has spotted {uniqueBirds} unique species.");
            }
            lbOutput.Items.Add("");
            lbOutput.Items.Add(maxBirdsSpotter);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birdWatchers[0] = new BirdWatcher("Stijn", 2, 10);
            birdWatchers[1] = new BirdWatcher("Petya", 4, 10);
            birdWatchers[2] = new BirdWatcher("Boyan", 1, 10);
            rbnWatcher1.Text = birdWatchers[0].GetName();
            rbnWatcher2.Text = birdWatchers[1].GetName();
            rbnWatcher3.Text = birdWatchers[2].GetName();
        }

        private void rbnWatcher1_CheckedChanged(object sender, EventArgs e)
        {
            selectedBirdWatcher = birdWatchers[0];
        }

        private void rbnWatcher2_CheckedChanged(object sender, EventArgs e)
        {
            selectedBirdWatcher = birdWatchers[1];
        }

        private void rbnWatcher3_CheckedChanged(object sender, EventArgs e)
        {
            selectedBirdWatcher = birdWatchers[2];
        }
    }
}
