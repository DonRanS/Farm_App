using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project
{
    class Goats : Animal
    {
        public double amount_of_milk;// amo_of_milk_per_day
        public Goats( double amount_of_water, double daliy_Cost, double weight, int age, string color, string type, double amount_of_milk) : base( amount_of_water, daliy_Cost, weight, age, color,type)
        {
            this.amount_of_milk = amount_of_milk;
        }

        override public double Getitem()
        {
            return amount_of_milk;
        }

        override public double Profit()
        {
            
            double costs = Cost();
            double amt_milk = amount_of_milk;
            double prices = Prices.Goat_Milk_Price;
            double profit = (amt_milk * prices) - costs;
            return profit;
        }


        override public double Cost()
        {

            return (Getitem() * Prices.Government_Tax) + (amount_of_water * Prices.Water_price) + daliy_Cost;
        }



    }
}
