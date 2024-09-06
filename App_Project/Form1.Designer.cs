namespace App_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new System.Windows.Forms.Button();
            this.Output_infor = new System.Windows.Forms.RichTextBox();
            this.Input_Id = new System.Windows.Forms.RichTextBox();
            this.Output_profit = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tot_Gov_Tax = new System.Windows.Forms.RichTextBox();
            this.Tot_Milk = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Total_jersy = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Output_Jersy_Profit = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.output_Ratio_color = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.output_Ave_age = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Input_age = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.output_age = new System.Windows.Forms.RichTextBox();
            this.output_Cost_Ratio = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.table_box = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Ave_milk_vs_wool = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Database_Locater = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(343, 422);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(103, 45);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Search";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Output_infor
            // 
            this.Output_infor.Location = new System.Drawing.Point(12, 171);
            this.Output_infor.Name = "Output_infor";
            this.Output_infor.Size = new System.Drawing.Size(477, 72);
            this.Output_infor.TabIndex = 1;
            this.Output_infor.Text = "";
            // 
            // Input_Id
            // 
            this.Input_Id.Location = new System.Drawing.Point(126, 132);
            this.Input_Id.Name = "Input_Id";
            this.Input_Id.Size = new System.Drawing.Size(162, 33);
            this.Input_Id.TabIndex = 2;
            this.Input_Id.Text = "";
            // 
            // Output_profit
            // 
            this.Output_profit.Location = new System.Drawing.Point(7, 505);
            this.Output_profit.Name = "Output_profit";
            this.Output_profit.Size = new System.Drawing.Size(158, 30);
            this.Output_profit.TabIndex = 3;
            this.Output_profit.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Profit/Lose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Government tax";
            // 
            // Tot_Gov_Tax
            // 
            this.Tot_Gov_Tax.Location = new System.Drawing.Point(197, 505);
            this.Tot_Gov_Tax.Name = "Tot_Gov_Tax";
            this.Tot_Gov_Tax.Size = new System.Drawing.Size(178, 30);
            this.Tot_Gov_Tax.TabIndex = 6;
            this.Tot_Gov_Tax.Text = "";
            // 
            // Tot_Milk
            // 
            this.Tot_Milk.Location = new System.Drawing.Point(426, 505);
            this.Tot_Milk.Name = "Tot_Milk";
            this.Tot_Milk.Size = new System.Drawing.Size(114, 30);
            this.Tot_Milk.TabIndex = 7;
            this.Tot_Milk.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Milk from \r\n goat and cows";
            // 
            // Total_jersy
            // 
            this.Total_jersy.Location = new System.Drawing.Point(7, 579);
            this.Total_jersy.Name = "Total_jersy";
            this.Total_jersy.Size = new System.Drawing.Size(158, 36);
            this.Total_jersy.TabIndex = 9;
            this.Total_jersy.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jersey_Tax";
            // 
            // Output_Jersy_Profit
            // 
            this.Output_Jersy_Profit.Location = new System.Drawing.Point(197, 579);
            this.Output_Jersy_Profit.Name = "Output_Jersy_Profit";
            this.Output_Jersy_Profit.Size = new System.Drawing.Size(145, 36);
            this.Output_Jersy_Profit.TabIndex = 11;
            this.Output_Jersy_Profit.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total profit \r\nFrom JersyCow";
            // 
            // output_Ratio_color
            // 
            this.output_Ratio_color.Cursor = System.Windows.Forms.Cursors.Cross;
            this.output_Ratio_color.Location = new System.Drawing.Point(426, 576);
            this.output_Ratio_color.Name = "output_Ratio_color";
            this.output_Ratio_color.Size = new System.Drawing.Size(111, 39);
            this.output_Ratio_color.TabIndex = 13;
            this.output_Ratio_color.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = " Red : All color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter ID:";
            // 
            // output_Ave_age
            // 
            this.output_Ave_age.Location = new System.Drawing.Point(589, 505);
            this.output_Ave_age.Name = "output_Ave_age";
            this.output_Ave_age.Size = new System.Drawing.Size(121, 30);
            this.output_Ave_age.TabIndex = 16;
            this.output_Ave_age.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Average age";
            // 
            // Input_age
            // 
            this.Input_age.Location = new System.Drawing.Point(126, 279);
            this.Input_age.Name = "Input_age";
            this.Input_age.Size = new System.Drawing.Size(176, 36);
            this.Input_age.TabIndex = 18;
            this.Input_age.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Enter age:";
            // 
            // output_age
            // 
            this.output_age.Location = new System.Drawing.Point(12, 321);
            this.output_age.Name = "output_age";
            this.output_age.Size = new System.Drawing.Size(490, 86);
            this.output_age.TabIndex = 20;
            this.output_age.Text = "";
            // 
            // output_Cost_Ratio
            // 
            this.output_Cost_Ratio.Location = new System.Drawing.Point(589, 577);
            this.output_Cost_Ratio.Name = "output_Cost_Ratio";
            this.output_Cost_Ratio.Size = new System.Drawing.Size(116, 38);
            this.output_Cost_Ratio.TabIndex = 21;
            this.output_Cost_Ratio.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dogs Cost:All Cost";
            // 
            // table_box
            // 
            this.table_box.Location = new System.Drawing.Point(186, 65);
            this.table_box.Name = "table_box";
            this.table_box.Size = new System.Drawing.Size(202, 31);
            this.table_box.TabIndex = 24;
            this.table_box.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Insert Report Number";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Ave_milk_vs_wool
            // 
            this.Ave_milk_vs_wool.Location = new System.Drawing.Point(738, 502);
            this.Ave_milk_vs_wool.Name = "Ave_milk_vs_wool";
            this.Ave_milk_vs_wool.Size = new System.Drawing.Size(146, 33);
            this.Ave_milk_vs_wool.TabIndex = 26;
            this.Ave_milk_vs_wool.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(509, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(378, 303);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(738, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 40);
            this.label12.TabIndex = 29;
            this.label12.Text = "Average Profit\r\nCows&Goats Vs. Sheep";
            // 
            // Database_Locater
            // 
            this.Database_Locater.Location = new System.Drawing.Point(197, 12);
            this.Database_Locater.Name = "Database_Locater";
            this.Database_Locater.Size = new System.Drawing.Size(105, 29);
            this.Database_Locater.TabIndex = 30;
            this.Database_Locater.Text = "DB_Locator:";
            this.Database_Locater.UseVisualStyleBackColor = true;
            this.Database_Locater.Click += new System.EventHandler(this.Database_Locater_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(308, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "No database Located";
            // 
            // Form1
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 667);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Database_Locater);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Ave_milk_vs_wool);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.table_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.output_Cost_Ratio);
            this.Controls.Add(this.output_age);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Input_age);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.output_Ave_age);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.output_Ratio_color);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Output_Jersy_Profit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total_jersy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tot_Milk);
            this.Controls.Add(this.Tot_Gov_Tax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output_profit);
            this.Controls.Add(this.Input_Id);
            this.Controls.Add(this.Output_infor);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Button1;
        private RichTextBox Output_infor;
        private RichTextBox Input_Id;
        private RichTextBox Output_profit;
        private Label label1;
        private Label label2;
        private RichTextBox Tot_Gov_Tax;
        private RichTextBox Tot_Milk;
        private Label label3;
        private RichTextBox Total_jersy;
        private Label label4;
        private RichTextBox Output_Jersy_Profit;
        private Label label5;
        private RichTextBox output_Ratio_color;
        private Label label6;
        private Label label7;
        private RichTextBox output_Ave_age;
        private Label label8;
        private RichTextBox Input_age;
        private Label label9;
        private RichTextBox output_age;
        private RichTextBox output_Cost_Ratio;
        private Label label10;
        private RichTextBox table_box;
        private Label label11;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox Ave_milk_vs_wool;
        private RichTextBox richTextBox1;
        private Label label12;
        private Button Database_Locater;
        private Label label13;
    }
}