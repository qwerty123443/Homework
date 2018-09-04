namespace _3._2._1_Car_simulation
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSpeedUp = new System.Windows.Forms.Button();
            this.btnSlowDown = new System.Windows.Forms.Button();
            this.btnSlowDown2 = new System.Windows.Forms.Button();
            this.btnSpeedUp2 = new System.Windows.Forms.Button();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(172, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Car info should be displayed here...";
            // 
            // btnSpeedUp
            // 
            this.btnSpeedUp.Location = new System.Drawing.Point(16, 29);
            this.btnSpeedUp.Name = "btnSpeedUp";
            this.btnSpeedUp.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedUp.TabIndex = 1;
            this.btnSpeedUp.Text = "Speed up";
            this.btnSpeedUp.UseVisualStyleBackColor = true;
            this.btnSpeedUp.Click += new System.EventHandler(this.btnSpeedUp_Click);
            // 
            // btnSlowDown
            // 
            this.btnSlowDown.Location = new System.Drawing.Point(98, 30);
            this.btnSlowDown.Name = "btnSlowDown";
            this.btnSlowDown.Size = new System.Drawing.Size(75, 23);
            this.btnSlowDown.TabIndex = 2;
            this.btnSlowDown.Text = "Slow down";
            this.btnSlowDown.UseVisualStyleBackColor = true;
            this.btnSlowDown.Click += new System.EventHandler(this.btnSlowDown_Click);
            // 
            // btnSlowDown2
            // 
            this.btnSlowDown2.Location = new System.Drawing.Point(98, 72);
            this.btnSlowDown2.Name = "btnSlowDown2";
            this.btnSlowDown2.Size = new System.Drawing.Size(75, 23);
            this.btnSlowDown2.TabIndex = 5;
            this.btnSlowDown2.Text = "Slow down";
            this.btnSlowDown2.UseVisualStyleBackColor = true;
            this.btnSlowDown2.Click += new System.EventHandler(this.btnSlowDown2_Click);
            // 
            // btnSpeedUp2
            // 
            this.btnSpeedUp2.Location = new System.Drawing.Point(16, 71);
            this.btnSpeedUp2.Name = "btnSpeedUp2";
            this.btnSpeedUp2.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedUp2.TabIndex = 4;
            this.btnSpeedUp2.Text = "Speed up";
            this.btnSpeedUp2.UseVisualStyleBackColor = true;
            this.btnSpeedUp2.Click += new System.EventHandler(this.btnSpeedUp2_Click);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(13, 55);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(172, 13);
            this.lblInfo2.TabIndex = 3;
            this.lblInfo2.Text = "Car info should be displayed here...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(209, 118);
            this.Controls.Add(this.btnSlowDown2);
            this.Controls.Add(this.btnSpeedUp2);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.btnSlowDown);
            this.Controls.Add(this.btnSpeedUp);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSpeedUp;
        private System.Windows.Forms.Button btnSlowDown;
        private System.Windows.Forms.Button btnSlowDown2;
        private System.Windows.Forms.Button btnSpeedUp2;
        private System.Windows.Forms.Label lblInfo2;
    }
}

