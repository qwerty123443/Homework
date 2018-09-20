using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2._1_Snackbar
{
    public partial class Form1 : Form
    {
        private Snack snack1 = new Snack(11.5, false, "frikandel", 25, 5);
        private Snack snack2 = new Snack(1.23, false, "burger", 48, 7);
        private Snack snack3 = new Snack(1, true, "vegetarische burger", 66, 12);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lblSnack1.Text = snack1.GetInfo();
            lblSnack2.Text = snack2.GetInfo();
            lblSnack3.Text = snack3.GetInfo();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                snack1.SellSome(Convert.ToInt32(tbSnack1.Text));
                snack2.SellSome(Convert.ToInt32(tbSnack2.Text));
                snack3.SellSome(Convert.ToInt32(tbSnack3.Text));
                lblSnack1.Text = snack1.GetInfo();
                lblSnack2.Text = snack2.GetInfo();
                lblSnack3.Text = snack3.GetInfo();
                lblTotal.Text = "Total: €" + Convert.ToString(
                      snack1.GetSellingPrice() * Convert.ToDouble(tbSnack1.Text)
                    + snack2.GetSellingPrice() * Convert.ToDouble(tbSnack2.Text)
                    + snack3.GetSellingPrice() * Convert.ToDouble(tbSnack3.Text)
                    );
            }
            catch
            {
                MessageBox.Show("Please enter something in every textbox");
            }
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            if (rbSnack1.Checked)
                snack1.ChangePrice(Convert.ToInt32(tbChangeAmount.Text));
            if (rbSnack2.Checked)
                snack2.ChangePrice(Convert.ToInt32(tbChangeAmount.Text));
            if (rbSnack3.Checked)
                snack3.ChangePrice(Convert.ToInt32(tbChangeAmount.Text));

        }
    }
}
