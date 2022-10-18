using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Sheep : Animal
    {
        //additional property specific to sheep
        public double AmtWool;
        //constructor for sheep
        public Sheep(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour, double AmtWool) : base(ID, AmtWater, DailyCost, Weight, Age, Colour) { this.AmtWool = AmtWool; }
        //method to get the animal type for sheep, overrides animal method
        public override string GetAnimal()
        {
            return "Sheep";
        }
        //method to display all information for a sheep, overrides animal method
        public override String DisplayInfo()
        {
            String info = $"ID: {ID}\r\nType: Sheep\r\nAmount of Water(per day): {AmtWater}\r\nDaily Cost: {DailyCost}\r\nWeight: {Weight}\r\nAge: {Age}\r\nColour: {Colour}\r\nAmount of Wool(per day): {AmtWool}";
            return info;
        }
        //for testing purposes, overrides animal method
        public override String DisplayAll()
        {
            String info = $"{ID,-8}{AmtWater,-25}{DailyCost,-15}{Weight,-18}{Age,-12}{Colour,-15}{AmtWool}\r\n";
            return info;
        }
        //method to calculate profit per day for each sheep. overrides animal method
        public override double ProfitPerDay()
        {
            double profit = (AmtWool * Data.SheepWoolPrice) - (AmtWater * Data.WaterPrice) - (Weight * Data.GovtTax) - DailyCost;
            return profit;
        }
    }
}
