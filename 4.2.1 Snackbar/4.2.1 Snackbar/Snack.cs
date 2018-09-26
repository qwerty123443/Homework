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
    class Snack
    {
        private double costPrice;
        private bool isVegetarian;
        private string name;
        private int numberInStock;
        private int limit;
        public Snack(double costPrice, bool isVegetarian, String name, int numberInStock, int limit)
        {
            this.costPrice = costPrice;
            this.isVegetarian = isVegetarian;
            this.name = name;
            this.numberInStock = numberInStock;
            this.limit = limit;
        }
        public string GetInfo()
        {
            return $"The snack is called {name} and costs {GetSellingPrice().ToString("0.00")}. it is{(isVegetarian ? "": " not" )} vegetarian.\nThere are {numberInStock} left in stock. {(numberInStock<=limit ? "You should order more snacks!":"")}";
        }

        public int GetNumberInStock()
        {
            return numberInStock;
        }

        public double GetSellingPrice()
        {
            return costPrice * 1.60;
        }

        public void SellSome(int n)
        {
            numberInStock -= n;
        }
        public void ChangePrice(double costPrice)
        {
            this.costPrice = costPrice;
        }
    }

}
