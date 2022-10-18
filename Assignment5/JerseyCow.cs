using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class JerseyCow : Cow
    {
        //no additional properties needed as it inherits all required from cow
        
        //constructor for jersey cow
        public JerseyCow(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour, double AmtMilk) : base(ID, AmtWater, DailyCost, Weight, Age, Colour, AmtMilk) { }
        //method to get the animal type for jersey cow, overrides cow method
        public override string GetAnimal()
        {
            return "Jersey Cow";
        }
        //method to display all information for a jersey cow, overrides cow method
        public override String DisplayInfo()
        {
            String info = $"ID: {ID}\r\nType: Jersey Cow\r\nAmount of Water(per day): {AmtWater}\r\nDaily Cost: {DailyCost}\r\nWeight: {Weight}\r\nAge: {Age}\r\nColour: {Colour}\r\nAmount of Milk(per day): {AmtMilk}";
            return info;
        }
        //for testing purposes, overrides cow method
        public override String DisplayAll()
        {
            String info = $"{ID,-8}{AmtWater,-25}{DailyCost,-15}{Weight,-18}{Age,-12}{Colour,-15}{AmtMilk}\r\n";
            return info;
        }
        //method to calculate profit per day for each jersey cow. overrides cow method
        public override double ProfitPerDay()
        {
            double profit = (AmtMilk * Data.CowMilkPrice) - (AmtWater * Data.WaterPrice) - (Weight * Data.GovtTax) - (Weight * Data.JCowTax) - DailyCost;
            return profit;
        }
        //method to get how much milk is produced per day from each jersey cow in litres. Used in total milk calculation method.
        //overriddes cow method.
        public override double GetMilk()
        {
            double milk = AmtMilk;
            return milk;
        }
        //method to calculate total Jersey cow tax per day for each jersey cow. Used in total jersey tax method. overrides animal method 
        public override double JerseyTax()
        {
            double jerseyTax = (Weight * Data.GovtTax) + (Weight * Data.JCowTax);
            return jerseyTax;
        }
    }
}
