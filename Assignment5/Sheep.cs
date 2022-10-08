using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Sheep : Animal
    {
        public double AmtWool;

        public Sheep(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour, double AmtWool) : base(ID, AmtWater, DailyCost, Weight, Age, Colour) { this.AmtWool = AmtWool; }
        public override string GetAnimal()
        {
            return "Sheep";
        }
        public override String DisplayInfo()
        {
            String info = $"ID: {ID}\r\nType: Sheep\r\nAmount of Water(per day): {AmtWater}\r\nDaily Cost: {DailyCost}\r\nWeight: {Weight}\r\nAge: {Age}\r\nColour: {Colour}\r\nAmount of Wool(per day): {AmtWool}";
            return info;
        }
        public override String DisplayAll()
        {
            String info = $"{ID,-8}{AmtWater,-15}{DailyCost,-15}{Weight,-15}{Age,-10}{Colour,-15}{AmtWool}\r\n";
            return info;
        }
        public override double ProfitPerDay()
        {
            double profit = (AmtWool * Data.SheepWoolPrice) - (AmtWater * Data.WaterPrice) - (Weight * Data.GovtTax) - DailyCost;
            return profit;
        }
    }
}
