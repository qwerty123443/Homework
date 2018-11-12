using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingApp
{
    public partial class Form1 : Form
    {
        private Random random;
        private Player player1;
        private Player player2;

        private int roundNr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            random = new Random();
            player1 = new Player(tbPlayer1Name.Text, Convert.ToInt32(tbPlayer1PB.Text), Convert.ToInt32(tbNrRounds.Text));
            player2 = new Player(tbPlayer2Name.Text, Convert.ToInt32(tbPlayer2PB.Text), Convert.ToInt32(tbNrRounds.Text));
            lblScoreP1Name.Text = tbPlayer1Name.Text;
            lblScoreP2Name.Text = tbPlayer2Name.Text;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            lblPredictionPlayers.Text = $"{player1.GetInfo()} VS {player2.GetInfo()}";
            if (player1.GetPersonalBest() > player2.GetPersonalBest())
            {
                lblPredictionWinner.Text = $"Based on personal best, {player1.GetName()} is expected to win.";
            }
            else if (player1.GetPersonalBest() < player2.GetPersonalBest())
            {
                lblPredictionWinner.Text = $"Based on personal best, {player2.GetName()} is expected to win.";
            }
            else
            {
                lblPredictionWinner.Text = "The match could go either way";
            }
        }

        private void btnInputScores_Click(object sender, EventArgs e)
        {
            player1.AddScore(Convert.ToInt32(cmbScorePlayer1.Text));
            if (!player2.GetIsHuman()) {
                player2.AddScore(random.Next(0, 11));
            }
            else
            {
                player2.AddScore(Convert.ToInt32(cmbScorePlayer2.Text));
            }
            roundNr++;
            lblRoundNr.Text = roundNr.ToString();
            
            if (roundNr == player1.getMaxNrOfRounds())
            {
                btnInputScores.Enabled = false;
            }
        }
        private void btnShowResults_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            lbOutput.Items.Add(player1.GetInfo());
            lbOutput.Items.Add("\tVS");
            lbOutput.Items.Add(player2.GetInfo());
            lbOutput.Items.Add("");
            lbOutput.Items.Add($"Total score for {player1.GetName()}: {player1.GetTotalScore()}");
            lbOutput.Items.Add($"Total score for {player2.GetName()}: {player2.GetTotalScore()}");
            lbOutput.Items.Add("");
            if (player1.GetTotalScore() > player2.GetTotalScore())
            {
                lbOutput.Items.Add($"The winner is {player1.GetName()}!");
            }
            else if (player1.GetTotalScore() < player2.GetTotalScore())
            {
                lbOutput.Items.Add($"The winner is {player2.GetName()}!");

            }
            else
            {
                lbOutput.Items.Add($"It's a tie!");
            }
        }

        private void btnShowRounds_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            lbOutput.Items.Add("Scores for each round:");
            lbOutput.Items.Add("");

            string player1ScoreString = "";
            string player2ScoreString = "";
            for (int i = 0; i<roundNr;i++)
            {
                int score = player1.GetScores()[i];
                player1ScoreString += $"{score} ";
            }
            for (int i = 0; i < roundNr; i++)
            {
                int score = player2.GetScores()[i];
                player2ScoreString += $"{score} ";
            }

            lbOutput.Items.Add($"{player1.GetName()}: {player1ScoreString}");
            lbOutput.Items.Add("");
            lbOutput.Items.Add($"{player2.GetName()}: {player2ScoreString}");
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            bool doubleScoreNextLoop = false;
            int totalScorePlayer1 = 0;
            int totalScorePlayer2 = 0;
            string outputString;
            foreach (int score in player1.GetScores())
            {
                if (doubleScoreNextLoop)
                {
                    totalScorePlayer1 += score;
                    doubleScoreNextLoop = false;
                }
                doubleScoreNextLoop = score == 10;
                totalScorePlayer1 += score;
            }
            foreach (int score in player2.GetScores())
            {
                if (doubleScoreNextLoop)
                {
                    totalScorePlayer2 += score;
                    doubleScoreNextLoop = false;
                }
                doubleScoreNextLoop = score == 10;
                totalScorePlayer2 += score;
            }
            outputString = $"{player1.GetName()} scored {totalScorePlayer1} Points.\n" +
                $"{player2.GetName()} scored {totalScorePlayer2} Points.\n";
            if (player1.GetTotalScore() > player2.GetTotalScore())
            {
                outputString += $"The winner is {player1.GetName()}!";
            }
            else if (player1.GetTotalScore() < player2.GetTotalScore())
            {
                outputString += $"The winner is {player2.GetName()}!";

            }
            else
            {
                outputString += $"It's a tie!";
            }
            MessageBox.Show(outputString);
        }

        private void rbnComputer_CheckedChanged(object sender, EventArgs e)
        {
            cmbScorePlayer2.Enabled = false;
        }

        private void rbnHuman_CheckedChanged(object sender, EventArgs e)
        {
            cmbScorePlayer2.Enabled = true;
        }
    }
}
