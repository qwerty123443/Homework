namespace _6._2._1_Dice_game
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
            this.btnPlayOnce = new System.Windows.Forms.Button();
            this.btnPlayX = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlayOnce
            // 
            this.btnPlayOnce.Location = new System.Drawing.Point(13, 13);
            this.btnPlayOnce.Name = "btnPlayOnce";
            this.btnPlayOnce.Size = new System.Drawing.Size(75, 23);
            this.btnPlayOnce.TabIndex = 0;
            this.btnPlayOnce.Text = "Run once";
            this.btnPlayOnce.UseVisualStyleBackColor = true;
            this.btnPlayOnce.Click += new System.EventHandler(this.btnPlayOnce_Click);
            // 
            // btnPlayX
            // 
            this.btnPlayX.Location = new System.Drawing.Point(13, 42);
            this.btnPlayX.Name = "btnPlayX";
            this.btnPlayX.Size = new System.Drawing.Size(75, 23);
            this.btnPlayX.TabIndex = 1;
            this.btnPlayX.Text = "Run X times";
            this.btnPlayX.UseVisualStyleBackColor = true;
            this.btnPlayX.Click += new System.EventHandler(this.btnPlayX_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 80);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPlayX);
            this.Controls.Add(this.btnPlayOnce);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayOnce;
        private System.Windows.Forms.Button btnPlayX;
        private System.Windows.Forms.TextBox textBox1;
    }
}

