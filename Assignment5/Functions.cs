using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    //This class contains all the methods that are functions not related to form control or reading the data from the table.
    //All methods are object manipulation and calculation
    internal class Functions
    {
        //REPORT 2: method to calculate total profitability of the farm and return the value.
        public static double TotalProfit()
        {
            //variable to add profit into
            double totProf = 0;
            //for each object, use the ProfitPerDay method to get the profit per animal and add it to the total profit variable
            foreach (var element in Data.farm)
            {
                totProf += element.Value.ProfitPerDay();
            }
            return totProf;
        }
        //REPORT 3: method to calculate the total government tax paid per month and return the value
        public static double GovtTaxMonth()
        {
            //variable to add tax into
            double govtTax = 0;
            //for each object, use the GovtTaxPerAnimalPerMonth method to get the value of tax paid per animal per month and add it to the total.
            foreach (var element in Data.farm)
            {
                govtTax += element.Value.GovtTaxPerAnimalPerMonth(); 
            }
            return govtTax;
        }
        //REPORT 4: method to calculate the total amount of milk produced by cows, jersey cows and goats and return the value
        public static double TotalMilk()
        {
            //variable to add milk into
            double totalMilk = 0;
            //for each object, determine if it is a cow or a goat or a jersey cow then use the GetMilk method to get the value of milk
            //per day for each animal and add it to the total.
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() == "Cow" || element.Value.GetAnimal() == "Jersey Cow" || element.Value.GetAnimal() == "Goat")
                {
                    totalMilk += element.Value.GetMilk();
                }   
            }
            return totalMilk;
        }
        //REPORT 5: method to calculate the average age and return the value
        public static double AverageAge()
        {
            //variable to add all the ages into
            double averageAge = 0;
            //variable to count the animals to divide the total age by to get the average age
            int count = 0;
            //for each animal, determine it isn't a dog, then get the age from the property and add it into the total and increase the count
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() != "Dog")
                {
                    averageAge += element.Value.Age;
                    count++;
                }  
            }
            //take the total age calculated and divide it by the amount of animals it added the age for.
            averageAge = averageAge / count;
            return averageAge;
        }
        //REPORT 6: method to calculate the average profitability of goats and cows vs sheep and give 2 values as out parameters.
        //Demonstration of understanding of our parameters.
        public static void GoatCowVsSheep(out double gcAvProf, out double sheepAvProf)
        {
            //variable to add total goat and cow profit into
            double gcProf = 0;
            //variable to add total sheep profit into
            double sheepProf = 0;
            //variable to count all goats and cows to divide total by to get average
            double gcCount = 0;
            //variable to count all sheep to divide total by to get average
            double sheepCount = 0;
            //for each animal in dictionary determine if it is goat or cow or jersey cow and use the ProfitPerDay method to get a value for profit per animal and add to the goat and cow total.
            //If not a cow or jersey cow or goat, determine if animal is a sheep and use the ProfitPerDay method to get a value for profit per animal and add to the sheep total.
            //If neither of these, do nothing with the object.
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
            //divide total goat and cow profit by amount of goats and cows. Add to the variable that is the out parameter.
            gcAvProf = gcProf / gcCount;
            //divide total sheep profit by amount of sheep. Add to the variable that is the out parameter.
            sheepAvProf = sheepProf / sheepCount;
            
        }
        //REPORT 7: method to calculate the ratio of dog cost vs the total cost and return ratio as a percentage
        public static double DogVsTotalCost()
        {
            //variable to add dog daily costs into
            double dogCost = 0;
            //variable to add total daily costs into
            double totalCost = 0;
            //for each animal in dictionary, determine if the animal is a dog. If it is, add the daily cost to both the dogCost variable and totalCost variable.
            //if not a dog, then just add the daily cost to the total cost variable.
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
            //divide the dog cost by the total cost and multiply by 100 to give a ratio as a percentage.
            double ratio = dogCost / totalCost * 100;
            return ratio;
        }
        //REPORT 8: method to get the list of profitabilities to sort.
        public static List<double> GetProfitList()
        {
            List<double> profits = new List<double>();
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() != "Dog")
                {
                    profits.Add(element.Value.ProfitPerDay());
                }
            }
            return profits;
        }
        //REPORT 8: Recursive Method containing a quick sort algorithm to sort the profitabilities.
        //Takes the list as an argument as well as the first number index and last number index.
        //returns a sorted list
        public static List<double> SortList(List<double> list, int leftIndex, int rightIndex)
        {
            //sets variables for the algorithm.
            var i = leftIndex;
            var j = rightIndex;
            var pivot = list[leftIndex];
            //keep this loop going as long as i and j havent passed each other in the list.
            while (i <= j)
            {
                //start at second element and keep moving to the right until it finds an element that is larger than the pivot. 
                while (list[i] < pivot)
                {
                    i++;
                }
                //start at last element and keep moving to the left until it finds an element that is smaller than the pivot.
                while (list[j] > pivot)
                {
                    j--;
                }
                //swap i and j if i is smaller than j, otherwise keep looping until i and j cross over
                if (i <= j)
                {
                    double temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }
            //sort left sublist
            if (leftIndex < j)
                SortList(list, leftIndex, j);
            //sort right sublist
            if (i < rightIndex)
                SortList(list, i, rightIndex);
            //return the sorted list
            return list;
        }
        //REPORT 8: Generate the file with the list of IDs in order of profitability.
        public static void PrintProfitList()
        {
            //creates a list of IDs to tie to the profits.
            List<int> ids = new List<int>();
            foreach (var element in Data.farm)
            {
                ids.Add(element.Value.ID);
            }
            //uses the SortList method and GetProfitList method to create the list of profits in sorted order. 
            List<double> profits = Functions.SortList(Functions.GetProfitList(), 0, Functions.GetProfitList().Count - 1);

            //file name to create
            string fileName = @"E:\mytest.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                //open the writer to write the text file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    //for each item in the profit list, scan the ID list and if the profit matches
                    //the ID in the object dictionary and method, print the ID and print the profit to the text file.
                    //This required a nested loop to keep the profit list in correct order.
                    for (int i = 0; i < profits.Count; i++)
                    {
                        for (int j = 0; j < ids.Count; j++)
                        {
                            if (profits[i] == Data.farm[ids[j]].ProfitPerDay())
                            {
                                fileStr.WriteLine($"{Data.farm[ids[j]].ID}, {profits[i]}");
                            }
                        }
                    }
                }
            }
            //error handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            if (File.Exists(fileName))
            {
                Process.Start("explorer.exe", fileName);
            }
        }
        //REPORT 9: method to display the ratio of animals that is the colour red. returns a ratio as a percentage.
        public static double RedRatio()
        {
            //variable to add red animals to
            double redAnimals = 0;
            //variable to add all animals to
            double allAnimals = 0;
            //for each animal in the dictionary, use the IsRed method to check if animal is red or not
            //If red, add to red animals and total animals
            //If not red, only add to total animals
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
            //divide red animals by all animals and multiply by 100 to give a ratio as a percentage.
            double ratio = redAnimals / allAnimals * 100;
            return ratio;
        }
        //REPORT 10: Method to calculate the total amount of tax paid for Jersey cows per day. returns the total.
        public static double JerseyTaxTotal()
        {
            //variable to add tax into
            double totalTax = 0;
            //for each object in the dictionary, call the method JerseyTax to get a value and add that value to the total.
            foreach (var element in Data.farm)
            {
                    totalTax += element.Value.JerseyTax();
            }
            return totalTax;
        }
        //REPORT 11: The user can enter a threshold age (number of years) and this method will display the ratio in percentage of animals
        //over that age. As an extra I have also chosen to display the list of animals over that age.
        //takes user input age as a parameter
        //returns a string as the results. This is a demonstration of another way to get multiple values returned from a method by using a 
        //string and splitting it.
        public static String AgeSearch(int age)
        {
            //variable to add results into 
            String ageSearch = "";
            //variable to count animals above the age
            double aboveAge = 0;
            //variable to count the total animals
            double total = 0;
            //for each animal, determine if it is above the age threshold. If it is above the age threshold, add 1 to aboveAge variable
            //add 1 to total variable and add the animal details to the string. If the animal is not above the threshold, just add
            //1 to the total variable.
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
            //divide aboveAge by total and multiply by 100 to calculate the ratio as a percentage.
            double ratio = aboveAge / total * 100;
            //add the splitting character and the ratio to the string.
            ageSearch += $"!{ratio}%";

            return ageSearch;   
        }
        //REPORT 12: Display the total profitability of all Jersey Cows per day and return value.
        public static double JerseyProf()
        {
            //variable to add profits into
            double jerseyProf = 0;
            //for each animal in dictionary, use GetAnimal method to determine if it is a jersey cow.
            //if it is a jersey cow, add the value from the ProfitPerDay method into the total.
            foreach (var element in Data.farm)
            {
                if (element.Value.GetAnimal() == "Jersey Cow")
                {
                    jerseyProf += element.Value.ProfitPerDay();
                }

            }
            return jerseyProf;
        }
    }
}
