namespace WinFormsApp1
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
            Total = new TextBox();
            OneThousand = new TextBox();
            Change = new TextBox();
            Twenty = new TextBox();
            Fifty = new TextBox();
            OneHundred = new TextBox();
            FiveHundred = new TextBox();
            One = new TextBox();
            Five = new TextBox();
            Ten = new TextBox();
            Cof_check = new CheckBox();
            button1 = new Button();
            CoffeePrice = new TextBox();
            HowManyCoffee = new TextBox();
            HowManyTea = new TextBox();
            TeaPrice = new TextBox();
            Tea_check = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Cash = new TextBox();
            button2 = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            Burger_Amount = new TextBox();
            Burger_Price = new TextBox();
            Burger_Check = new CheckBox();
            Pizza_Amount = new TextBox();
            Pizza_Price = new TextBox();
            Pizza_Check = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            label18 = new Label();
            label16 = new Label();
            Discount_All = new CheckBox();
            Tb_DisAll = new TextBox();
            Discount_Drink = new CheckBox();
            Tb_DisDrink = new TextBox();
            Discount_Food = new CheckBox();
            Tb_DisFood = new TextBox();
            label17 = new Label();
            OneStang = new TextBox();
            FiveStang = new TextBox();
            TenStang = new TextBox();
            TwentyFiveStang = new TextBox();
            FiftyStang = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // Total
            // 
            Total.BackColor = SystemColors.ButtonHighlight;
            Total.Location = new Point(469, 26);
            Total.Name = "Total";
            Total.Size = new Size(100, 23);
            Total.TabIndex = 7;
            // 
            // OneThousand
            // 
            OneThousand.BackColor = SystemColors.ButtonHighlight;
            OneThousand.Location = new Point(469, 169);
            OneThousand.Name = "OneThousand";
            OneThousand.Size = new Size(100, 23);
            OneThousand.TabIndex = 22;
            // 
            // Change
            // 
            Change.BackColor = SystemColors.ButtonHighlight;
            Change.Location = new Point(469, 140);
            Change.Name = "Change";
            Change.Size = new Size(100, 23);
            Change.TabIndex = 21;
            // 
            // Twenty
            // 
            Twenty.BackColor = SystemColors.ButtonHighlight;
            Twenty.Location = new Point(469, 281);
            Twenty.Name = "Twenty";
            Twenty.Size = new Size(100, 23);
            Twenty.TabIndex = 26;
            // 
            // Fifty
            // 
            Fifty.BackColor = SystemColors.ButtonHighlight;
            Fifty.Location = new Point(469, 252);
            Fifty.Name = "Fifty";
            Fifty.Size = new Size(100, 23);
            Fifty.TabIndex = 25;
            // 
            // OneHundred
            // 
            OneHundred.BackColor = SystemColors.ButtonHighlight;
            OneHundred.Location = new Point(469, 227);
            OneHundred.Name = "OneHundred";
            OneHundred.Size = new Size(100, 23);
            OneHundred.TabIndex = 24;
            // 
            // FiveHundred
            // 
            FiveHundred.BackColor = SystemColors.ButtonHighlight;
            FiveHundred.Location = new Point(469, 198);
            FiveHundred.Name = "FiveHundred";
            FiveHundred.Size = new Size(100, 23);
            FiveHundred.TabIndex = 23;
            // 
            // One
            // 
            One.BackColor = SystemColors.ButtonHighlight;
            One.Location = new Point(469, 364);
            One.Name = "One";
            One.Size = new Size(100, 23);
            One.TabIndex = 29;
            // 
            // Five
            // 
            Five.BackColor = SystemColors.ButtonHighlight;
            Five.Location = new Point(469, 335);
            Five.Name = "Five";
            Five.Size = new Size(100, 23);
            Five.TabIndex = 28;
            // 
            // Ten
            // 
            Ten.BackColor = SystemColors.ButtonHighlight;
            Ten.Location = new Point(469, 310);
            Ten.Name = "Ten";
            Ten.Size = new Size(100, 23);
            Ten.TabIndex = 27;
            // 
            // Cof_check
            // 
            Cof_check.AutoSize = true;
            Cof_check.Location = new Point(0, 24);
            Cof_check.Name = "Cof_check";
            Cof_check.Size = new Size(61, 19);
            Cof_check.TabIndex = 0;
            Cof_check.Text = "Coffee";
            Cof_check.UseVisualStyleBackColor = true;
            Cof_check.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(335, 22);
            button1.Name = "button1";
            button1.Size = new Size(76, 365);
            button1.TabIndex = 1;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CoffeePrice
            // 
            CoffeePrice.Enabled = false;
            CoffeePrice.Location = new Point(89, 22);
            CoffeePrice.Name = "CoffeePrice";
            CoffeePrice.Size = new Size(100, 23);
            CoffeePrice.TabIndex = 2;
            CoffeePrice.TextChanged += CoffeePrice_TextChanged;
            // 
            // HowManyCoffee
            // 
            HowManyCoffee.Enabled = false;
            HowManyCoffee.Location = new Point(195, 22);
            HowManyCoffee.Name = "HowManyCoffee";
            HowManyCoffee.Size = new Size(100, 23);
            HowManyCoffee.TabIndex = 3;
            // 
            // HowManyTea
            // 
            HowManyTea.Enabled = false;
            HowManyTea.Location = new Point(195, 51);
            HowManyTea.Name = "HowManyTea";
            HowManyTea.Size = new Size(100, 23);
            HowManyTea.TabIndex = 6;
            HowManyTea.TextChanged += textBox3_TextChanged;
            // 
            // TeaPrice
            // 
            TeaPrice.Enabled = false;
            TeaPrice.Location = new Point(89, 51);
            TeaPrice.Name = "TeaPrice";
            TeaPrice.Size = new Size(100, 23);
            TeaPrice.TabIndex = 5;
            // 
            // Tea_check
            // 
            Tea_check.AutoSize = true;
            Tea_check.Location = new Point(0, 53);
            Tea_check.Name = "Tea_check";
            Tea_check.Size = new Size(43, 19);
            Tea_check.TabIndex = 4;
            Tea_check.Text = "Tea";
            Tea_check.UseVisualStyleBackColor = true;
            Tea_check.CheckedChanged += Tea_check_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 26);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 8;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 54);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Cash";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 171);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 11;
            label3.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 143);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 10;
            label4.Text = "Change";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 282);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 15;
            label5.Text = "20";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 254);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 14;
            label6.Text = "50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(417, 225);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 13;
            label7.Text = "100";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 197);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 12;
            label8.Text = "500";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(417, 367);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 18;
            label9.Text = "1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(417, 339);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 17;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(417, 310);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 16;
            label11.Text = "10";
            // 
            // Cash
            // 
            Cash.Location = new Point(469, 55);
            Cash.Name = "Cash";
            Cash.Size = new Size(100, 23);
            Cash.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(575, 22);
            button2.Name = "button2";
            button2.Size = new Size(65, 63);
            button2.TabIndex = 30;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(117, 77);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 31;
            label12.Text = "ราคา";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(222, 77);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 32;
            label13.Text = "จำนวน";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(222, 80);
            label14.Name = "label14";
            label14.Size = new Size(37, 15);
            label14.TabIndex = 40;
            label14.Text = "จำนวน";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(117, 80);
            label15.Name = "label15";
            label15.Size = new Size(29, 15);
            label15.TabIndex = 39;
            label15.Text = "ราคา";
            // 
            // Burger_Amount
            // 
            Burger_Amount.Enabled = false;
            Burger_Amount.Location = new Point(195, 54);
            Burger_Amount.Name = "Burger_Amount";
            Burger_Amount.Size = new Size(100, 23);
            Burger_Amount.TabIndex = 38;
            // 
            // Burger_Price
            // 
            Burger_Price.Enabled = false;
            Burger_Price.Location = new Point(89, 54);
            Burger_Price.Name = "Burger_Price";
            Burger_Price.Size = new Size(100, 23);
            Burger_Price.TabIndex = 37;
            // 
            // Burger_Check
            // 
            Burger_Check.AutoSize = true;
            Burger_Check.Location = new Point(0, 56);
            Burger_Check.Name = "Burger_Check";
            Burger_Check.Size = new Size(61, 19);
            Burger_Check.TabIndex = 36;
            Burger_Check.Text = "Burger";
            Burger_Check.UseVisualStyleBackColor = true;
            Burger_Check.CheckedChanged += Burger_Check_CheckedChanged;
            // 
            // Pizza_Amount
            // 
            Pizza_Amount.Enabled = false;
            Pizza_Amount.Location = new Point(195, 25);
            Pizza_Amount.Name = "Pizza_Amount";
            Pizza_Amount.Size = new Size(100, 23);
            Pizza_Amount.TabIndex = 35;
            // 
            // Pizza_Price
            // 
            Pizza_Price.Enabled = false;
            Pizza_Price.Location = new Point(89, 25);
            Pizza_Price.Name = "Pizza_Price";
            Pizza_Price.Size = new Size(100, 23);
            Pizza_Price.TabIndex = 34;
            // 
            // Pizza_Check
            // 
            Pizza_Check.AutoSize = true;
            Pizza_Check.Location = new Point(0, 27);
            Pizza_Check.Name = "Pizza_Check";
            Pizza_Check.Size = new Size(52, 19);
            Pizza_Check.TabIndex = 33;
            Pizza_Check.Text = "Pizza";
            Pizza_Check.UseVisualStyleBackColor = true;
            Pizza_Check.CheckedChanged += Pizza_Check_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HowManyCoffee);
            groupBox1.Controls.Add(Cof_check);
            groupBox1.Controls.Add(CoffeePrice);
            groupBox1.Controls.Add(Tea_check);
            groupBox1.Controls.Add(TeaPrice);
            groupBox1.Controls.Add(HowManyTea);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(34, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 100);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Drink";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Pizza_Check);
            groupBox2.Controls.Add(Pizza_Price);
            groupBox2.Controls.Add(Pizza_Amount);
            groupBox2.Controls.Add(Burger_Check);
            groupBox2.Controls.Add(Burger_Price);
            groupBox2.Controls.Add(Burger_Amount);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(34, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 100);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(Discount_All);
            groupBox4.Controls.Add(Tb_DisAll);
            groupBox4.Controls.Add(Discount_Drink);
            groupBox4.Controls.Add(Tb_DisDrink);
            groupBox4.Controls.Add(Discount_Food);
            groupBox4.Controls.Add(Tb_DisFood);
            groupBox4.Controls.Add(label17);
            groupBox4.Location = new Point(34, 241);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(295, 171);
            groupBox4.TabIndex = 51;
            groupBox4.TabStop = false;
            groupBox4.Text = "Discount";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(195, 94);
            label18.Name = "label18";
            label18.Size = new Size(17, 15);
            label18.TabIndex = 44;
            label18.Text = "%";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(195, 60);
            label16.Name = "label16";
            label16.Size = new Size(17, 15);
            label16.TabIndex = 43;
            label16.Text = "%";
            // 
            // Discount_All
            // 
            Discount_All.AutoSize = true;
            Discount_All.Location = new Point(0, 85);
            Discount_All.Name = "Discount_All";
            Discount_All.Size = new Size(40, 19);
            Discount_All.TabIndex = 41;
            Discount_All.Text = "All";
            Discount_All.UseVisualStyleBackColor = true;
            Discount_All.CheckedChanged += Discount_All_CheckedChanged;
            // 
            // Tb_DisAll
            // 
            Tb_DisAll.Enabled = false;
            Tb_DisAll.Location = new Point(89, 83);
            Tb_DisAll.Name = "Tb_DisAll";
            Tb_DisAll.Size = new Size(100, 23);
            Tb_DisAll.TabIndex = 42;
            // 
            // Discount_Drink
            // 
            Discount_Drink.AutoSize = true;
            Discount_Drink.Location = new Point(0, 27);
            Discount_Drink.Name = "Discount_Drink";
            Discount_Drink.Size = new Size(54, 19);
            Discount_Drink.TabIndex = 33;
            Discount_Drink.Text = "Drink";
            Discount_Drink.UseVisualStyleBackColor = true;
            Discount_Drink.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // Tb_DisDrink
            // 
            Tb_DisDrink.Enabled = false;
            Tb_DisDrink.Location = new Point(89, 25);
            Tb_DisDrink.Name = "Tb_DisDrink";
            Tb_DisDrink.Size = new Size(100, 23);
            Tb_DisDrink.TabIndex = 34;
            // 
            // Discount_Food
            // 
            Discount_Food.AutoSize = true;
            Discount_Food.Location = new Point(0, 56);
            Discount_Food.Name = "Discount_Food";
            Discount_Food.Size = new Size(53, 19);
            Discount_Food.TabIndex = 36;
            Discount_Food.Text = "Food";
            Discount_Food.UseVisualStyleBackColor = true;
            Discount_Food.CheckedChanged += Discount_Food_CheckedChanged;
            // 
            // Tb_DisFood
            // 
            Tb_DisFood.Enabled = false;
            Tb_DisFood.Location = new Point(89, 54);
            Tb_DisFood.Name = "Tb_DisFood";
            Tb_DisFood.Size = new Size(100, 23);
            Tb_DisFood.TabIndex = 37;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(195, 28);
            label17.Name = "label17";
            label17.Size = new Size(17, 15);
            label17.TabIndex = 40;
            label17.Text = "%";
            label17.Click += label17_Click;
            // 
            // OneStang
            // 
            OneStang.BackColor = SystemColors.ButtonHighlight;
            OneStang.Location = new Point(621, 366);
            OneStang.Name = "OneStang";
            OneStang.Size = new Size(100, 23);
            OneStang.TabIndex = 56;
            OneStang.TextChanged += textBox1_TextChanged;
            // 
            // FiveStang
            // 
            FiveStang.BackColor = SystemColors.ButtonHighlight;
            FiveStang.Location = new Point(621, 337);
            FiveStang.Name = "FiveStang";
            FiveStang.Size = new Size(100, 23);
            FiveStang.TabIndex = 55;
            // 
            // TenStang
            // 
            TenStang.BackColor = SystemColors.ButtonHighlight;
            TenStang.Location = new Point(621, 312);
            TenStang.Name = "TenStang";
            TenStang.Size = new Size(100, 23);
            TenStang.TabIndex = 54;
            // 
            // TwentyFiveStang
            // 
            TwentyFiveStang.BackColor = SystemColors.ButtonHighlight;
            TwentyFiveStang.Location = new Point(621, 283);
            TwentyFiveStang.Name = "TwentyFiveStang";
            TwentyFiveStang.Size = new Size(100, 23);
            TwentyFiveStang.TabIndex = 53;
            // 
            // FiftyStang
            // 
            FiftyStang.BackColor = SystemColors.ButtonHighlight;
            FiftyStang.Location = new Point(621, 254);
            FiftyStang.Name = "FiftyStang";
            FiftyStang.Size = new Size(100, 23);
            FiftyStang.TabIndex = 52;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(587, 364);
            label19.Name = "label19";
            label19.Size = new Size(28, 15);
            label19.TabIndex = 57;
            label19.Text = "0.01";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(587, 340);
            label20.Name = "label20";
            label20.Size = new Size(28, 15);
            label20.TabIndex = 58;
            label20.Text = "0.05";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(587, 313);
            label21.Name = "label21";
            label21.Size = new Size(28, 15);
            label21.TabIndex = 61;
            label21.Text = "0.10";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(587, 286);
            label22.Name = "label22";
            label22.Size = new Size(28, 15);
            label22.TabIndex = 60;
            label22.Text = "0.25";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(587, 260);
            label23.Name = "label23";
            label23.Size = new Size(28, 15);
            label23.TabIndex = 59;
            label23.Text = "0.50";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(OneStang);
            Controls.Add(FiveStang);
            Controls.Add(TenStang);
            Controls.Add(TwentyFiveStang);
            Controls.Add(FiftyStang);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(One);
            Controls.Add(Five);
            Controls.Add(Ten);
            Controls.Add(Twenty);
            Controls.Add(Fifty);
            Controls.Add(OneHundred);
            Controls.Add(FiveHundred);
            Controls.Add(OneThousand);
            Controls.Add(Change);
            Controls.Add(Cash);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Total);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox Cof_check;
        private Button button1;
        private TextBox CoffeePrice;
        private TextBox HowManyCoffee;
        private TextBox HowManyTea;
        private TextBox TeaPrice;
        private CheckBox Tea_check;
        private TextBox Total;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox Cash;
        private TextBox OneThousand;
        private TextBox Change;
        private TextBox Twenty;
        private TextBox Fifty;
        private TextBox OneHundred;
        private TextBox FiveHundred;
        private TextBox One;
        private TextBox Five;
        private TextBox Ten;
        private Button button2;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox Burger_Amount;
        private TextBox Burger_Price;
        private CheckBox Burger_Check;
        private TextBox Pizza_Amount;
        private TextBox Pizza_Price;
        private CheckBox Pizza_Check;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private CheckBox Discount_Drink;
        private TextBox Tb_DisDrink;
        private CheckBox Discount_Food;
        private TextBox Tb_DisFood;
        private Label label17;
        private CheckBox Discount_All;
        private TextBox Tb_DisAll;
        private Label label18;
        private Label label16;
        private TextBox OneStang;
        private TextBox FiveStang;
        private TextBox TenStang;
        private TextBox TwentyFiveStang;
        private TextBox FiftyStang;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
    }
}
