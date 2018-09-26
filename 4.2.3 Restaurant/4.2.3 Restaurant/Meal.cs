using System;

namespace _4._2._3_Restaurant
{
    class Meal
    {
        private string description;
        private double price;

        public Meal(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
        public double getPrice()
        {
            return price;
        }
        public string getDescription()
        {
            return description;
        }
    }
}
