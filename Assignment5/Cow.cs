using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Cow : Animal
    {
        public double AmtMilk { get; set; }

        public Cow(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour, double AmtMilk) : base(ID, AmtWater, DailyCost, Weight, Age, Colour) { this.AmtMilk = AmtMilk; }

        public override string GetAnimal()
        {
            return "Cow";
        }
        public override String DisplayInfo()
        {
            String info = $"ID: {ID}\r\nType: Cow\r\nAmount of Water(per day): {AmtWater}\r\nDaily Cost: {DailyCost}\r\nWeight: {Weight}\r\nAge: {Age}\r\nColour: {Colour}\r\nAmount of Milk(per day): {AmtMilk}";
            return info;
        }
        public override String DisplayAll()
        {
            String info = $"{ID,-8}{AmtWater,-15}{DailyCost,-15}{Weight,-15}{Age,-10}{Colour,-15}{AmtMilk}\r\n";
            return info;
        }
        public override double ProfitPerDay()
        {
            double profit = (AmtMilk * Data.CowMilkPrice) - (AmtWater * Data.WaterPrice) - (Weight * Data.GovtTax) - DailyCost; 
            return profit;
        }
        public override double GetMilk()
        {
            double milk = AmtMilk;
            return milk;
        }
    }
    
}
