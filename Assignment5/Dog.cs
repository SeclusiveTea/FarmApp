using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Dog : Animal
    {
        //no additional properties needed as animal has all the properties it needs.

        //constructor for dog.
        public Dog(int ID, double AmtWater, double DailyCost, double Weight, int Age, string Colour) : base(ID, AmtWater, DailyCost, Weight, Age, Colour) { }
        //method to get the animal type for dog, overrides animal method
        public override string GetAnimal()
        {
            return "Dog";
        }
        //method to display all information for a dog, overrides animal method
        public override String DisplayInfo()
        {
            String info = $"ID: {ID}\r\nType: Dog\r\nAmount of Water(per day): {AmtWater}\r\nDaily Cost: {DailyCost}\r\nWeight: {Weight}\r\nAge: {Age}\r\nColour: {Colour}";
            return info;
        }
        //for testing purposes, overrides animal method
        public override String DisplayAll()
        {
            String info = $"{ID,-8}{AmtWater,-15}{DailyCost,-15}{Weight,-15}{Age,-10}{Colour,-15}\r\n";
            return info;
        }
        //method to calculate profit per day for each dog. overrides animal method
        public override double ProfitPerDay()
        {
            double profit = 0 - (AmtWater * Data.WaterPrice) - DailyCost;
            return profit;
        }
        //This method overrides the animal method to return 0 as dogs are excluded from tax.
        public override double GovtTaxPerAnimalPerMonth()
        {
            return 0;
        }
    }
}
