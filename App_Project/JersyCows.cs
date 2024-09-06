using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project
{
    class JersyCows : Cows
    {
        //JerseyCow Constructor
        public JersyCows( double amount_of_water, double daliy_Cost, double weight, int age, string color, string type, double amount_of_milk) : base(amount_of_water, daliy_Cost, weight, age, color, type, amount_of_milk)
        {
            ;
        }

        //method override to show item when animal is JerseyCow.
        override public double Getitem()
        {
            return amount_of_milk;
        }

        //Method override to show profit made when animal is JerseyCow.
        override public double Profit()
        {
            double costs = Cost();
            double amt_milk = amount_of_milk;
            double prices = Prices.Cow_Milk_Price;
            double profit = (amt_milk * prices) - costs;
            return profit;
        }

        //Method override to show cost when animal is JerseyCow.
        override public double Cost()
        {
            return (Getitem() * Prices.Government_Tax) + (amount_of_water * Prices.Water_price) + Prices.Jersy_Cow_Tax + daliy_Cost;
        }

    }
}
