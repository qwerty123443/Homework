using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2._3_Restaurant
{
    public partial class Form1 : Form
    {
        private Person selectedPerson;
        private Meal selectedMeal;

        private Meal meal1 = new Meal("Meal 1", 1);
        private Meal meal2 = new Meal("Meal 2", 2);
        private Meal meal3 = new Meal("Meal 3", 3);
        private Meal meal4 = new Meal("Meal 4", 4);
        private Meal meal5 = new Meal("Meal 5", 5);

        private Person person1 = new Person("Stijn");
        private Person person2 = new Person("Bianca");
        private Person person3 = new Person("Romy");
        private Person person4 = new Person("Miesjel");
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSetOderForPerson_Click(object sender, EventArgs e)
        {
            selectedPerson.setMeal(selectedMeal);
        }

        private void rbMeal1_CheckedChanged(object sender, EventArgs e)
        {
            selectedMeal = meal1;
        }

        private void rbMeal2_CheckedChanged(object sender, EventArgs e)
        {
            selectedMeal = meal2;
        }

        private void rbMeal3_CheckedChanged(object sender, EventArgs e)
        {
            selectedMeal = meal3;
        }

        private void rbMeal4_CheckedChanged(object sender, EventArgs e)
        {
            selectedMeal = meal4;
        }

        private void rbMeal5_CheckedChanged(object sender, EventArgs e)
        {
            selectedMeal = meal5;
        }

        private void rbStijn_CheckedChanged(object sender, EventArgs e)
        {
            selectedPerson = person1;
        }

        private void rbBainca_CheckedChanged(object sender, EventArgs e)
        {
            selectedPerson = person2;
        }

        private void rbRomy_CheckedChanged(object sender, EventArgs e)
        {
            selectedPerson = person3;
        }

        private void rbMiesjel_CheckedChanged(object sender, EventArgs e)
        {
            selectedPerson = person4;
        }

        private void btnFinaliseOrder_Click(object sender, EventArgs e)
        {
            try
            {
                lblTotal.Text = "Total: €" + (person1.getMeal().getPrice() +
                    person2.getMeal().getPrice() +
                    person3.getMeal().getPrice() +
                    person4.getMeal().getPrice()
                    ).ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Please select a meal for every person.");
            }
        }
    }
}
