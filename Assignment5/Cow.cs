using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Cow : Animal
    {
        //additional property specific to cow
        public double AmtMilk { get; set; }
        //constructor for cow
        public Cow(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour, double AmtMilk) : base(ID, AmtWater, DailyCost, Weight, Age, Colour) { this.AmtMilk = AmtMilk; }
        //method to get the animal type for cow, overrides animal method
        public override string GetAnimal()
        {
            return "Cow";
        }
        //method to display all information for a cow, overrides animal method
        public override String DisplayInfo()
        {
            String info = $"ID: {ID}\r\nType: Cow\r\nAmount of Water(per day): {AmtWater}\r\nDaily Cost: {DailyCost}\r\nWeight: {Weight}\r\nAge: {Age}\r\nColour: {Colour}\r\nAmount of Milk(per day): {AmtMilk}";
            return info;
        }
        //for testing purposes, overrides animal method
        public override String DisplayAll()
        {
            String info = $"{ID,-8}{AmtWater,-25}{DailyCost,-15}{Weight,-18}{Age,-12}{Colour,-15}{AmtMilk}\r\n";
            return info;
        }
        //method to calculate profit per day for each cow. overrides animal method
        public override double ProfitPerDay()
        {
            double profit = (AmtMilk * Data.CowMilkPrice) - (AmtWater * Data.WaterPrice) - (Weight * Data.GovtTax) - DailyCost; 
            return profit;
        }
        //method to get how much milk is produced per day from each cow in litres. Used in total milk calculation method.
        //overriddes animal method.
        public override double GetMilk()
        {
            double milk = AmtMilk;
            return milk;
        }
    }
    
}
