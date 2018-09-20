using System;

namespace _4._2._3_Restaurant
{
    class Meal
    {
        string description;
        double price;

        public Meal(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
        public double getPrice()
        {
            return price;
        }
    }
}
