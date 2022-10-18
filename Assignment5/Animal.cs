using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Animal
    {
        //setting properties for all animals
        public int ID;
        public double AmtWater;
        public double DailyCost;
        public double Weight;
        public int Age;
        public string Colour;

        //constructor for all animals
        public Animal(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour)
        {
            this.ID = ID;
            this.AmtWater = AmtWater;
            this.DailyCost = DailyCost;
            this.Weight = Weight;
            this.Age = Age;
            this.Colour = Colour;
        }
        //method to return animal type, overridden in subclasses
        public virtual String GetAnimal()
        {
            return "Animal";
        }
        //method to display information of animal, overridden in subclasses
        public virtual String DisplayInfo()
        {
            String info = "";
            return info;
        }
        //for testing purposes, overridden in subclasses
        public virtual String DisplayAll()
        {
            String info = "";
            return info;
        }
        //method to return profit per day of animal, overriden in subclasses
        public virtual double ProfitPerDay()
        {
            return 0;
        }
        //method to calculate government tax per animal per month. This has an override in dogs to return 0 as dogs are excluded from tax.
        public virtual double GovtTaxPerAnimalPerMonth()
        {
            double tax = Weight * Data.GovtTax * 365 / 12;
            return tax;
        }
        //method to calculate jersey cow tax per day, overridden in jersey cow subclass.
        public virtual double JerseyTax()
        {
            return 0;
        }
        //method to get how much milk is produced per day from each animal in litres, to be used in total milk calculation method.
        //overridden in goat, cow and jersey cow
        public virtual double GetMilk()
        {
            return 0;
        }
        //method to return true if animal is red or false if animal isn't red. Used in red ratio method.
        public bool IsRed()
        {
            if (Colour.ToLower() == "red")
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
