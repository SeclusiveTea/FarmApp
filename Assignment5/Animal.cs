using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Animal
    {
        public int ID;
        public double AmtWater;
        public double DailyCost;
        public double Weight;
        public int Age;
        public string Colour;

        public Animal(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour)
        {
            this.ID = ID;
            this.AmtWater = AmtWater;
            this.DailyCost = DailyCost;
            this.Weight = Weight;
            this.Age = Age;
            this.Colour = Colour;
        }
        public virtual String GetAnimal()
        {
            return "Animal";
        }
        public virtual String DisplayInfo()
        {
            String info = "";
            return info;
        }
        public virtual String DisplayAll()
        {
            String info = "";
            return info;
        }
        public virtual double ProfitPerDay()
        {
            return 0;
        }
        public virtual double GovtTaxPerAnimalPerMonth()
        {
            double tax = Weight * Data.GovtTax * 365 / 12;
            return tax;
        }
        public virtual double JerseyTax()
        {
            return 0;
        }
        public virtual double GetMilk()
        {
            return 0;
        }
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
