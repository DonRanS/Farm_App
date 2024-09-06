using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project
{
    class Dogs : Animal
    {
        //Dog Constructor
        public Dogs(double amount_of_water, double daliy_Cost, double weight, int age, string color, string type) : base( amount_of_water, daliy_Cost, weight, age, color, type)
        {
            ;
        }

        //Method override to show cost when animal is Dogs.
        override public double Cost()
        {
            return (amount_of_water * Prices.Water_price) + daliy_Cost;
        }
    }
}
