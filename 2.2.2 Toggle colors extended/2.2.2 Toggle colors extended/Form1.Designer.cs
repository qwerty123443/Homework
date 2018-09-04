namespace _2._2._2_Toggle_colors_extended
{
    partial class fmColor
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
            this.btColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btColor
            // 
            this.btColor.AutoSize = true;
            this.btColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btColor.Location = new System.Drawing.Point(0, 0);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(326, 23);
            this.btColor.TabIndex = 0;
            this.btColor.Text = "Change color";
            this.btColor.UseVisualStyleBackColor = true;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // fmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(326, 166);
            this.Controls.Add(this.btColor);
            this.Name = "fmColor";
            this.Text = "Change colors (extended)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btColor;
    }
}

