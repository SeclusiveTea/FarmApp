using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Goat : Animal
    {
        //additional property specific to goat
        public double AmtMilk { get; set; }
        //constructor for goat
        public Goat(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour, double AmtMilk) : base(ID, AmtWater, DailyCost, Weight, Age, Colour) { this.AmtMilk = AmtMilk; }
        //method to get the animal type for goat, overrides animal method
        public override string GetAnimal()
        {
            return "Goat";
        }
        //method to display all information for a goat, overrides animal method
        public override String DisplayInfo()
        {
            String info = $"ID: {ID}\r\nType: Goat\r\nAmount of Water(per day): {AmtWater}\r\nDaily Cost: {DailyCost}\r\nWeight: {Weight}\r\nAge: {Age}\r\nColour: {Colour}\r\nAmount of Milk(per day): {AmtMilk}";
            return info;
        }
        //for testing purposes, overrides animal method
        public override String DisplayAll()
        {
            String info = $"{ID,-8}{AmtWater,-25}{DailyCost,-15}{Weight,-18}{Age,-12}{Colour,-15}{AmtMilk}\r\n";
            return info;
        }
        //method to calculate profit per day for each goat. overrides animal method
        public override double ProfitPerDay()
        {
            double profit = (AmtMilk * Data.GoatMilkPrice) - (AmtWater * Data.WaterPrice) - (Weight * Data.GovtTax) - DailyCost;
            return profit;
        }
        //method to get how much milk is produced per day from each goat in litres. Used in total milk calculation method.
        //overriddes animal method.
        public override double GetMilk()
        {
            double milk = AmtMilk;
            return milk;
        }

    }
}
