using System;

namespace _4._2._3_Restaurant
{
    class Person
    {
        private string name;
        private Meal selectedMeal;

        public Person(string name)
        {
            this.name = name;
        }

        public void setMeal(Meal selectedMeal)
        {
            this.selectedMeal = selectedMeal;
        }
        public Meal getMeal()
        {
            return selectedMeal;
        }
    }
}
