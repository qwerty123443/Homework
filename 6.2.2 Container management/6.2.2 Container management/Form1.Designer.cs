namespace _6._2._2_Container_management
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.tbContainerWeight = new System.Windows.Forms.TextBox();
            this.tbContainerContent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateShip = new System.Windows.Forms.Button();
            this.tbShipMaxWeight = new System.Windows.Forms.TextBox();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.lbContainers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddContainer);
            this.groupBox1.Controls.Add(this.tbContainerWeight);
            this.groupBox1.Controls.Add(this.tbContainerContent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add container";
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(7, 71);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(75, 23);
            this.btnAddContainer.TabIndex = 2;
            this.btnAddContainer.Text = "Add";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // tbContainerWeight
            // 
            this.tbContainerWeight.Location = new System.Drawing.Point(7, 47);
            this.tbContainerWeight.Name = "tbContainerWeight";
            this.tbContainerWeight.Size = new System.Drawing.Size(100, 20);
            this.tbContainerWeight.TabIndex = 1;
            // 
            // tbContainerContent
            // 
            this.tbContainerContent.Location = new System.Drawing.Point(7, 20);
            this.tbContainerContent.Name = "tbContainerContent";
            this.tbContainerContent.Size = new System.Drawing.Size(100, 20);
            this.tbContainerContent.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateShip);
            this.groupBox2.Controls.Add(this.tbShipMaxWeight);
            this.groupBox2.Controls.Add(this.tbShipName);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ship";
            // 
            // btnCreateShip
            // 
            this.btnCreateShip.Location = new System.Drawing.Point(7, 71);
            this.btnCreateShip.Name = "btnCreateShip";
            this.btnCreateShip.Size = new System.Drawing.Size(75, 23);
            this.btnCreateShip.TabIndex = 2;
            this.btnCreateShip.Text = "Create ship";
            this.btnCreateShip.UseVisualStyleBackColor = true;
            this.btnCreateShip.Click += new System.EventHandler(this.btnCreateShip_Click);
            // 
            // tbShipMaxWeight
            // 
            this.tbShipMaxWeight.Location = new System.Drawing.Point(7, 47);
            this.tbShipMaxWeight.Name = "tbShipMaxWeight";
            this.tbShipMaxWeight.Size = new System.Drawing.Size(100, 20);
            this.tbShipMaxWeight.TabIndex = 1;
            // 
            // tbShipName
            // 
            this.tbShipName.Location = new System.Drawing.Point(7, 20);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(100, 20);
            this.tbShipName.TabIndex = 0;
            // 
            // lbContainers
            // 
            this.lbContainers.FormattingEnabled = true;
            this.lbContainers.Location = new System.Drawing.Point(424, 17);
            this.lbContainers.Name = "lbContainers";
            this.lbContainers.Size = new System.Drawing.Size(193, 147);
            this.lbContainers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(12, 119);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(406, 23);
            this.btnCalculateTotal.TabIndex = 4;
            this.btnCalculateTotal.Text = "Calculate nr of containers for this ship";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 187);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbContainers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.TextBox tbContainerWeight;
        private System.Windows.Forms.TextBox tbContainerContent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateShip;
        private System.Windows.Forms.TextBox tbShipMaxWeight;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.ListBox lbContainers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateTotal;
    }
}

