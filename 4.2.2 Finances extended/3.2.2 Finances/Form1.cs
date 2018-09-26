using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2._2_Finances
{
    public partial class Form1 : Form
    { 
        private Person me = new Person("Stijn Rutjens", "a@b.c", 18, "this is the first wallet", 10, "This is the second wallet", 200);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            me.getWallet1().AddMoney(Convert.ToInt32(tbAddAmount.Text));
            lblAmountMoney.Text = "Amount of money is € " + me.getWallet1().GetMoney();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lblWalletOwner.Text = "Wallet belongs to " + me.GetName();
            lblAmountMoney.Text = "Amount of money is € " + me.getWallet1().GetMoney();
        }

        private void btnRemoveMoney_Click(object sender, EventArgs e)
        {
            me.getWallet1().RemoveMoney(Convert.ToInt32(tbRemoveAmount.Text));
            lblAmountMoney.Text = "Amount of money is € " + me.getWallet1().GetMoney();
        }

        private void btnShowInfo2_Click(object sender, EventArgs e)
        {
            lblWalletOwner2.Text = "Wallet belongs to " + me.GetName();
            lblAmountMoney2.Text = "Amount of money is € " + me.getWallet2().GetMoney();
        }

        private void btnAddMoney2_Click(object sender, EventArgs e)
        {
            me.getWallet2().AddMoney(Convert.ToInt32(tbAddAmount2.Text));
            updateInfo();
        }

        private void btnRemoveMoney2_Click(object sender, EventArgs e)
        {
            me.getWallet2().RemoveMoney(Convert.ToInt32(tbRemoveAmount2.Text));
            updateInfo();
        }

        private void btnToOtherWallet_Click(object sender, EventArgs e)
        {
            int amountToTransfer = Convert.ToInt32(tbTransferAmount.Text);
            if (amountToTransfer >= 0 && me.getWallet1().GetMoney() >= amountToTransfer)
            {
                me.getWallet1().RemoveMoney(amountToTransfer);
                me.getWallet2().AddMoney(amountToTransfer);
                updateInfo();
            }
        }

        private void btnToMyWallet_Click(object sender, EventArgs e)
        {
            int amountToTransfer = Convert.ToInt32(tbTransferAmount.Text);
            if (amountToTransfer >= 0 && me.getWallet2().GetMoney() >= amountToTransfer)
            {
                me.getWallet2().RemoveMoney(amountToTransfer);
                me.getWallet1().AddMoney(amountToTransfer);
                updateInfo();
            }
        }

        private void updateInfo()
        {
            lblAmountMoney.Text = "Amount of money is € " + me.getWallet1().GetMoney();
            lblAmountMoney2.Text = "Amount of money is € " + me.getWallet2().GetMoney();
        }
    }
}
