using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project
{
    class Animal
    {
        public double amount_of_water;//per_day
        public double daliy_Cost;//local_cost
        public double weight;//KG
        public int age; //inYears
        public string color;
        public string type;//animal type

        //Animal Constructor
        public Animal( double amount_of_water, double daliy_Cost, double weight, int age, string color, string type)
        {
            this.amount_of_water = amount_of_water;
            this.daliy_Cost = daliy_Cost;
            this.weight = weight;
            this.age = age;
            this.color = color;
            this.type = type;
        }

        //method to be used as a override method.
        virtual public double Getitem()
        {
            return 0;
        }

        //Prints out the amount of Milk made by Cows and Goats
        public double Milk()
        {
            if (!Isdog() && !IsSheep())
            {
                return Getitem();
            }
            else
            {
                return 0;
            }
        }
        
        //profit method to be override when it is on a certain animals.
        virtual public double Profit()
        {
            return 0;
        }

        //Shows All Tax paid.
        public double Gove_tax()
        {
            if (!Isdog())
            {
                double costs = Getitem();
                double tax = Prices.Government_Tax;

                return costs * tax;
            }
            else
            {
                return 0;
            }
            
        }

        //Shows Jerseycow tax paid.
        public double Jersycow_tax_paid()
        {
            if(IsJersyCow())
            {
                return Prices.Government_Tax + Prices.Jersy_Cow_Tax;
            }
            else
            {
                return 0;
            }
            
        }

        //cost method used for override
        virtual public double Cost()
        {
            return 0;
        }

        //Checks if the the animals is red or not.
        public bool Isred()
        {
            if (color.Equals("Red"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checks if the animal is dog or not.
        public bool Isdog()
        {
            if (type.Equals("Dog"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Checks if the animal is Jerseycow or not.
        public bool IsJersyCow()
        {
            if (type.Equals("Jersey Cow"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checks if the animal is Sheep or not.
        public bool IsSheep()
        {
            if (type.Equals("Sheep"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
