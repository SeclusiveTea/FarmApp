namespace Assignment5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FarmApp = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_display_all = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_query = new System.Windows.Forms.TextBox();
            this.tab_Profit = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_red_animals = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_average_age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_total_milk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_jersey_cow_tax = new System.Windows.Forms.TextBox();
            this.tb_govt_tax = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_water_price = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_sheep_wool_price = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_cow_milk_price = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_goat_milk_price = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_jersey_prof = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_jersey_total = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_dog_cost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_sheep_av_prof = new System.Windows.Forms.TextBox();
            this.tb_gc_av_prof = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_govt_tax_month = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_profit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.age_search = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_age_search = new System.Windows.Forms.Button();
            this.tb_age_result = new System.Windows.Forms.TextBox();
            this.tab_home = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_age_ratio = new System.Windows.Forms.TextBox();
            this.FarmApp.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tab_Profit.SuspendLayout();
            this.age_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // FarmApp
            // 
            this.FarmApp.Controls.Add(this.tab_home);
            this.FarmApp.Controls.Add(this.tabPage2);
            this.FarmApp.Controls.Add(this.tab_Profit);
            this.FarmApp.Controls.Add(this.age_search);
            this.FarmApp.Location = new System.Drawing.Point(-1, 0);
            this.FarmApp.Name = "FarmApp";
            this.FarmApp.SelectedIndex = 0;
            this.FarmApp.Size = new System.Drawing.Size(683, 428);
            this.FarmApp.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_search);
            this.tabPage2.Controls.Add(this.btn_display_all);
            this.tabPage2.Controls.Add(this.tb_result);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_query);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animal Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(351, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_display_all
            // 
            this.btn_display_all.Location = new System.Drawing.Point(520, 12);
            this.btn_display_all.Name = "btn_display_all";
            this.btn_display_all.Size = new System.Drawing.Size(108, 23);
            this.btn_display_all.TabIndex = 3;
            this.btn_display_all.Text = "Display All Data";
            this.btn_display_all.UseVisualStyleBackColor = true;
            this.btn_display_all.Click += new System.EventHandler(this.btn_display_all_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(16, 48);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_result.Size = new System.Drawing.Size(636, 342);
            this.tb_result.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search Animal by ID or Type:";
            // 
            // tb_query
            // 
            this.tb_query.Location = new System.Drawing.Point(170, 15);
            this.tb_query.Name = "tb_query";
            this.tb_query.Size = new System.Drawing.Size(154, 20);
            this.tb_query.TabIndex = 0;
            // 
            // tab_Profit
            // 
            this.tab_Profit.Controls.Add(this.button1);
            this.tab_Profit.Controls.Add(this.label21);
            this.tab_Profit.Controls.Add(this.label20);
            this.tab_Profit.Controls.Add(this.tb_red_animals);
            this.tab_Profit.Controls.Add(this.label11);
            this.tab_Profit.Controls.Add(this.tb_average_age);
            this.tab_Profit.Controls.Add(this.label7);
            this.tab_Profit.Controls.Add(this.tb_total_milk);
            this.tab_Profit.Controls.Add(this.label6);
            this.tab_Profit.Controls.Add(this.label19);
            this.tab_Profit.Controls.Add(this.tb_jersey_cow_tax);
            this.tab_Profit.Controls.Add(this.tb_govt_tax);
            this.tab_Profit.Controls.Add(this.label18);
            this.tab_Profit.Controls.Add(this.tb_water_price);
            this.tab_Profit.Controls.Add(this.label17);
            this.tab_Profit.Controls.Add(this.tb_sheep_wool_price);
            this.tab_Profit.Controls.Add(this.label16);
            this.tab_Profit.Controls.Add(this.tb_cow_milk_price);
            this.tab_Profit.Controls.Add(this.label15);
            this.tab_Profit.Controls.Add(this.tb_goat_milk_price);
            this.tab_Profit.Controls.Add(this.label14);
            this.tab_Profit.Controls.Add(this.tb_jersey_prof);
            this.tab_Profit.Controls.Add(this.label13);
            this.tab_Profit.Controls.Add(this.tb_jersey_total);
            this.tab_Profit.Controls.Add(this.label12);
            this.tab_Profit.Controls.Add(this.tb_dog_cost);
            this.tab_Profit.Controls.Add(this.label10);
            this.tab_Profit.Controls.Add(this.tb_sheep_av_prof);
            this.tab_Profit.Controls.Add(this.tb_gc_av_prof);
            this.tab_Profit.Controls.Add(this.label9);
            this.tab_Profit.Controls.Add(this.label8);
            this.tab_Profit.Controls.Add(this.tb_govt_tax_month);
            this.tab_Profit.Controls.Add(this.label5);
            this.tab_Profit.Controls.Add(this.tb_profit);
            this.tab_Profit.Controls.Add(this.label4);
            this.tab_Profit.Location = new System.Drawing.Point(4, 22);
            this.tab_Profit.Name = "tab_Profit";
            this.tab_Profit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Profit.Size = new System.Drawing.Size(675, 402);
            this.tab_Profit.TabIndex = 2;
            this.tab_Profit.Text = "Reports";
            this.tab_Profit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Generate Order of Profitability File:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(19, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 18);
            this.label21.TabIndex = 35;
            this.label21.Text = "Reports:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(208, 18);
            this.label20.TabIndex = 34;
            this.label20.Text = "Current Commodity Prices:";
            // 
            // tb_red_animals
            // 
            this.tb_red_animals.Location = new System.Drawing.Point(235, 325);
            this.tb_red_animals.Name = "tb_red_animals";
            this.tb_red_animals.ReadOnly = true;
            this.tb_red_animals.Size = new System.Drawing.Size(100, 20);
            this.tb_red_animals.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ratio of red animals:";
            // 
            // tb_average_age
            // 
            this.tb_average_age.Location = new System.Drawing.Point(523, 288);
            this.tb_average_age.Name = "tb_average_age";
            this.tb_average_age.ReadOnly = true;
            this.tb_average_age.Size = new System.Drawing.Size(100, 20);
            this.tb_average_age.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Average age of farm animals:";
            // 
            // tb_total_milk
            // 
            this.tb_total_milk.Location = new System.Drawing.Point(235, 292);
            this.tb_total_milk.Name = "tb_total_milk";
            this.tb_total_milk.ReadOnly = true;
            this.tb_total_milk.Size = new System.Drawing.Size(100, 20);
            this.tb_total_milk.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total milk per day (Goats and Cows):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(414, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(162, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Jersey Cow Tax (per kg per day):";
            // 
            // tb_jersey_cow_tax
            // 
            this.tb_jersey_cow_tax.Location = new System.Drawing.Point(582, 85);
            this.tb_jersey_cow_tax.Name = "tb_jersey_cow_tax";
            this.tb_jersey_cow_tax.ReadOnly = true;
            this.tb_jersey_cow_tax.Size = new System.Drawing.Size(57, 20);
            this.tb_jersey_cow_tax.TabIndex = 26;
            // 
            // tb_govt_tax
            // 
            this.tb_govt_tax.Location = new System.Drawing.Point(343, 85);
            this.tb_govt_tax.Name = "tb_govt_tax";
            this.tb_govt_tax.ReadOnly = true;
            this.tb_govt_tax.Size = new System.Drawing.Size(57, 20);
            this.tb_govt_tax.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(206, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Govt Tax (per kg per day):";
            // 
            // tb_water_price
            // 
            this.tb_water_price.Location = new System.Drawing.Point(143, 85);
            this.tb_water_price.Name = "tb_water_price";
            this.tb_water_price.ReadOnly = true;
            this.tb_water_price.Size = new System.Drawing.Size(57, 20);
            this.tb_water_price.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Water Price (per Cube):";
            // 
            // tb_sheep_wool_price
            // 
            this.tb_sheep_wool_price.Location = new System.Drawing.Point(582, 50);
            this.tb_sheep_wool_price.Name = "tb_sheep_wool_price";
            this.tb_sheep_wool_price.ReadOnly = true;
            this.tb_sheep_wool_price.Size = new System.Drawing.Size(57, 20);
            this.tb_sheep_wool_price.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(414, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Sheep Wool Price ( kg ):";
            // 
            // tb_cow_milk_price
            // 
            this.tb_cow_milk_price.Location = new System.Drawing.Point(343, 50);
            this.tb_cow_milk_price.Name = "tb_cow_milk_price";
            this.tb_cow_milk_price.ReadOnly = true;
            this.tb_cow_milk_price.Size = new System.Drawing.Size(57, 20);
            this.tb_cow_milk_price.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(206, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Cow Milk Price ( l ):";
            // 
            // tb_goat_milk_price
            // 
            this.tb_goat_milk_price.Location = new System.Drawing.Point(143, 50);
            this.tb_goat_milk_price.Name = "tb_goat_milk_price";
            this.tb_goat_milk_price.ReadOnly = true;
            this.tb_goat_milk_price.Size = new System.Drawing.Size(57, 20);
            this.tb_goat_milk_price.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Goat Milk Price ( l ):";
            // 
            // tb_jersey_prof
            // 
            this.tb_jersey_prof.Location = new System.Drawing.Point(235, 257);
            this.tb_jersey_prof.Name = "tb_jersey_prof";
            this.tb_jersey_prof.ReadOnly = true;
            this.tb_jersey_prof.Size = new System.Drawing.Size(100, 20);
            this.tb_jersey_prof.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Total Jersey Cow Profit Per Day:";
            // 
            // tb_jersey_total
            // 
            this.tb_jersey_total.Location = new System.Drawing.Point(523, 224);
            this.tb_jersey_total.Name = "tb_jersey_total";
            this.tb_jersey_total.ReadOnly = true;
            this.tb_jersey_total.Size = new System.Drawing.Size(100, 20);
            this.tb_jersey_total.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total Jersey Cow Tax Per Day:";
            // 
            // tb_dog_cost
            // 
            this.tb_dog_cost.Location = new System.Drawing.Point(235, 224);
            this.tb_dog_cost.Name = "tb_dog_cost";
            this.tb_dog_cost.ReadOnly = true;
            this.tb_dog_cost.Size = new System.Drawing.Size(100, 20);
            this.tb_dog_cost.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Dog Cost as Percentage of Total Cost:";
            // 
            // tb_sheep_av_prof
            // 
            this.tb_sheep_av_prof.Location = new System.Drawing.Point(523, 190);
            this.tb_sheep_av_prof.Name = "tb_sheep_av_prof";
            this.tb_sheep_av_prof.ReadOnly = true;
            this.tb_sheep_av_prof.Size = new System.Drawing.Size(100, 20);
            this.tb_sheep_av_prof.TabIndex = 8;
            // 
            // tb_gc_av_prof
            // 
            this.tb_gc_av_prof.Location = new System.Drawing.Point(235, 190);
            this.tb_gc_av_prof.Name = "tb_gc_av_prof";
            this.tb_gc_av_prof.ReadOnly = true;
            this.tb_gc_av_prof.Size = new System.Drawing.Size(100, 20);
            this.tb_gc_av_prof.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Vs. Sheep Average Profit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Goat and Cow Average Profit:";
            // 
            // tb_govt_tax_month
            // 
            this.tb_govt_tax_month.Location = new System.Drawing.Point(523, 158);
            this.tb_govt_tax_month.Name = "tb_govt_tax_month";
            this.tb_govt_tax_month.ReadOnly = true;
            this.tb_govt_tax_month.Size = new System.Drawing.Size(100, 20);
            this.tb_govt_tax_month.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Government tax per month:";
            // 
            // tb_profit
            // 
            this.tb_profit.Location = new System.Drawing.Point(235, 158);
            this.tb_profit.Name = "tb_profit";
            this.tb_profit.ReadOnly = true;
            this.tb_profit.Size = new System.Drawing.Size(100, 20);
            this.tb_profit.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Profit per Day:";
            // 
            // age_search
            // 
            this.age_search.Controls.Add(this.tb_age_ratio);
            this.age_search.Controls.Add(this.label2);
            this.age_search.Controls.Add(this.tb_age_result);
            this.age_search.Controls.Add(this.tb_age_search);
            this.age_search.Controls.Add(this.tb_age);
            this.age_search.Controls.Add(this.label1);
            this.age_search.Location = new System.Drawing.Point(4, 22);
            this.age_search.Name = "age_search";
            this.age_search.Padding = new System.Windows.Forms.Padding(3);
            this.age_search.Size = new System.Drawing.Size(675, 402);
            this.age_search.TabIndex = 3;
            this.age_search.Text = "Age Search";
            this.age_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an age to see all Livestock above that age:";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(257, 13);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(100, 20);
            this.tb_age.TabIndex = 1;
            // 
            // tb_age_search
            // 
            this.tb_age_search.Location = new System.Drawing.Point(381, 11);
            this.tb_age_search.Name = "tb_age_search";
            this.tb_age_search.Size = new System.Drawing.Size(75, 23);
            this.tb_age_search.TabIndex = 2;
            this.tb_age_search.Text = "Search";
            this.tb_age_search.UseVisualStyleBackColor = true;
            this.tb_age_search.Click += new System.EventHandler(this.tb_age_search_Click);
            // 
            // tb_age_result
            // 
            this.tb_age_result.Location = new System.Drawing.Point(13, 45);
            this.tb_age_result.Multiline = true;
            this.tb_age_result.Name = "tb_age_result";
            this.tb_age_result.ReadOnly = true;
            this.tb_age_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_age_result.Size = new System.Drawing.Size(653, 277);
            this.tb_age_result.TabIndex = 3;
            // 
            // tab_home
            // 
            this.tab_home.BackgroundImage = global::Assignment5.Properties.Resources.farmapp;
            this.tab_home.Location = new System.Drawing.Point(4, 22);
            this.tab_home.Name = "tab_home";
            this.tab_home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_home.Size = new System.Drawing.Size(675, 402);
            this.tab_home.TabIndex = 0;
            this.tab_home.Text = "Home";
            this.tab_home.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ratio:";
            // 
            // tb_age_ratio
            // 
            this.tb_age_ratio.Location = new System.Drawing.Point(57, 335);
            this.tb_age_ratio.Name = "tb_age_ratio";
            this.tb_age_ratio.ReadOnly = true;
            this.tb_age_ratio.Size = new System.Drawing.Size(100, 20);
            this.tb_age_ratio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 427);
            this.Controls.Add(this.FarmApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Farm App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FarmApp.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tab_Profit.ResumeLayout(false);
            this.tab_Profit.PerformLayout();
            this.age_search.ResumeLayout(false);
            this.age_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FarmApp;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tab_Profit;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_query;
        private System.Windows.Forms.Button btn_display_all;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_profit;
        private System.Windows.Forms.TextBox tb_govt_tax_month;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage age_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox tb_gc_av_prof;
        internal System.Windows.Forms.TextBox tb_sheep_av_prof;
        private System.Windows.Forms.TextBox tb_dog_cost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_jersey_total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_jersey_prof;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_goat_milk_price;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_cow_milk_price;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_sheep_wool_price;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_water_price;
        private System.Windows.Forms.TextBox tb_govt_tax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_jersey_cow_tax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_red_animals;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_average_age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_total_milk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_age_result;
        private System.Windows.Forms.Button tb_age_search;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_age_ratio;
        private System.Windows.Forms.Label label2;
    }
}

