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
    class Wallet
    {
        private string description;
        private int money;
        
        public Wallet(string description)
        {
            this.description = description;
            this.money = 0;
        }
        public Wallet(string description, int balance)
        {
            this.description = description;
            this.money = balance;
        }

        public string GetDescription()
        {
            return description;
        }
        public int GetMoney()
        {
            return money;
        }
        public void AddMoney(int amountOfMoneyToAdd)
        {
            money += amountOfMoneyToAdd;
        }
        public void RemoveMoney(int amountOfMoneyToRemove)
        {
            money -= amountOfMoneyToRemove;
        }
    }
}
