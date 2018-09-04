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
        private Wallet myWallet = new Wallet();
        private Wallet anotherWallet = new Wallet();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetOwner_Click(object sender, EventArgs e)
        {
            myWallet.SetOwnerName(tbOwnerName.Text);
            lblWalletOwner.Text = "Wallet belongs to " + myWallet.GetOwnerName();
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            myWallet.AddMoney(Convert.ToInt32(tbAddAmount.Text));
            lblAmountMoney.Text = "Amount of money is € " + myWallet.GetMoney();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lblWalletOwner.Text = "Wallet belongs to " + myWallet.GetOwnerName();
            lblAmountMoney.Text = "Amount of money is € " + myWallet.GetMoney();
        }

        private void btnRemoveMoney_Click(object sender, EventArgs e)
        {
            myWallet.RemoveMoney(Convert.ToInt32(tbRemoveAmount.Text));
            lblAmountMoney.Text = "Amount of money is € " + myWallet.GetMoney();
        }

        private void btnShowInfo2_Click(object sender, EventArgs e)
        {
            lblWalletOwner2.Text = "Wallet belongs to " + anotherWallet.GetOwnerName();
            lblAmountMoney2.Text = "Amount of money is € " + anotherWallet.GetMoney();
        }

        private void btnSetOwner2_Click(object sender, EventArgs e)
        {
            anotherWallet.SetOwnerName(tbOwnerName2.Text);
            lblWalletOwner2.Text = "Wallet belongs to " + anotherWallet.GetOwnerName();
        }

        private void btnAddMoney2_Click(object sender, EventArgs e)
        {
            anotherWallet.AddMoney(Convert.ToInt32(tbAddAmount2.Text));
            lblAmountMoney2.Text = "Amount of money is € " + anotherWallet.GetMoney();
        }

        private void btnRemoveMoney2_Click(object sender, EventArgs e)
        {
            anotherWallet.RemoveMoney(Convert.ToInt32(tbRemoveAmount2.Text));
            lblAmountMoney2.Text = "Amount of money is € " + anotherWallet.GetMoney();
        }

        private void btnToOtherWallet_Click(object sender, EventArgs e)
        {
            int amountToTransfer = Convert.ToInt32(tbTransferAmount.Text);
            if (amountToTransfer >= 0 && myWallet.GetMoney() >= amountToTransfer)
            {
                myWallet.RemoveMoney(amountToTransfer);
                anotherWallet.AddMoney(amountToTransfer);
                lblAmountMoney.Text = "Amount of money is € " + myWallet.GetMoney();
                lblAmountMoney2.Text = "Amount of money is € " + anotherWallet.GetMoney();
            }
        }

        private void btnToMyWallet_Click(object sender, EventArgs e)
        {
            int amountToTransfer = Convert.ToInt32(tbTransferAmount.Text);
            if (amountToTransfer >= 0 && anotherWallet.GetMoney() >= amountToTransfer)
            {
                anotherWallet.RemoveMoney(amountToTransfer);
                myWallet.AddMoney(amountToTransfer);
                lblAmountMoney.Text  = "Amount of money is € " + myWallet.GetMoney();
                lblAmountMoney2.Text = "Amount of money is € " + anotherWallet.GetMoney();
            }
        }
    }
}
