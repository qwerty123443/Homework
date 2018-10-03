namespace _6._2._3_Checking_primes
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
            this.tbPrime = new System.Windows.Forms.TextBox();
            this.btnCheckPrime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrime
            // 
            this.tbPrime.Location = new System.Drawing.Point(13, 13);
            this.tbPrime.Name = "tbPrime";
            this.tbPrime.Size = new System.Drawing.Size(100, 20);
            this.tbPrime.TabIndex = 0;
            // 
            // btnCheckPrime
            // 
            this.btnCheckPrime.Location = new System.Drawing.Point(120, 13);
            this.btnCheckPrime.Name = "btnCheckPrime";
            this.btnCheckPrime.Size = new System.Drawing.Size(97, 23);
            this.btnCheckPrime.TabIndex = 1;
            this.btnCheckPrime.Text = "Check primeness";
            this.btnCheckPrime.UseVisualStyleBackColor = true;
            this.btnCheckPrime.Click += new System.EventHandler(this.btnCheckPrime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckPrime);
            this.Controls.Add(this.tbPrime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrime;
        private System.Windows.Forms.Button btnCheckPrime;
    }
}

