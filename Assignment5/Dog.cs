using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Dog : Animal
    {
        public Dog(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour) : base(ID, AmtWater, DailyCost, Weight, Age, Colour) { }
        public override string GetAnimal()
        {
            return "Dog";
        }
        public override String DisplayInfo()
        {
            String info = $"ID: {ID}\r\nType: Dog\r\nAmount of Water(per day): {AmtWater}\r\nDaily Cost: {DailyCost}\r\nWeight: {Weight}\r\nAge: {Age}\r\nColour: {Colour}";
            return info;
        }
        public override String DisplayAll()
        {
            String info = $"{ID,-8}{AmtWater,-15}{DailyCost,-15}{Weight,-15}{Age,-10}{Colour,-15}\r\n";
            return info;
        }
        public override double GovtTaxPerAnimalPerMonth()
        {
            return 0;
        }
        public override double ProfitPerDay()
        {
            double profit = 0 - (AmtWater * Data.WaterPrice) - DailyCost;
            return profit;
        }
    }
}
