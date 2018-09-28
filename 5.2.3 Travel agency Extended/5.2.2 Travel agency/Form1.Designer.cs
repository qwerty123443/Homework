namespace _5._2._2_Travel_agency
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
            this.lstDestinations = new System.Windows.Forms.ListBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblDestTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.btnBookDestination = new System.Windows.Forms.Button();
            this.tbSeason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDestinations
            // 
            this.lstDestinations.FormattingEnabled = true;
            this.lstDestinations.Location = new System.Drawing.Point(154, 10);
            this.lstDestinations.Margin = new System.Windows.Forms.Padding(2);
            this.lstDestinations.Name = "lstDestinations";
            this.lstDestinations.Size = new System.Drawing.Size(178, 69);
            this.lstDestinations.TabIndex = 0;
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(10, 11);
            this.tbDestination.Margin = new System.Windows.Forms.Padding(2);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(76, 20);
            this.tbDestination.TabIndex = 1;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(10, 35);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(76, 20);
            this.tbPrice.TabIndex = 2;
            // 
            // lblDestTxt
            // 
            this.lblDestTxt.AutoSize = true;
            this.lblDestTxt.Location = new System.Drawing.Point(90, 14);
            this.lblDestTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestTxt.Name = "lblDestTxt";
            this.lblDestTxt.Size = new System.Drawing.Size(60, 13);
            this.lblDestTxt.TabIndex = 3;
            this.lblDestTxt.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(10, 122);
            this.btnAddDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(75, 20);
            this.btnAddDestination.TabIndex = 5;
            this.btnAddDestination.Text = "Add destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(337, 10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbProfit
            // 
            this.tbProfit.Location = new System.Drawing.Point(10, 59);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.Size = new System.Drawing.Size(75, 20);
            this.tbProfit.TabIndex = 7;
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(92, 65);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(31, 13);
            this.lblProfit.TabIndex = 8;
            this.lblProfit.Text = "Profit";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Location = new System.Drawing.Point(151, 88);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(76, 13);
            this.lblTotalProfit.TabIndex = 9;
            this.lblTotalProfit.Text = "Total Profit: €0";
            // 
            // btnBookDestination
            // 
            this.btnBookDestination.Location = new System.Drawing.Point(338, 37);
            this.btnBookDestination.Name = "btnBookDestination";
            this.btnBookDestination.Size = new System.Drawing.Size(75, 23);
            this.btnBookDestination.TabIndex = 10;
            this.btnBookDestination.Text = "Book";
            this.btnBookDestination.UseVisualStyleBackColor = true;
            this.btnBookDestination.Click += new System.EventHandler(this.btnBookDestination_Click);
            // 
            // tbSeason
            // 
            this.tbSeason.Location = new System.Drawing.Point(338, 64);
            this.tbSeason.Name = "tbSeason";
            this.tbSeason.Size = new System.Drawing.Size(75, 20);
            this.tbSeason.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Season (1..4)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSeason);
            this.Controls.Add(this.btnBookDestination);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.tbProfit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDestTxt);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.lstDestinations);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDestinations;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblDestTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Button btnBookDestination;
        private System.Windows.Forms.TextBox tbSeason;
        private System.Windows.Forms.Label label1;
    }
}

