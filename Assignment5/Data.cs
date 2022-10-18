using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    //This class contains all code that relates to reading from the database and generating the variables
    //and objects from the information in that database.
    internal class Data
    {
        //create a static dictionary to access from anywhere in the program
        public static Dictionary<int, Animal> farm = new Dictionary<int, Animal>();
        //create static variables for all commodity prices that can be accessed from anywhere in the program.
        public static double GoatMilkPrice;
        public static double SheepWoolPrice;
        public static double WaterPrice;
        public static double GovtTax;
        public static double JCowTax;
        public static double CowMilkPrice;

        public static void GetData()
        {
            String ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0; 
                             Data Source = E:\wintec\Year 2 Semester 2\Comp609 Application Development\FarmInfomation.accdb;
                             Persist Security Info = False";
            String q = ""; //query string
            OleDbConnection conn = null;
            try
            {
                //array of queries for looping
                String[] queries = {"goats", "sheep", "dogs", "cows", "commodity prices"};

                //create and open the connection
                conn = new OleDbConnection(ConnStr);
                conn.Open();
                foreach(string query in queries)
                {
                    q = $"select * from [{query}];";
                    //create the connection command
                    OleDbCommand cmd = new OleDbCommand(q, conn);

                    //string that will contain the output
                    String str = "";
                    String[] strArr;

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        //read the data and add it to a string

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                str += $"{reader[i]},";
                            }
                            //skip the rest of the while loop if the table is commodity prices
                            if (query.Equals("commodity prices")) continue;
                            
                            //for each line of the table, the table name will determine what object is created
                            //and the contents will be split up and assigned to the properties
                            //in the constructor to create a new object and add it to the static dictionary.
                            strArr = str.Split(',');
                            str = "";
                            
                            switch (query)
                            {
                                case "goats":
                                    farm.Add(int.Parse(strArr[0]), new Goat(int.Parse(strArr[0]), double.Parse(strArr[1]), double.Parse(strArr[2]), double.Parse(strArr[3]), int.Parse(strArr[4]), strArr[5], double.Parse(strArr[6])));
                                    break;
                                case "sheep":
                                    farm.Add(int.Parse(strArr[0]), new Sheep(int.Parse(strArr[0]), double.Parse(strArr[1]), double.Parse(strArr[2]), double.Parse(strArr[3]), int.Parse(strArr[4]), strArr[5], double.Parse(strArr[6])));
                                    break;
                                case "dogs":
                                    farm.Add(int.Parse(strArr[0]), new Dog(int.Parse(strArr[0]), double.Parse(strArr[1]), double.Parse(strArr[5]), double.Parse(strArr[2]), int.Parse(strArr[3]), strArr[4]));
                                    break;
                                case "cows":
                                    if (strArr[7].Equals("True"))
                                    {
                                        farm.Add(int.Parse(strArr[0]), new JerseyCow(int.Parse(strArr[0]), double.Parse(strArr[1]), double.Parse(strArr[2]), double.Parse(strArr[3]), int.Parse(strArr[4]), strArr[5], double.Parse(strArr[6])));
                                    }
                                    else
                                    {
                                        farm.Add(int.Parse(strArr[0]), new Cow(int.Parse(strArr[0]), double.Parse(strArr[1]), double.Parse(strArr[2]), double.Parse(strArr[3]), int.Parse(strArr[4]), strArr[5], double.Parse(strArr[6])));
                                    }
                                    break;
                            }  
                        }
                        //skip the next block of code if the table is not commodity prices
                        if (!query.Equals("commodity prices")) continue;
                        
                        //for commodity prices table, this splits the string created and sets each item in the split array
                        //to a commodity price variable
                        strArr = str.Split(',');
                        GoatMilkPrice = double.Parse(strArr[1]);
                        SheepWoolPrice = double.Parse(strArr[3]);
                        WaterPrice = double.Parse(strArr[5]);
                        GovtTax = double.Parse(strArr[7]);
                        JCowTax = double.Parse(strArr[9]);
                        CowMilkPrice = double.Parse(strArr[11]);
                    }
                }
            }
            //error handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            //whether the code errors or not, the connection will always close because this code will execute before the program ends
            finally
            {
                conn.Close();
            }
        }
    }
}
