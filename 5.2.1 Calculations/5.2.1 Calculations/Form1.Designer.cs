namespace _5._2._1_Calculations
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnProblem1 = new System.Windows.Forms.Button();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.btnProlblem3 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(13, 13);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 0;
            this.tbNumber.Text = "0";
            // 
            // btnProblem1
            // 
            this.btnProblem1.Location = new System.Drawing.Point(120, 13);
            this.btnProblem1.Name = "btnProblem1";
            this.btnProblem1.Size = new System.Drawing.Size(75, 23);
            this.btnProblem1.TabIndex = 1;
            this.btnProblem1.Text = "Problem 1";
            this.btnProblem1.UseVisualStyleBackColor = true;
            this.btnProblem1.Click += new System.EventHandler(this.btnProblem1_Click);
            // 
            // btnProblem2
            // 
            this.btnProblem2.Location = new System.Drawing.Point(120, 43);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(75, 23);
            this.btnProblem2.TabIndex = 2;
            this.btnProblem2.Text = "Problem 2";
            this.btnProblem2.UseVisualStyleBackColor = true;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // btnProlblem3
            // 
            this.btnProlblem3.Location = new System.Drawing.Point(120, 73);
            this.btnProlblem3.Name = "btnProlblem3";
            this.btnProlblem3.Size = new System.Drawing.Size(75, 23);
            this.btnProlblem3.TabIndex = 3;
            this.btnProlblem3.Text = "Problem 3";
            this.btnProlblem3.UseVisualStyleBackColor = true;
            this.btnProlblem3.Click += new System.EventHandler(this.btnProlblem3_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 40);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(201, 12);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(198, 82);
            this.lbResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 107);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnProlblem3);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.btnProblem1);
            this.Controls.Add(this.tbNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnProblem1;
        private System.Windows.Forms.Button btnProblem2;
        private System.Windows.Forms.Button btnProlblem3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lbResult;
    }
}

