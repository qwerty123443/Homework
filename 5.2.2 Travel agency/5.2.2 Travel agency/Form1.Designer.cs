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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDestinations
            // 
            this.lstDestinations.FormattingEnabled = true;
            this.lstDestinations.ItemHeight = 16;
            this.lstDestinations.Location = new System.Drawing.Point(205, 12);
            this.lstDestinations.Name = "lstDestinations";
            this.lstDestinations.Size = new System.Drawing.Size(120, 84);
            this.lstDestinations.TabIndex = 0;
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(13, 13);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(100, 22);
            this.tbDestination.TabIndex = 1;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(13, 42);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 22);
            this.tbPrice.TabIndex = 2;
            // 
            // lblDestTxt
            // 
            this.lblDestTxt.AutoSize = true;
            this.lblDestTxt.Location = new System.Drawing.Point(120, 17);
            this.lblDestTxt.Name = "lblDestTxt";
            this.lblDestTxt.Size = new System.Drawing.Size(79, 17);
            this.lblDestTxt.TabIndex = 3;
            this.lblDestTxt.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add destination";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDestTxt);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.lstDestinations);
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
        private System.Windows.Forms.Button button1;
    }
}

