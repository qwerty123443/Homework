namespace _3._2._3_Image_animation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbHero = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHero
            // 
            this.pbHero.Image = ((System.Drawing.Image)(resources.GetObject("pbHero.Image")));
            this.pbHero.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbHero.InitialImage")));
            this.pbHero.Location = new System.Drawing.Point(13, 13);
            this.pbHero.Name = "pbHero";
            this.pbHero.Size = new System.Drawing.Size(100, 100);
            this.pbHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHero.TabIndex = 0;
            this.pbHero.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(85, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Start the show";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpeed.LargeChange = 100;
            this.tbSpeed.Location = new System.Drawing.Point(13, 393);
            this.tbSpeed.Maximum = 1000;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(775, 45);
            this.tbSpeed.SmallChange = 10;
            this.tbSpeed.TabIndex = 10;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pbHero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHero;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbSpeed;
    }
}

