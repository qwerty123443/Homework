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
    class Person
    {
        private string name;
        private string email;
        private int age;
        private Wallet wallet1;
        private Wallet wallet2;

        public Person(string name)
        {
            this.name = name;
            this.email = "unknown";
            this.age = 999;
        }

        public Person(string name, string email, int age)
        {
            this.name = name;
            this.email = email;
            this.age = age;
        }
        
        public Person(string name, string email, int age,
            string descr1, int balance1,
            string descr2, int balance2)
        {
            this.name = name;
            this.email = email;
            this.age = age;
            this.wallet1 = new Wallet(descr1, balance1);
            this.wallet2 = new Wallet(descr2, balance2);
        }
        public string GetName()
        {
            return name;
        }
        public Wallet getWallet1()
        {
            return wallet1;
        }
        public Wallet getWallet2()
        {
            return wallet2;
        }

    }
}
