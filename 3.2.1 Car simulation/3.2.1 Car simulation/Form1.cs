﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2._1_Car_simulation
{
    public partial class Form1 : Form
    {
        private Car myCar = new Car();
        private Car myCar2 = new Car();
        public Form1()
        {
            InitializeComponent();
            myCar.SetBrand("Ferrari");
            myCar.SetMaxSpeed(240);
            lblInfo.Text = myCar.AsAString();
            myCar2.SetBrand("Bughatti");
            myCar2.SetMaxSpeed(270);
            lblInfo2.Text = myCar2.AsAString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = myCar.AsAString();
        }
        private void btnSpeedUp_Click(object sender, EventArgs e)
        {
            myCar.SpeedUp();
            lblInfo.Text = myCar.AsAString();
        }
        private void btnSlowDown_Click(object sender, EventArgs e)
        {
            myCar.SpeedDown();
            lblInfo.Text = myCar.AsAString();
        }

        private void btnSpeedUp2_Click(object sender, EventArgs e)
        {
            myCar2.SpeedUp();
            lblInfo2.Text = myCar2.AsAString();
        }

        private void btnSlowDown2_Click(object sender, EventArgs e)
        {
            myCar2.SpeedDown();
            lblInfo2.Text = myCar2.AsAString();
        }
    }
}

