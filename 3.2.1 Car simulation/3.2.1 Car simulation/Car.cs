using System;
using System.Windows.Forms;

namespace _3._2._1_Car_simulation
{
    internal class Car
    {
        private string brand;
        private int currentSpeed;
        private int maxSpeed;
        public void SetBrand(String brand)
        {
            this.brand = brand;
        }
        public String AsAString()
        {
            return $"Speed of my {brand} is {currentSpeed} km/h and its maximum speed is {maxSpeed}";
        }
        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
        public void SpeedUp()
        {
            currentSpeed += 7;
            if (currentSpeed > maxSpeed)
                currentSpeed = maxSpeed;
        }
        public void SpeedDown()
        {
            currentSpeed -= 10;
            if (currentSpeed < 0)
                currentSpeed = 0;
        }
    }
}