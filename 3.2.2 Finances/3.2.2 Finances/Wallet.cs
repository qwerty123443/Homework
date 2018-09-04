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
        private string ownerName;
        private int money;


        public String GetOwnerName()
        {
            return ownerName;
        }
        public int GetMoney()
        {
            return money;
        }
        public void SetOwnerName(String name)
        {
            ownerName = name;
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
