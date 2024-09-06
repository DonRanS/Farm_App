using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project
{
    class Sheeps : Animal
    {

        public double amount_of_wool;//per_year

        //Sheep Constructor
        public Sheeps(double amount_of_water, double daliy_Cost, double weight, int age, string color, string type, double amount_of_wool) :
            base(amount_of_water, daliy_Cost, weight, age, color,type)
        {

            this.amount_of_wool = amount_of_wool;
        }
        //method override to show item when animal is Sheep.
        override public double Getitem()
        {
            return (amount_of_wool * 365);
        }
        //Method override to show profit made when animal is Sheep. 
        override public double Profit()
        {
            double costs = Cost();
            double amt_milk = Getitem();
            double prices = Prices.Sheep_Wool_Price;
            double profit = (amt_milk * prices) - costs;
            return profit;
        }

        //Method override to show cost when animal is Sheep.
        override public double Cost()
        {
            return (Getitem() * Prices.Government_Tax) + (amount_of_water * Prices.Water_price) + daliy_Cost;
        }
    }
}
