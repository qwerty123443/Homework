namespace BowlingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbStartMatch = new System.Windows.Forms.GroupBox();
            this.tbNrRounds = new System.Windows.Forms.TextBox();
            this.lblNrRounds = new System.Windows.Forms.Label();
            this.rbnComputer = new System.Windows.Forms.RadioButton();
            this.rbnHuman = new System.Windows.Forms.RadioButton();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.tbPlayer2PB = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.tbPlayer2Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tbPlayer1PB = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.tbPlayer1Name = new System.Windows.Forms.TextBox();
            this.gbAddScore = new System.Windows.Forms.GroupBox();
            this.btnInputScores = new System.Windows.Forms.Button();
            this.lblRoundTitle = new System.Windows.Forms.Label();
            this.cmbScorePlayer2 = new System.Windows.Forms.ComboBox();
            this.cmbScorePlayer1 = new System.Windows.Forms.ComboBox();
            this.lblScoreP2Name = new System.Windows.Forms.Label();
            this.lblScoreP1Name = new System.Windows.Forms.Label();
            this.lblRoundNr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBonus = new System.Windows.Forms.Button();
            this.btnShowRounds = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.gbPrediction = new System.Windows.Forms.GroupBox();
            this.lblPredictionWinner = new System.Windows.Forms.Label();
            this.lblPredictionPlayers = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.gbStartMatch.SuspendLayout();
            this.gbAddScore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPrediction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStartMatch
            // 
            this.gbStartMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbStartMatch.Controls.Add(this.tbNrRounds);
            this.gbStartMatch.Controls.Add(this.lblNrRounds);
            this.gbStartMatch.Controls.Add(this.rbnComputer);
            this.gbStartMatch.Controls.Add(this.rbnHuman);
            this.gbStartMatch.Controls.Add(this.lblVS);
            this.gbStartMatch.Controls.Add(this.btnStartMatch);
            this.gbStartMatch.Controls.Add(this.tbPlayer2PB);
            this.gbStartMatch.Controls.Add(this.lblPlayer2);
            this.gbStartMatch.Controls.Add(this.tbPlayer2Name);
            this.gbStartMatch.Controls.Add(this.label1);
            this.gbStartMatch.Controls.Add(this.lblPlayerName);
            this.gbStartMatch.Controls.Add(this.tbPlayer1PB);
            this.gbStartMatch.Controls.Add(this.lblPlayer1);
            this.gbStartMatch.Controls.Add(this.tbPlayer1Name);
            this.gbStartMatch.Location = new System.Drawing.Point(13, 13);
            this.gbStartMatch.Name = "gbStartMatch";
            this.gbStartMatch.Size = new System.Drawing.Size(300, 180);
            this.gbStartMatch.TabIndex = 0;
            this.gbStartMatch.TabStop = false;
            this.gbStartMatch.Text = "Start new match";
            // 
            // tbNrRounds
            // 
            this.tbNrRounds.Location = new System.Drawing.Point(100, 142);
            this.tbNrRounds.Name = "tbNrRounds";
            this.tbNrRounds.Size = new System.Drawing.Size(40, 20);
            this.tbNrRounds.TabIndex = 23;
            // 
            // lblNrRounds
            // 
            this.lblNrRounds.AutoSize = true;
            this.lblNrRounds.Location = new System.Drawing.Point(6, 145);
            this.lblNrRounds.Name = "lblNrRounds";
            this.lblNrRounds.Size = new System.Drawing.Size(94, 13);
            this.lblNrRounds.TabIndex = 22;
            this.lblNrRounds.Text = "Number of rounds:";
            // 
            // rbnComputer
            // 
            this.rbnComputer.AutoSize = true;
            this.rbnComputer.Location = new System.Drawing.Point(151, 78);
            this.rbnComputer.Name = "rbnComputer";
            this.rbnComputer.Size = new System.Drawing.Size(69, 17);
            this.rbnComputer.TabIndex = 21;
            this.rbnComputer.Text = "computer";
            this.rbnComputer.UseVisualStyleBackColor = true;
            this.rbnComputer.CheckedChanged += new System.EventHandler(this.rbnComputer_CheckedChanged);
            // 
            // rbnHuman
            // 
            this.rbnHuman.AutoSize = true;
            this.rbnHuman.Checked = true;
            this.rbnHuman.Location = new System.Drawing.Point(60, 78);
            this.rbnHuman.Name = "rbnHuman";
            this.rbnHuman.Size = new System.Drawing.Size(57, 17);
            this.rbnHuman.TabIndex = 20;
            this.rbnHuman.TabStop = true;
            this.rbnHuman.Text = "human";
            this.rbnHuman.UseVisualStyleBackColor = true;
            this.rbnHuman.CheckedChanged += new System.EventHandler(this.rbnHuman_CheckedChanged);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(22, 80);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(21, 13);
            this.lblVS.TabIndex = 19;
            this.lblVS.Text = "VS";
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.Location = new System.Drawing.Point(214, 149);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(80, 25);
            this.btnStartMatch.TabIndex = 18;
            this.btnStartMatch.Text = "Start match";
            this.btnStartMatch.UseVisualStyleBackColor = true;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
            // 
            // tbPlayer2PB
            // 
            this.tbPlayer2PB.Location = new System.Drawing.Point(146, 106);
            this.tbPlayer2PB.Name = "tbPlayer2PB";
            this.tbPlayer2PB.Size = new System.Drawing.Size(40, 20);
            this.tbPlayer2PB.TabIndex = 8;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(6, 109);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer2.TabIndex = 7;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // tbPlayer2Name
            // 
            this.tbPlayer2Name.Location = new System.Drawing.Point(60, 106);
            this.tbPlayer2Name.Name = "tbPlayer2Name";
            this.tbPlayer2Name.Size = new System.Drawing.Size(80, 20);
            this.tbPlayer2Name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personal best:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(57, 29);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(38, 13);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Name:";
            // 
            // tbPlayer1PB
            // 
            this.tbPlayer1PB.Location = new System.Drawing.Point(146, 45);
            this.tbPlayer1PB.Name = "tbPlayer1PB";
            this.tbPlayer1PB.Size = new System.Drawing.Size(40, 20);
            this.tbPlayer1PB.TabIndex = 2;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(6, 48);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player 1:";
            // 
            // tbPlayer1Name
            // 
            this.tbPlayer1Name.Location = new System.Drawing.Point(60, 45);
            this.tbPlayer1Name.Name = "tbPlayer1Name";
            this.tbPlayer1Name.Size = new System.Drawing.Size(80, 20);
            this.tbPlayer1Name.TabIndex = 0;
            // 
            // gbAddScore
            // 
            this.gbAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbAddScore.Controls.Add(this.btnInputScores);
            this.gbAddScore.Controls.Add(this.lblRoundTitle);
            this.gbAddScore.Controls.Add(this.cmbScorePlayer2);
            this.gbAddScore.Controls.Add(this.cmbScorePlayer1);
            this.gbAddScore.Controls.Add(this.lblScoreP2Name);
            this.gbAddScore.Controls.Add(this.lblScoreP1Name);
            this.gbAddScore.Controls.Add(this.lblRoundNr);
            this.gbAddScore.Location = new System.Drawing.Point(14, 305);
            this.gbAddScore.Name = "gbAddScore";
            this.gbAddScore.Size = new System.Drawing.Size(300, 95);
            this.gbAddScore.TabIndex = 1;
            this.gbAddScore.TabStop = false;
            this.gbAddScore.Text = "Add scores";
            // 
            // btnInputScores
            // 
            this.btnInputScores.Location = new System.Drawing.Point(214, 61);
            this.btnInputScores.Name = "btnInputScores";
            this.btnInputScores.Size = new System.Drawing.Size(80, 25);
            this.btnInputScores.TabIndex = 19;
            this.btnInputScores.Text = "Input scores";
            this.btnInputScores.UseVisualStyleBackColor = true;
            this.btnInputScores.Click += new System.EventHandler(this.btnInputScores_Click);
            // 
            // lblRoundTitle
            // 
            this.lblRoundTitle.AutoSize = true;
            this.lblRoundTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundTitle.Location = new System.Drawing.Point(6, 16);
            this.lblRoundTitle.Name = "lblRoundTitle";
            this.lblRoundTitle.Size = new System.Drawing.Size(57, 16);
            this.lblRoundTitle.TabIndex = 28;
            this.lblRoundTitle.Text = "Round:";
            // 
            // cmbScorePlayer2
            // 
            this.cmbScorePlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScorePlayer2.FormattingEnabled = true;
            this.cmbScorePlayer2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbScorePlayer2.Location = new System.Drawing.Point(146, 64);
            this.cmbScorePlayer2.Name = "cmbScorePlayer2";
            this.cmbScorePlayer2.Size = new System.Drawing.Size(40, 21);
            this.cmbScorePlayer2.TabIndex = 25;
            // 
            // cmbScorePlayer1
            // 
            this.cmbScorePlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScorePlayer1.FormattingEnabled = true;
            this.cmbScorePlayer1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbScorePlayer1.Location = new System.Drawing.Point(146, 38);
            this.cmbScorePlayer1.Name = "cmbScorePlayer1";
            this.cmbScorePlayer1.Size = new System.Drawing.Size(40, 21);
            this.cmbScorePlayer1.TabIndex = 24;
            // 
            // lblScoreP2Name
            // 
            this.lblScoreP2Name.AutoSize = true;
            this.lblScoreP2Name.Location = new System.Drawing.Point(92, 67);
            this.lblScoreP2Name.Name = "lblScoreP2Name";
            this.lblScoreP2Name.Size = new System.Drawing.Size(47, 13);
            this.lblScoreP2Name.TabIndex = 19;
            this.lblScoreP2Name.Text = "Name 2:";
            // 
            // lblScoreP1Name
            // 
            this.lblScoreP1Name.AutoSize = true;
            this.lblScoreP1Name.Location = new System.Drawing.Point(92, 41);
            this.lblScoreP1Name.Name = "lblScoreP1Name";
            this.lblScoreP1Name.Size = new System.Drawing.Size(47, 13);
            this.lblScoreP1Name.TabIndex = 17;
            this.lblScoreP1Name.Text = "Name 1:";
            // 
            // lblRoundNr
            // 
            this.lblRoundNr.AutoSize = true;
            this.lblRoundNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNr.Location = new System.Drawing.Point(6, 38);
            this.lblRoundNr.Name = "lblRoundNr";
            this.lblRoundNr.Size = new System.Drawing.Size(52, 55);
            this.lblRoundNr.TabIndex = 29;
            this.lblRoundNr.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnBonus);
            this.groupBox1.Controls.Add(this.btnShowRounds);
            this.groupBox1.Controls.Add(this.lbOutput);
            this.groupBox1.Controls.Add(this.btnShowResults);
            this.groupBox1.Location = new System.Drawing.Point(320, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 387);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnBonus
            // 
            this.btnBonus.Location = new System.Drawing.Point(177, 337);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(80, 40);
            this.btnBonus.TabIndex = 34;
            this.btnBonus.Text = "Calculate bonus total";
            this.btnBonus.UseVisualStyleBackColor = true;
            this.btnBonus.Click += new System.EventHandler(this.btnBonus_Click);
            // 
            // btnShowRounds
            // 
            this.btnShowRounds.Location = new System.Drawing.Point(6, 337);
            this.btnShowRounds.Name = "btnShowRounds";
            this.btnShowRounds.Size = new System.Drawing.Size(80, 40);
            this.btnShowRounds.TabIndex = 33;
            this.btnShowRounds.Text = "Show all rounds";
            this.btnShowRounds.UseVisualStyleBackColor = true;
            this.btnShowRounds.Click += new System.EventHandler(this.btnShowRounds_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(7, 20);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(251, 303);
            this.lbOutput.TabIndex = 32;
            // 
            // btnShowResults
            // 
            this.btnShowResults.Location = new System.Drawing.Point(91, 337);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(80, 40);
            this.btnShowResults.TabIndex = 31;
            this.btnShowResults.Text = "Show final results";
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // gbPrediction
            // 
            this.gbPrediction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbPrediction.Controls.Add(this.lblPredictionWinner);
            this.gbPrediction.Controls.Add(this.lblPredictionPlayers);
            this.gbPrediction.Controls.Add(this.btnPredict);
            this.gbPrediction.Location = new System.Drawing.Point(14, 199);
            this.gbPrediction.Name = "gbPrediction";
            this.gbPrediction.Size = new System.Drawing.Size(300, 100);
            this.gbPrediction.TabIndex = 31;
            this.gbPrediction.TabStop = false;
            this.gbPrediction.Text = "Match Prediction";
            // 
            // lblPredictionWinner
            // 
            this.lblPredictionWinner.AutoSize = true;
            this.lblPredictionWinner.Location = new System.Drawing.Point(6, 50);
            this.lblPredictionWinner.Name = "lblPredictionWinner";
            this.lblPredictionWinner.Size = new System.Drawing.Size(86, 13);
            this.lblPredictionWinner.TabIndex = 32;
            this.lblPredictionWinner.Text = "Predicted winner";
            // 
            // lblPredictionPlayers
            // 
            this.lblPredictionPlayers.AutoSize = true;
            this.lblPredictionPlayers.Location = new System.Drawing.Point(6, 27);
            this.lblPredictionPlayers.Name = "lblPredictionPlayers";
            this.lblPredictionPlayers.Size = new System.Drawing.Size(79, 13);
            this.lblPredictionPlayers.TabIndex = 31;
            this.lblPredictionPlayers.Text = "Who\'s playing?";
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(214, 69);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(80, 25);
            this.btnPredict.TabIndex = 30;
            this.btnPredict.Text = "Prediction";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.gbPrediction);
            this.Controls.Add(this.gbStartMatch);
            this.Controls.Add(this.gbAddScore);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbStartMatch.ResumeLayout(false);
            this.gbStartMatch.PerformLayout();
            this.gbAddScore.ResumeLayout(false);
            this.gbAddScore.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbPrediction.ResumeLayout(false);
            this.gbPrediction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStartMatch;
        private System.Windows.Forms.TextBox tbPlayer2PB;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox tbPlayer2Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox tbPlayer1PB;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox tbPlayer1Name;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.GroupBox gbAddScore;
        private System.Windows.Forms.ComboBox cmbScorePlayer1;
        private System.Windows.Forms.Label lblScoreP2Name;
        private System.Windows.Forms.Label lblScoreP1Name;
        private System.Windows.Forms.Button btnInputScores;
        private System.Windows.Forms.Label lblRoundTitle;
        private System.Windows.Forms.ComboBox cmbScorePlayer2;
        private System.Windows.Forms.Label lblRoundNr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.RadioButton rbnComputer;
        private System.Windows.Forms.RadioButton rbnHuman;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnShowRounds;
        private System.Windows.Forms.GroupBox gbPrediction;
        private System.Windows.Forms.Label lblPredictionWinner;
        private System.Windows.Forms.Label lblPredictionPlayers;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnBonus;
        private System.Windows.Forms.TextBox tbNrRounds;
        private System.Windows.Forms.Label lblNrRounds;
    }
}

