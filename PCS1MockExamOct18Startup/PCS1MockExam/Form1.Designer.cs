namespace PCS1MockExam
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
            this.gbSpotted = new System.Windows.Forms.GroupBox();
            this.btnSpotBird = new System.Windows.Forms.Button();
            this.cmbSpottedBird = new System.Windows.Forms.ComboBox();
            this.rbnWatcher1 = new System.Windows.Forms.RadioButton();
            this.rbnWatcher2 = new System.Windows.Forms.RadioButton();
            this.rbnWatcher3 = new System.Windows.Forms.RadioButton();
            this.gbSelectBirdwatcher = new System.Windows.Forms.GroupBox();
            this.gbShowInfo = new System.Windows.Forms.GroupBox();
            this.lblSeenToday = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lblLastBirdSeen = new System.Windows.Forms.Label();
            this.lblWatcherInfo = new System.Windows.Forms.Label();
            this.gbRandom = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.btnSpecies = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.cmbBirdToCount = new System.Windows.Forms.ComboBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnShowAllBirds = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.gbSpotted.SuspendLayout();
            this.gbSelectBirdwatcher.SuspendLayout();
            this.gbShowInfo.SuspendLayout();
            this.gbRandom.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSpotted
            // 
            this.gbSpotted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbSpotted.Controls.Add(this.btnSpotBird);
            this.gbSpotted.Controls.Add(this.cmbSpottedBird);
            this.gbSpotted.Location = new System.Drawing.Point(12, 88);
            this.gbSpotted.Name = "gbSpotted";
            this.gbSpotted.Size = new System.Drawing.Size(250, 70);
            this.gbSpotted.TabIndex = 0;
            this.gbSpotted.TabStop = false;
            this.gbSpotted.Text = "Spotted a bird!";
            // 
            // btnSpotBird
            // 
            this.btnSpotBird.Location = new System.Drawing.Point(169, 26);
            this.btnSpotBird.Name = "btnSpotBird";
            this.btnSpotBird.Size = new System.Drawing.Size(75, 23);
            this.btnSpotBird.TabIndex = 4;
            this.btnSpotBird.Text = "spotted";
            this.btnSpotBird.UseVisualStyleBackColor = true;
            this.btnSpotBird.Click += new System.EventHandler(this.btnSpotBird_Click);
            // 
            // cmbSpottedBird
            // 
            this.cmbSpottedBird.FormattingEnabled = true;
            this.cmbSpottedBird.Items.AddRange(new object[] {
            "duck",
            "eagle",
            "gull",
            "pigeon",
            "raven",
            "sparrow"});
            this.cmbSpottedBird.Location = new System.Drawing.Point(6, 28);
            this.cmbSpottedBird.Name = "cmbSpottedBird";
            this.cmbSpottedBird.Size = new System.Drawing.Size(121, 21);
            this.cmbSpottedBird.TabIndex = 3;
            // 
            // rbnWatcher1
            // 
            this.rbnWatcher1.AutoSize = true;
            this.rbnWatcher1.Location = new System.Drawing.Point(6, 32);
            this.rbnWatcher1.Name = "rbnWatcher1";
            this.rbnWatcher1.Size = new System.Drawing.Size(69, 17);
            this.rbnWatcher1.TabIndex = 0;
            this.rbnWatcher1.TabStop = true;
            this.rbnWatcher1.Text = "watcher1";
            this.rbnWatcher1.UseVisualStyleBackColor = true;
            this.rbnWatcher1.CheckedChanged += new System.EventHandler(this.rbnWatcher1_CheckedChanged);
            // 
            // rbnWatcher2
            // 
            this.rbnWatcher2.AutoSize = true;
            this.rbnWatcher2.Location = new System.Drawing.Point(81, 32);
            this.rbnWatcher2.Name = "rbnWatcher2";
            this.rbnWatcher2.Size = new System.Drawing.Size(69, 17);
            this.rbnWatcher2.TabIndex = 1;
            this.rbnWatcher2.TabStop = true;
            this.rbnWatcher2.Text = "watcher2";
            this.rbnWatcher2.UseVisualStyleBackColor = true;
            this.rbnWatcher2.CheckedChanged += new System.EventHandler(this.rbnWatcher2_CheckedChanged);
            // 
            // rbnWatcher3
            // 
            this.rbnWatcher3.AutoSize = true;
            this.rbnWatcher3.Location = new System.Drawing.Point(156, 32);
            this.rbnWatcher3.Name = "rbnWatcher3";
            this.rbnWatcher3.Size = new System.Drawing.Size(69, 17);
            this.rbnWatcher3.TabIndex = 2;
            this.rbnWatcher3.TabStop = true;
            this.rbnWatcher3.Text = "watcher3";
            this.rbnWatcher3.UseVisualStyleBackColor = true;
            this.rbnWatcher3.CheckedChanged += new System.EventHandler(this.rbnWatcher3_CheckedChanged);
            // 
            // gbSelectBirdwatcher
            // 
            this.gbSelectBirdwatcher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbSelectBirdwatcher.Controls.Add(this.rbnWatcher2);
            this.gbSelectBirdwatcher.Controls.Add(this.rbnWatcher1);
            this.gbSelectBirdwatcher.Controls.Add(this.rbnWatcher3);
            this.gbSelectBirdwatcher.Location = new System.Drawing.Point(12, 12);
            this.gbSelectBirdwatcher.Name = "gbSelectBirdwatcher";
            this.gbSelectBirdwatcher.Size = new System.Drawing.Size(250, 70);
            this.gbSelectBirdwatcher.TabIndex = 1;
            this.gbSelectBirdwatcher.TabStop = false;
            this.gbSelectBirdwatcher.Text = "Select birdwatcher";
            // 
            // gbShowInfo
            // 
            this.gbShowInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbShowInfo.Controls.Add(this.lblSeenToday);
            this.gbShowInfo.Controls.Add(this.btnShowInfo);
            this.gbShowInfo.Controls.Add(this.lblLastBirdSeen);
            this.gbShowInfo.Controls.Add(this.lblWatcherInfo);
            this.gbShowInfo.Location = new System.Drawing.Point(12, 164);
            this.gbShowInfo.Name = "gbShowInfo";
            this.gbShowInfo.Size = new System.Drawing.Size(250, 120);
            this.gbShowInfo.TabIndex = 2;
            this.gbShowInfo.TabStop = false;
            this.gbShowInfo.Text = "Show information";
            // 
            // lblSeenToday
            // 
            this.lblSeenToday.AutoSize = true;
            this.lblSeenToday.Location = new System.Drawing.Point(6, 45);
            this.lblSeenToday.Name = "lblSeenToday";
            this.lblSeenToday.Size = new System.Drawing.Size(136, 13);
            this.lblSeenToday.TabIndex = 6;
            this.lblSeenToday.Text = "Number of birds seen today";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(169, 91);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfo.TabIndex = 5;
            this.btnShowInfo.Text = "show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lblLastBirdSeen
            // 
            this.lblLastBirdSeen.AutoSize = true;
            this.lblLastBirdSeen.Location = new System.Drawing.Point(6, 65);
            this.lblLastBirdSeen.Name = "lblLastBirdSeen";
            this.lblLastBirdSeen.Size = new System.Drawing.Size(165, 13);
            this.lblLastBirdSeen.TabIndex = 1;
            this.lblLastBirdSeen.Text = "Last bird this watcher has spotted";
            // 
            // lblWatcherInfo
            // 
            this.lblWatcherInfo.AutoSize = true;
            this.lblWatcherInfo.Location = new System.Drawing.Point(6, 25);
            this.lblWatcherInfo.Name = "lblWatcherInfo";
            this.lblWatcherInfo.Size = new System.Drawing.Size(165, 13);
            this.lblWatcherInfo.TabIndex = 0;
            this.lblWatcherInfo.Text = "Information about the birdwatcher";
            // 
            // gbRandom
            // 
            this.gbRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbRandom.Controls.Add(this.btnRandom);
            this.gbRandom.Controls.Add(this.label1);
            this.gbRandom.Location = new System.Drawing.Point(12, 290);
            this.gbRandom.Name = "gbRandom";
            this.gbRandom.Size = new System.Drawing.Size(250, 70);
            this.gbRandom.TabIndex = 3;
            this.gbRandom.TabStop = false;
            this.gbRandom.Text = "Fill random list";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(169, 41);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "random list";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Too lazy for birdwatching";
            // 
            // gbOutput
            // 
            this.gbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbOutput.Controls.Add(this.btnSpecies);
            this.gbOutput.Controls.Add(this.btnCount);
            this.gbOutput.Controls.Add(this.cmbBirdToCount);
            this.gbOutput.Controls.Add(this.btnTotal);
            this.gbOutput.Controls.Add(this.btnShowAllBirds);
            this.gbOutput.Controls.Add(this.lbOutput);
            this.gbOutput.Location = new System.Drawing.Point(269, 13);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(250, 347);
            this.gbOutput.TabIndex = 4;
            this.gbOutput.TabStop = false;
            // 
            // btnSpecies
            // 
            this.btnSpecies.Location = new System.Drawing.Point(168, 291);
            this.btnSpecies.Name = "btnSpecies";
            this.btnSpecies.Size = new System.Drawing.Size(75, 23);
            this.btnSpecies.TabIndex = 7;
            this.btnSpecies.Text = "Species";
            this.btnSpecies.UseVisualStyleBackColor = true;
            this.btnSpecies.Click += new System.EventHandler(this.btnSpecies_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(168, 318);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // cmbBirdToCount
            // 
            this.cmbBirdToCount.FormattingEnabled = true;
            this.cmbBirdToCount.Items.AddRange(new object[] {
            "duck",
            "eagle",
            "gull",
            "pigeon",
            "raven",
            "sparrow"});
            this.cmbBirdToCount.Location = new System.Drawing.Point(41, 320);
            this.cmbBirdToCount.Name = "cmbBirdToCount";
            this.cmbBirdToCount.Size = new System.Drawing.Size(121, 21);
            this.cmbBirdToCount.TabIndex = 5;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(7, 291);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Total birds";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnShowAllBirds
            // 
            this.btnShowAllBirds.Location = new System.Drawing.Point(87, 291);
            this.btnShowAllBirds.Name = "btnShowAllBirds";
            this.btnShowAllBirds.Size = new System.Drawing.Size(75, 23);
            this.btnShowAllBirds.TabIndex = 1;
            this.btnShowAllBirds.Text = "All birds";
            this.btnShowAllBirds.UseVisualStyleBackColor = true;
            this.btnShowAllBirds.Click += new System.EventHandler(this.btnShowAllBirds_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(7, 20);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(237, 264);
            this.lbOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 374);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbRandom);
            this.Controls.Add(this.gbShowInfo);
            this.Controls.Add(this.gbSelectBirdwatcher);
            this.Controls.Add(this.gbSpotted);
            this.Name = "Form1";
            this.Text = "Birdwatching by Stijn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSpotted.ResumeLayout(false);
            this.gbSelectBirdwatcher.ResumeLayout(false);
            this.gbSelectBirdwatcher.PerformLayout();
            this.gbShowInfo.ResumeLayout(false);
            this.gbShowInfo.PerformLayout();
            this.gbRandom.ResumeLayout(false);
            this.gbRandom.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSpotted;
        private System.Windows.Forms.Button btnSpotBird;
        private System.Windows.Forms.ComboBox cmbSpottedBird;
        private System.Windows.Forms.RadioButton rbnWatcher1;
        private System.Windows.Forms.RadioButton rbnWatcher2;
        private System.Windows.Forms.RadioButton rbnWatcher3;
        private System.Windows.Forms.GroupBox gbSelectBirdwatcher;
        private System.Windows.Forms.GroupBox gbShowInfo;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label lblLastBirdSeen;
        private System.Windows.Forms.Label lblWatcherInfo;
        private System.Windows.Forms.Label lblSeenToday;
        private System.Windows.Forms.GroupBox gbRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Button btnShowAllBirds;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ComboBox cmbBirdToCount;
        private System.Windows.Forms.Button btnSpecies;
    }
}

