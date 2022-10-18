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

            //Display commodity prices to user in the 'Reports' tab.
            tb_goat_milk_price.Text = $"${Data.GoatMilkPrice.ToString("0.00")}";
            tb_cow_milk_price.Text = $"${Data.CowMilkPrice.ToString("0.00")}";
            tb_sheep_wool_price.Text = $"${Data.SheepWoolPrice.ToString("0.00")}";
            tb_water_price.Text = $"${Data.WaterPrice.ToString("0.00")}";
            tb_govt_tax.Text = $"${Data.GovtTax.ToString("0.00")}";
            tb_jersey_cow_tax.Text = $"${Data.JCowTax.ToString("0.00")}";

            //Display all the reports that are in the 'Reports' tab. 
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
        }
        //REPORT 1: Search button for the 'Animal search' tab
        private void btn_search_Click(object sender, EventArgs e)
        {
            //error handling, validation of user input
            if (int.TryParse(tb_query.Text, out int id))
            {
                //query the dictionary of objects and display if there is a key that matches the user input.
                if (Data.farm.ContainsKey(id))
                {
                    tb_result.Text = Data.farm[id].DisplayInfo();
                }
                else
                {
                    //error handling, what to display if key doesn't match user input.
                    MessageBox.Show("ID not Found", "");
                }
            }
            else
            {
                //EXTRA - Here is the code for the option to type "cows" and see all cows or "goats" and see all goats.
                switch(tb_query.Text.ToLower())
                {
                    case "cows":
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour",-15}{"Amount Milk"}\r\n";
                        foreach (var element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Cow"))
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;
                    case "jersey cows":
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour",-15}{"Amount Milk"}\r\n";
                        foreach (var element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Jersey Cow"))
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;
                    case "goats":
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour",-15}{"Amount Milk"}\r\n";
                        foreach (var element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Goat")) 
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;
                    case "sheep":
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour",-15}{"Amount Wool"}\r\n";
                        foreach (var element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Sheep"))
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;  
                    case "dogs":
                        tb_result.Text = $"{"ID",-8}{"Amount Water",-15}{"Daily Cost",-15}{"Weight",-15}{"Age",-10}{"Colour"}\r\n";
                        foreach (var element in Data.farm)
                        {
                            if (element.Value.GetAnimal().Equals("Dog"))
                            {
                                tb_result.Text += element.Value.DisplayAll();
                            }
                        }
                        break;
                    default :
                        //error handling, what to display if a key doesn't match AND wording doesn't match any of the cases above.
                        MessageBox.Show("Invalid Input", "");
                        break;
                }
            }
        }
        //REPORT 11: Search button for 'Age Search' tab.
        private void btn_age_search_Click(object sender, EventArgs e)
        {
            //error handling - validate the user input.
            if (int.TryParse(tb_age.Text, out int age))
            {
                //grab string of results from the age search function.
                String ageFunction = Functions.AgeSearch(age);
                //split the string so the string of animals is 1 element and the ratio is the other element.
                String[] ageResults = ageFunction.Split('!');
                //display string of animals
                tb_age_result.Text = ageResults[0];
                //display ratio of animals above that age.
                tb_age_ratio.Text = ageResults[1];
            }
            else
            {
                //what to display if user input isn't valid
                MessageBox.Show("Invalid Input", "");
            }      
        }
        //REPORT 8: Button in "Reports" tab to generate the profitability report.
        private void Btn_profit_list(object sender, EventArgs e)
        {
            Functions.PrintProfitList();
        }
    }
}
