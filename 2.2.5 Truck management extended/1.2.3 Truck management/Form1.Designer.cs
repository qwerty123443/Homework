namespace _1._2._3_Truck_management
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbOrderAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCompanyC = new System.Windows.Forms.RadioButton();
            this.rbCompanyB = new System.Windows.Forms.RadioButton();
            this.rbCompanyA = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalc);
            this.groupBox2.Controls.Add(this.tbOrderAmount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(112, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order info";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(7, 64);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbOrderAmount
            // 
            this.tbOrderAmount.Location = new System.Drawing.Point(7, 37);
            this.tbOrderAmount.Name = "tbOrderAmount";
            this.tbOrderAmount.Size = new System.Drawing.Size(100, 20);
            this.tbOrderAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nr of boxes ordered";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCompanyC);
            this.groupBox3.Controls.Add(this.rbCompanyB);
            this.groupBox3.Controls.Add(this.rbCompanyA);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(94, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Company info";
            // 
            // rbCompanyC
            // 
            this.rbCompanyC.AutoSize = true;
            this.rbCompanyC.Location = new System.Drawing.Point(7, 68);
            this.rbCompanyC.Name = "rbCompanyC";
            this.rbCompanyC.Size = new System.Drawing.Size(79, 17);
            this.rbCompanyC.TabIndex = 2;
            this.rbCompanyC.TabStop = true;
            this.rbCompanyC.Text = "Company C";
            this.rbCompanyC.UseVisualStyleBackColor = true;
            // 
            // rbCompanyB
            // 
            this.rbCompanyB.AutoSize = true;
            this.rbCompanyB.Location = new System.Drawing.Point(7, 44);
            this.rbCompanyB.Name = "rbCompanyB";
            this.rbCompanyB.Size = new System.Drawing.Size(79, 17);
            this.rbCompanyB.TabIndex = 1;
            this.rbCompanyB.TabStop = true;
            this.rbCompanyB.Text = "Company B";
            this.rbCompanyB.UseVisualStyleBackColor = true;
            // 
            // rbCompanyA
            // 
            this.rbCompanyA.AutoSize = true;
            this.rbCompanyA.Location = new System.Drawing.Point(7, 20);
            this.rbCompanyA.Name = "rbCompanyA";
            this.rbCompanyA.Size = new System.Drawing.Size(79, 17);
            this.rbCompanyA.TabIndex = 0;
            this.rbCompanyA.TabStop = true;
            this.rbCompanyA.Text = "Company A";
            this.rbCompanyA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 126);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Truck management";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbOrderAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCompanyC;
        private System.Windows.Forms.RadioButton rbCompanyB;
        private System.Windows.Forms.RadioButton rbCompanyA;
    }
}

