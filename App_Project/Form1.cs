using System.Data.OleDb;

namespace App_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //hashtable
        private Dictionary<int, Animal> fea = new Dictionary<int, Animal>();

        //database link
        private String? lin;

        //Database location
        private string file = "";

        //Database connector
        private OleDbConnection? conn = null;

        
        private void Button1_Click(object sender, EventArgs e)
        {
            //Checks if the file is empty or not
            if(!file.Equals(""))
            {
                //Report checking
                int selecter;
                try
                {
                    selecter = Convert.ToInt16(table_box.Text);
                }
                catch
                {
                    selecter = default;
                }

                switch (selecter)
                {
                    default:
                        MessageBox.Show("Please enter the appropriate Report number");
                        break;

                    case 1:
                        Searched_by_ID();
                        break;
                    case 2:
                        Display_Total_Pofit();
                        break;
                    case 3:
                        Total_goverment_tax();
                        break;
                    case 4:
                        Total_Milk();
                        break;
                    case 5:
                        Average_Age();
                        break;
                    case 6:
                        Ave_profit();
                        break;
                    case 7:
                        Ratio_Dogs_cost_Vs_Total_cost();
                        break;
                    case 8:
                        ID_N_Profit();
                        break;
                    case 9:
                        Ratio_Red_Color_Vs_other_Color();
                        break;
                    case 10:
                        Total_JersyCow_Tax();
                        break;
                    case 11:
                        Searched_by_Age();
                        break;
                    case 12:
                        Total_JersyCow_Profit();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error, please select a database.");
            }
        }

        //Displays the Average Profit made for Cows&Goats VS Sheep.
        private void Ave_profit()
        {
            Ave_milk_vs_wool.Clear();
            double profit_Milk = 0;
            double profit_wool = 0;
            int count1 = 0;
            int count2 = 0;
            foreach(var elem in fea)
            {
                if (!elem.Value.Isdog())
                {
                    if (!elem.Value.IsSheep())
                    {
                        profit_Milk += elem.Value.Profit();
                        count1++;
                    }
                    else
                    {
                        profit_wool += elem.Value.Profit();
                        count2++;
                    }
                }
            }

            //double total = profit_Milk + profit_wool;
            double average1 = profit_Milk/count1;
            double average2 = profit_wool/count2;
            Ave_milk_vs_wool.Text += average1.ToString("c2") + " | " + average2.ToString("c2");
        }

        //Calculate total_tax paid for JersyCow.
        private void Total_JersyCow_Tax()
        {
            Total_jersy.Clear();
            double total_Jersy_Tax = 0;
            foreach(var elem in fea)
            {
                total_Jersy_Tax += elem.Value.Jersycow_tax_paid();
            }
            Total_jersy.Text = total_Jersy_Tax.ToString("C2") + " per day";

        }


        //Calculates total_Profit_JersyCow made.
        private void Total_JersyCow_Profit()
        {

            Output_Jersy_Profit.Clear();
            double Total_Jersy_Profit = 0;
            foreach(var elem in fea)
            {
                if (elem.Value.IsJersyCow())
                {
                    Total_Jersy_Profit += elem.Value.Profit();
                }
                
            }

            Output_Jersy_Profit.Text =Total_Jersy_Profit.ToString("c2");
        }

        //Calculate the total amount of milk produced per day.
        private void Total_Milk() 
        {
            Tot_Milk.Clear();
            double total_Milk = 0;
            foreach(var elem in fea)
            {
                total_Milk += elem.Value.Milk();
                Tot_Milk.Text = total_Milk.ToString("n2") + " kg";
            }
        }
        
        //Finding the average ages of all animals except dogs.
        private void Average_Age()
        {
            output_Ave_age.Clear();
            
            int farm_animal = 0;
            int total_farm_age = 0;

            foreach (var elem in fea)
            {
                if (elem.Value.Isdog())
                {
                    continue;
                }
                else
                {
                    farm_animal++;
                    total_farm_age += elem.Value.age;

                }

            }

            double ave_age = total_farm_age / farm_animal;
            output_Ave_age.Text = ave_age.ToString();

        }
    
    //Search mutiple animals and displays them based on their age.
        private void Searched_by_Age()
        {
           
            output_age.Clear();
            try
            {
                int ages = Convert.ToInt16(Input_age.Text);

                Display_Information_by_Age(ages);
            }
            catch
            {
                Display_Information_by_Age(0);
            }
        }
        
        private void Display_Information_by_Age(int age)
        {
            
            foreach (var elem in fea)
            {
                if (elem.Value.age >= age)
                {
                    if (elem.Value.type == "Sheep")
                    {
                        string stet = String.Format("{0} |  {1}kg  |  ${2}  | {3}kg |    {4} |  {5}  |  {6} | {7:0.##}kg  \n", elem.Key, elem.Value.amount_of_water, elem.Value.daliy_Cost, elem.Value.weight, elem.Value.age, elem.Value.color, elem.Value.type, elem.Value.Getitem());
                        //output_age.Text = "ID" + "  |  " + "water needed" + " | " + "Daily Cost" + " | " + "Weight" + "|" + "Age" + "|" + "Colour" + "|" + "Type" + "|" + "Wool made" + " \n";
                        output_age.Text += stet;
                    }
                    else if (elem.Value.type == "Dog")
                    {
                        string set = String.Format("{0} |  {1}kg  |  ${2}  | {3}kg |    {4} |  {5}  |  {6}  \n", elem.Key, elem.Value.amount_of_water, elem.Value.daliy_Cost, elem.Value.weight, elem.Value.age, elem.Value.color, elem.Value.type);
                        //output_age.Text = "ID" + "  |  " + "water needed" + " | " + "Daily Cost" + " | " + "Weight" + "|" + "Age" + "|" + "Colour" + "|" + "Type" + " \n";
                        output_age.Text += set;
                    }
                    else
                    {
                        string saw = String.Format("{0} |  {1}kg  |  ${2}  | {3}kg |   {4} |  {5}  |  {6} | {7:0.##}kg  \n", elem.Key, elem.Value.amount_of_water, elem.Value.daliy_Cost, elem.Value.weight, elem.Value.age, elem.Value.color, elem.Value.type, elem.Value.Getitem());
                        //output_age.Text = "ID" + "  |  " + "water needed" + " | " + "Daily Cost" + " | " + "Weight" + "|" + "Age" + "|" + "Colour" + "|" + "Type" + "|" + "Milk made" + "\n";
                        output_age.Text += saw;
                    }
                }
            }
        }
    //

    //Search and Display Information based from ID. 
        private void Searched_by_ID()
        {
            Output_infor.Clear();
            
            try
            {

                int num = Convert.ToInt16(Input_Id.Text);

                if (fea.ContainsKey(num))
                {
                    Display_Information_by_ID(num);
                }
                else
                {

                    //MessageBox.Show("Error, Invalid ID");
                    Output_infor.Text = "Error, Invalid ID";
                }
            }
            catch
            {
                //MessageBox.Show("Error, Enter a ID");
                Output_infor.Text = "Error, Enter a ID";
            }
        }

        private void Display_Information_by_ID(int num)
        {
            foreach (var elem in fea)
            {
                if (elem.Key.Equals(num))
                {
                    if (elem.Value.type == "Sheep")
                    {
                        string stet = String.Format("{0} |  {1}kg  |  ${2}  | {3}kg |    {4} |  {5}  |  {6} | {7:0.##}kg  \n", elem.Key, elem.Value.amount_of_water, elem.Value.daliy_Cost, elem.Value.weight, elem.Value.age, elem.Value.color, elem.Value.type, elem.Value.Getitem());
                        Output_infor.Text = "ID" + "  |  " + "water needed" + " | " + "Daily Cost" + " | " + "Weight" + "|" + "Age" + "|" + "Colour" + "|" + "Type" + "|" + "Wool made" + " \n";
                        Output_infor.Text += stet;
                    }
                    else if (elem.Value.type == "Dog")
                    {
                        string stet = String.Format("{0} |  {1}kg  |  ${2}  | {3}kg |    {4} |  {5}  |  {6}  \n", elem.Key, elem.Value.amount_of_water, elem.Value.daliy_Cost, elem.Value.weight, elem.Value.age, elem.Value.color, elem.Value.type);
                        Output_infor.Text = "ID" + "  |  " + "water needed" + " | " + "Daily Cost" + " | " + "Weight" + "|" + "Age" + "|" + "Colour" + "|" + "Type" + " \n";
                        Output_infor.Text += stet;
                    }
                    else
                    {
                        string stet = String.Format("{0} |  {1}kg  |  ${2}  | {3}kg |   {4} |  {5}  |  {6} | {7:0.##}kg  \n", elem.Key, elem.Value.amount_of_water, elem.Value.daliy_Cost, elem.Value.weight, elem.Value.age, elem.Value.color, elem.Value.type, elem.Value.Getitem());
                        Output_infor.Text = "ID" + "  |  " + "water needed" + " | " + "Daily Cost" + " | " + "Weight" + "|" + "Age" + "|" + "Colour" + "|" + "Type" + "|" + "Milk made" + " \n";
                        Output_infor.Text += stet;
                    }
                }

            }

        }
    //
        //Displays the raito between red color animal and other color animal.
        private void Ratio_Red_Color_Vs_other_Color()
        {
            output_Ratio_color.Clear();
            int red_color_animal = 0;
            int all_color_animal = 0;

            foreach(var elem in fea)
            {
                if (elem.Value.Isred())
                {
                    red_color_animal++;
                    all_color_animal++;
                }
                else
                {
                    all_color_animal++;
                }
            }

            double red_color = red_color_animal / red_color_animal;
            double all_color = all_color_animal / red_color_animal;

            output_Ratio_color.Text = red_color.ToString() + ":" + all_color.ToString();
        }


        //Calculate the ratio between Dogs_Cost and Total_Cost.
        private void Ratio_Dogs_cost_Vs_Total_cost()
        {
            output_Cost_Ratio.Clear();
            double total_dogs_Cost = 0;
            double All_Animal_cost = 0;
            foreach (var elem in fea)
            {
                if (elem.Value.Isdog())
                {
                    total_dogs_Cost += elem.Value.Cost();
                }
                All_Animal_cost += elem.Value.Cost();

            }
            double dogs_cost = total_dogs_Cost / total_dogs_Cost;
            double all_cost = All_Animal_cost / total_dogs_Cost;
            output_Cost_Ratio.Text = dogs_cost.ToString("n0") + ":" + all_cost.ToString("n0");
        }

        //Calulates and prints the Total_profit.
        private void Display_Total_Pofit()
        {
            Output_profit.Clear();
            double totprofit = 0;
            foreach (var elem in fea)
            {
                totprofit += elem.Value.Profit();
                
            }
            Output_profit.Text = totprofit.ToString("c2") + " per day";

        }

        //Calulates and prints the Goverment tax.
        private void Total_goverment_tax()
        {
            Tot_Gov_Tax.Clear();
            double tot_Gover_tax = 0;
            foreach(var elem in fea)
            {
                tot_Gover_tax += elem.Value.Gove_tax();
            }
            double tot_Gov_Tax_Per_Month = tot_Gover_tax / 30;
            Tot_Gov_Tax.Text = tot_Gov_Tax_Per_Month.ToString("c2") + " Per Month";

        }


     //Sort profit in an ascending order and output it onto txt file with their ID.
        private void ID_N_Profit()
        {
            
            int count = 0;
            foreach (var elem in fea)
            {
                if (!elem.Value.Isdog())
                {

                    count++;
                }
            }
            double[] a1 = new double[count];
            int i = 0;
            foreach (var elem in fea)
            {
                if (!elem.Value.Isdog())
                {

                    a1[i] = elem.Value.Profit();
                    i++;
                }
            }

            Quicksort(a1, 0, a1.Length - 1);

            Output_ID_N_Profit(a1);


        }

        private void Output_ID_N_Profit(double[] arr)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.txt)|*.txt";
            if(save.ShowDialog() == DialogResult.OK)
            {

                file = save.FileName;
                
            }

            string filename = file;
            FileInfo f1 = new FileInfo(filename);


            using (StreamWriter fs = f1.CreateText())
            {
                fs.WriteLine("ID" + "   | " + "Profit");
                int g = 0;
                string stet = " ";
                while (g <= arr.Length)
                {
                    foreach (var elem in fea)
                    {
                        if (!elem.Value.Isdog())
                        {

                            if (elem.Value.Profit().Equals(arr[g]))
                            {
                                stet = elem.Key.ToString() + " | " + elem.Value.Profit().ToString("c2");
                                fs.WriteLine(stet);
                                g++;
                                break;
                            }
                        }
                    }
                    if (g == arr.Length)
                    {
                        break;
                    }
                }
            }

        }

        private double[] Quicksort(double[] array, int left, int right)
        {
            var l = left;
            var r = right;
            var povit = array[left];

            while (l <= r)
            {
                while (array[l] < povit)
                {
                    l++;
                }
                while(array[r] > povit)
                {
                    r--;
                }
                if(l <= r)
                {
                    double temp = array[l];
                    array[l] = array[r];
                    array[r] = temp;
                    l++;
                    r--;
                }
            } 
            if(left < r)
            {
                Quicksort(array, left, r);
            }
            if(l < right)
            {
                Quicksort(array, l, right);
            }
            return array;
        }
     //
        
        
    //Inserting all information into the hashtable

        //Add all Information from Goats table into a directory
        private void Goats_Insert_Table()
        {
            conn = new OleDbConnection(lin);
            conn.Open();
            String goat = "SELECT * FROM [Goats]";
            OleDbCommand d_goat = new OleDbCommand(goat, conn);
            using (OleDbDataReader reader = d_goat.ExecuteReader())
            {
                while (reader.Read())
                {

                    int ID = Convert.ToInt32(reader["ID"]);
                    double amt_of_water = Convert.ToDouble(reader["Amount of Water"]);
                    double daily_cost = Convert.ToDouble(reader["Daily Cost"]);
                    double weight = Convert.ToDouble(reader["Weight"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string color = (string)reader["Color"];
                    double amt_of_Milk = Convert.ToDouble(reader["Amount of milk"]);
                    string type = "Goat";
                    Goats farm = new Goats(amt_of_water, daily_cost, weight, age, color, type, amt_of_Milk);
                    fea.Add(ID, farm);
                    continue;
                }
            }
            conn.Close();
        }

        //Add all Information from Cows table into a directory
        private void Cows_Insert_Table()
        {
            String cows = "SELECT * FROM [Cows]";
            conn = new OleDbConnection(lin);
            OleDbCommand d_cow = new OleDbCommand(cows, conn);
            conn.Open();
            using (OleDbDataReader reader = d_cow.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID = Convert.ToInt32(reader["ID"]);
                    double amt_of_water = Convert.ToDouble(reader["Amount of Water"]);
                    double daily_cost = Convert.ToDouble(reader["Daily Cost"]);
                    double weight = Convert.ToDouble(reader["Weight"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string color = (string)reader["Color"];
                    double amt_of_Milk = Convert.ToDouble(reader["Amount of milk"]);
                    bool isJersy = Convert.ToBoolean(reader["is jersy"]);
                    string type1 = "Cow";
                    string type2 = "Jersey Cow";
                    if (isJersy == true)
                    {
                        JersyCows farm = new JersyCows(amt_of_water, daily_cost, weight, age, color, type2, amt_of_Milk);
                        fea.Add(ID, farm);
                        continue;
                    }
                    else
                    {
                        Cows farm = new Cows(amt_of_water, daily_cost, weight, age, color, type1, amt_of_Milk);
                        fea.Add(ID, farm);
                        continue;
                    }
                }
            }
            conn.Close();
        }

        //Add all Information from Sheeps table into a directory.
        private void Sheeps_Insert_Table()
        {
            conn = new OleDbConnection(lin);
            String sheep = "SELECT * FROM [Sheep]";
            OleDbCommand d_sheep = new OleDbCommand(sheep, conn);
            conn.Open();
            using (OleDbDataReader reader = d_sheep.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID = Convert.ToInt32(reader["ID"]);
                    double amt_of_water = Convert.ToDouble(reader["Amount of Water"]);
                    double daily_cost = Convert.ToDouble(reader["Daily Cost"]);
                    double weight = Convert.ToDouble(reader["Weight"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string color = (string)reader["Color"];
                    double amt_of_wool = Convert.ToDouble(reader["Amount of wool"]);
                    string type = "Sheep";
                    Sheeps farm = new Sheeps(amt_of_water, daily_cost, weight, age, color, type, amt_of_wool);
                    fea.Add(ID, farm);
                    continue;
                }
            }
            conn.Close();
        }

        //Add all Information from Dogs table into a directory.
        private void Dogs_Insert_Table() 
        {
            conn = new OleDbConnection(lin);
            String dogs = "SELECT * FROM [Dogs]";
            OleDbCommand d_dogs = new OleDbCommand(dogs, conn);
            conn.Open();
            using (OleDbDataReader reader = d_dogs.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID = Convert.ToInt32(reader["ID"]);
                    double amt_of_water = Convert.ToDouble(reader["Amount of Water"]);
                    double daily_cost = Convert.ToDouble(reader["Daily Cost"]);
                    double weight = Convert.ToDouble(reader["Weight"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string color = (string)reader["Color"];
                    string type = "Dog";
                    Dogs farm = new Dogs(amt_of_water, daily_cost, weight, age, color, type);
                    fea.Add(ID, farm);
                    continue;
                }
            }
            conn.Close();
        }

        //Add all Information from Commodity prices table into public variables.
        private void Commodity_Infor()
        {
            conn = new OleDbConnection(lin);
            String all_price = "SELECT * FROM [Commodity prices]";

            OleDbCommand all_prices = new OleDbCommand(all_price, conn);
            conn.Open();
            using(OleDbDataReader reader = all_prices.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = (string)reader["Commodity"];
                    double price = Convert.ToDouble(reader["Price"]);

                    if(name == "Cow milk price")
                    {
                        Prices.Cow_Milk_Price = price;
                        continue;
                    }
                    if(name == "Goat milk price")
                    {
                        Prices.Goat_Milk_Price = price;
                        continue;
                    }
                    if(name == "Government tax per kg")
                    {
                        Prices.Government_Tax = price;
                        continue;
                    }
                    if(name == "Water price")
                    {
                        Prices.Water_price = price;
                        continue;
                    }
                    if(name == "Sheep wool price")
                    {
                        Prices.Sheep_Wool_Price = price;
                        continue;
                    }
                    if(name == "Jersy cow tax")
                    {
                        Prices.Jersy_Cow_Tax = price;
                        continue;
                    }
                }
            }
            conn.Close();
        }
    //
        
        //Finds the file and inputs the DB variables into the hashtable.
        private void Database_Locater_Click(object sender, EventArgs e)
        {
            
            fea.Clear();
            OpenFileDialog thing = new OpenFileDialog();
            thing.Filter = "(*.accdb)|*.accdb";
            
            //OpenfileDialog to find where the database is.
            if (thing.ShowDialog() == DialogResult.OK)
            {
                file = thing.FileName; 
            }

            label13.Text = file;
            lin = @"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source = " +file +  ";" +
                "Persist Security Info = false";

            //checks if the file is empty.
            if (!file.Equals(""))
            {
                Goats_Insert_Table();
                Cows_Insert_Table();
                Sheeps_Insert_Table();
                Dogs_Insert_Table();
                Commodity_Infor();
            }
            else
            {
                label13.Text = "No database Located";
            }
            

        }
    }
}

