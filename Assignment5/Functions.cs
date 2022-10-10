using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Functions
    {
        public static double TotalProfit()
        {
            double totProf = 0;
            foreach (var element in Data.farm)
            {
                totProf += element.Value.ProfitPerDay();
            }
            return totProf;
        }
        public static double GovtTaxMonth()
        {
            double govtTax = 0;
            foreach (var element in Data.farm)
            {
                govtTax += element.Value.GovtTaxPerAnimalPerMonth(); 
            }
            return govtTax;
        }
        public static double TotalMilk()
        {
            double totalMilk = 0;
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() == "Cow" || element.Value.GetAnimal() == "Jersey Cow" || element.Value.GetAnimal() == "Goat")
                {
                    totalMilk += element.Value.GetMilk();
                }   
            }
            return totalMilk;
        }
        public static double AverageAge()
        {
            double averageAge = 0;
            int count = 0;
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() != "Dog")
                {
                    averageAge += element.Value.Age;
                    count++;
                }  
            }
            averageAge = averageAge / count;
            return averageAge;
        }
        public static void GoatCowVsSheep(out double gcAvProf, out double sheepAvProf)
        {
            double gcProf = 0;
            double sheepProf = 0;
            double gcCount = 0;
            double sheepCount = 0;

            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() == "Cow" || element.Value.GetAnimal() == "Jersey Cow" || element.Value.GetAnimal() == "Goat")
                {
                    gcProf += element.Value.ProfitPerDay();
                    gcCount++;
                }
                else if (element.Value.GetAnimal() == "Sheep")
                {
                    sheepProf += element.Value.ProfitPerDay();
                    sheepCount++;
                }
            }
            gcAvProf = gcProf / gcCount;
            sheepAvProf = sheepProf / sheepCount;
            
        }
        public static double DogVsTotalCost()
        {
            double dogCost = 0;
            double totalCost = 0;
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() == "Dog")
                {
                    dogCost += element.Value.DailyCost;
                    totalCost += element.Value.DailyCost;
                }
                else
                {
                    totalCost += element.Value.DailyCost;
                }
            }
            double ratio = dogCost / totalCost * 100;
            return ratio;
        }
        public static double RedRatio()
        {
            double redAnimals = 0;
            double allAnimals = 0;
            foreach (var element in Data.farm)
            {
                if (element.Value.IsRed())
                {
                    redAnimals ++;
                    allAnimals ++;
                }
                else
                {
                    allAnimals ++;
                }
            }
            double ratio = redAnimals / allAnimals * 100;
            return ratio;
        }
        public static double JerseyTaxTotal()
        {
            double totalTax = 0;
            foreach (var element in Data.farm)
            {
                    totalTax += element.Value.JerseyTax();
            }
            return totalTax;
        }
        public static double JerseyProf()
        {
            double jerseyProf = 0;
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() == "Jersey Cow")
                {
                    jerseyProf += element.Value.ProfitPerDay();
                }
                
            }
            return jerseyProf;
        }
        public static Dictionary<int, double> GetProfitDict()
        {
            Dictionary<int, double> profits = new Dictionary<int, double>();
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() != "Dog")
                {
                    profits.Add(element.Key, element.Value.ProfitPerDay());
                }   
            }
            foreach(var element in profits)
            {
                Console.WriteLine($"{element.Key}, {element.Value}");
            }
            Console.WriteLine(profits.First().Value);
            Console.WriteLine(profits.Last().Value);

            return profits;
        }
        public static Dictionary<int, double> SortDict(Dictionary<int, double> profits, int leftKey, int rightKey)
        {

            var i = leftKey;
            var j = rightKey;
            var pivot = profits[leftKey];
            while (i <= j)
            {
                while (profits[i] < pivot)
                {
                    i++;
                }

                while (profits[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    double temp = profits[i];
                    profits[i] = profits[j];
                    profits[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftKey < j)
                SortDict(profits, leftKey, j);
            if (i < rightKey)
                SortDict(profits, i, rightKey);
            return profits;

        }
        public static String AgeSearch(int age)
        {
            String ageSearch = "";
            double aboveAge = 0;
            double total = 0;
            foreach (var element in Data.farm)
            {
                if (element.Value.Age > age)
                {
                    aboveAge++;
                    total++;
                    ageSearch += $"ID:{element.Key}   Age: {element.Value.Age}     Type: {element.Value.GetAnimal()}\r\n";
                }
                else
                {
                    total++;
                }
            }
            double ratio = aboveAge / total * 100;
            ageSearch += $"!{ratio}%";

            return ageSearch;   
        }
    }
}
