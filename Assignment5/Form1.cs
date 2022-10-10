using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //retrieve the data from the access database.
            Data.GetData();

            //Display commodity prices to user.
            tb_goat_milk_price.Text = $"${Data.GoatMilkPrice.ToString("0.00")}";
            tb_cow_milk_price.Text = $"${Data.CowMilkPrice.ToString("0.00")}";
            tb_sheep_wool_price.Text = $"${Data.SheepWoolPrice.ToString("0.00")}";
            tb_water_price.Text = $"${Data.WaterPrice.ToString("0.00")}";
            tb_govt_tax.Text = $"${Data.GovtTax.ToString("0.00")}";
            tb_jersey_cow_tax.Text = $"${Data.JCowTax.ToString("0.00")}";

            tb_profit.Text = $"${Functions.TotalProfit().ToString("#.00")}";
            tb_govt_tax_month.Text = $"${Functions.GovtTaxMonth().ToString("#.00")}"; 
            Functions.GoatCowVsSheep(out double gcAvProf, out double sheepAvProf);
            tb_gc_av_prof.Text = $"${gcAvProf.ToString("#.00")}";
            tb_sheep_av_prof.Text = $"${sheepAvProf.ToString("#.00")}";
            tb_dog_cost.Text = $"{Functions.DogVsTotalCost().ToString("#.##")}%";
            tb_jersey_total.Text = $"${Functions.JerseyTaxTotal().ToString("#.00")}";
            tb_jersey_prof.Text = $"${Functions.JerseyProf().ToString("#.00")}";

            
            tb_total_milk.Text = $"{Functions.TotalMilk().ToString("#.00")} litres";
            tb_average_age.Text = $"{Functions.AverageAge().ToString("#.00")}";
            tb_red_animals.Text = $"{Functions.RedRatio().ToString("#.##")}%";

            Functions.GetProfitDict();

            Dictionary<int,double> profits = Functions.SortDict(Functions.GetProfitDict(), Functions.GetProfitDict().First().Key, Functions.GetProfitDict().Last().Key);
            foreach (var element in profits)
            {
                Console.WriteLine($"{element.Key}, {element.Value}");
            }
        }
        private void btn_display_all_Click(object sender, EventArgs e)
        {
            tb_result.Text = "";
            tb_result.Font = new Font("Microsoft Sans Serif", 8);
            foreach (KeyValuePair<int,Animal> element in Data.farm)
            {
                
                tb_result.Text += $"ID: {element.Key}, Amount Water: {element.Value.AmtWater}, Daily Cost: {element.Value.DailyCost}, Type:{element.Value.GetAnimal()}, Profit:{element.Value.ProfitPerDay()}\r\n";
            }
            tb_result.Text += $"Goat Milk {Data.GoatMilkPrice}\r\nSheep Wool{Data.SheepWoolPrice}\r\nWater {Data.WaterPrice}\r\nGovt Tax {Data.GovtTax}\r\nJersey Tax {Data.JCowTax}\r\nCow Milk {Data.CowMilkPrice}\r\n";
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_query.Text, out int id))
            {
                if (Data.farm.ContainsKey(id))
                {
                    tb_result.Font = new Font("Microsoft Sans Serif", 8);
                    tb_result.Text = Data.farm[id].DisplayInfo();
                }
                else
                {
                    MessageBox.Show("ID not Found", "");
                }
            }
            else
            {
                switch(tb_query.Text.ToLower())
                {
                    case "cows":
                        tb_result.Font = new Font("Courier New", 10);
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour",-15}{"Amount Milk"}\r\n";
                        foreach (KeyValuePair<int, Animal> element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Cow"))
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;
                    case "jersey cows":
                        tb_result.Font = new Font("Courier New", 10);
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour",-15}{"Amount Milk"}\r\n";
                        foreach (KeyValuePair<int, Animal> element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Cow"))
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;
                    case "goats":
                        tb_result.Font = new Font("Courier New", 10);
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour",-15}{"Amount Milk"}\r\n";
                        foreach (KeyValuePair<int,Animal> element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Goat")) 
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;
                    case "sheep":
                        tb_result.Font = new Font("Courier New", 10);
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour",-15}{"Amount Wool"}\r\n";
                        foreach (KeyValuePair<int, Animal> element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Sheep"))
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;  
                    case "dogs":
                        tb_result.Font = new Font("Courier New", 10);
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour"}\r\n";
                        foreach (KeyValuePair<int, Animal> element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Dog"))
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;
                    default :
                        MessageBox.Show("Invalid Input", "");
                        break;
                }
            }
        }
        private void tb_age_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_age.Text, out int age))
            {
                String ageFunction = Functions.AgeSearch(age);
                String[] ageResults = ageFunction.Split('!');
                tb_age_result.Text = ageResults[0];
                tb_age_ratio.Text = ageResults[1];
            }
            else
            {
                MessageBox.Show("Invalid Input", "");
            }      
        }
    }
}
