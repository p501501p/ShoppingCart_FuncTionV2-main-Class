using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Security.Policy;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Item1 itemCoffee = new Item1();
        Item1 itemTea = new Item1();
        Item1 itemPizza = new Item1();
        Item1 itemburger = new Item1();

        public Form1()
        {

            InitializeComponent();

        }
        public static double Item(Item1 item1,Item1 item2)
        {
            

            string inCofprice = item1.price;
            string inamount = item1.quantity;
            string inTeaprice = item2.price;
            string inTeaAmount = item2.quantity;

            int Cofprice = 0;
            int amount = 0;
            int teaAmount = 0;
            int teaprice = 0;

            try
            {
                if (item1.isCheck)
                    Cofprice = int.Parse(inCofprice);
                amount = int.Parse(inamount);

            }
            catch (FormatException) {
                Console.WriteLine("รูปแบบข้อมูลไม่ถูกต้อง:");

            }
            try
            {
                if (item2.isCheck)
                    teaprice = int.Parse(inTeaprice);
                teaAmount = int.Parse(inTeaAmount);
            }
            catch (FormatException)
            {
             
            }
            Console.WriteLine(Cofprice);
            double sum1 = Cofprice * amount;
            double sum2 = teaprice * teaAmount;
            double sum = sum1 + sum2;
            return sum;
        }
        public double DiscountAll(double Drink, double Food)
        {
            double sum1 = 0;
            if (Discount_All.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = int.Parse(Tb_DisAll.Text);
                    double all = Drink + Food;
                    all = all - (all * discountvalue / 100);
                    sum1 += all;

                }
                catch (FormatException)
                {
                    double all = Drink + Food;
                    sum1 += all;
                }


            }
            return sum1;
        }
        public double DiscountDrink(double Drink)
        {
            if (Discount_Drink.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = int.Parse(Tb_DisDrink.Text);
                    Drink = Drink - (Drink * discountvalue / 100);

                }
                catch (FormatException)
                { Drink = Drink - (Drink * discountvalue / 100); }

            }
            return Drink;
        }
        public double DiscountFood(double Food)
        {
            if (Discount_Food.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = int.Parse(Tb_DisFood.Text);
                    Food = Food - (Food * discountvalue / 100);

                }
                catch (FormatException)
                {
                    Food = Food - (Food * discountvalue / 100);

                }
            }

            return Food;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Cof_check.Checked == false)
            {
                CoffeePrice.Enabled = false;
                HowManyCoffee.Enabled = false;
            }
            if (Cof_check.Checked == true)
            {
                CoffeePrice.Enabled = true;
                HowManyCoffee.Enabled = true;
            }

        }

        private void CoffeePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemCoffee.name = "Coffee";
            itemCoffee.price = CoffeePrice.Text;

            itemCoffee.quantity = HowManyCoffee.Text;
            itemCoffee.isCheck = Cof_check.Checked;




            itemTea.price = TeaPrice.Text;
            itemTea.quantity = HowManyCoffee.Text;
            itemTea.isCheck = Tea_check.Checked;

            itemPizza.price = Pizza_Price.Text;
            itemPizza.quantity = Pizza_Amount.Text;
            itemPizza.isCheck = Pizza_Check.Checked;

            itemburger.price = Burger_Price.Text;
            itemburger.quantity = Burger_Amount.Text;
            itemburger.isCheck = Burger_Check.Checked;
            DrinkFood drink = new DrinkFood();
            drink.Sum = Item(itemCoffee, itemTea);
            Double Drink = drink.Sum;
            DrinkFood food = new DrinkFood();
            food.Sum = Item(itemPizza, itemburger);
            Double Food = food.Sum;
            discount Discount = new discount();
           


            if (Discount_All.Checked)
            {
                Discount.discountSum += DiscountAll(Drink, Food);

            }
            else if (Discount_Drink.Checked)
            {
                Drink = DiscountDrink(Drink);
                Discount.discountSum += Drink + Food;

            }

            else if (Discount_Food.Checked)
            {
                Food = DiscountFood(Food);
                Discount.discountSum += Food + Drink;



            }
            else
            {
                Discount.discountSum += Drink + Food;
            }
            Total.Text = Discount.discountSum.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = 0;
            double cash = 0;
            try
            {

                cash = double.Parse(Cash.Text);

            }
            catch (FormatException) { }

            try
            {
                total = double.Parse(Total.Text);
            }
            catch (FormatException) { }
            double change = cash - total;
            Change.Text = change.ToString();

            double OneT = 0;
            double FiveH = 0;
            double oneH = 0;
            double fifty = 0;
            double twenty = 0;
            double ten = 0;
            double five = 0;
            double one = 0;
            double fiftystang = 0;
            double twentyfivestang = 0;
            double tenstang = 0;
            double fivestang = 0;
            double onestang = 0;
            while (change >= 0.01)
            {
                if (change >= 1000)
                {
                    change -= 1000;
                    OneT++;
                }
               else if (change >= 500)
                {
                    change -= 500;
                    FiveH++;
                }
                else if (change >= 100)
                {
                    change -= 100;
                    oneH++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    fifty++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    twenty++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    ten++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    five++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    one++;
                }
                else if (change >= 0.50)
                {
                    change -= 0.50;
                    fiftystang++;
                }
                else if (change >= 0.25)
                {
                    change -= 0.25;
                    twentyfivestang++;
                }
                else if (change >= 0.10)
                {
                    change -= 0.10;
                    tenstang++;
                }
                else if (change >= 0.05)
                {
                    change -= 0.05;
                    fivestang++;
             
                }
                else if (change >= 0.01)
                {
                    change -= 0.01;
                    onestang++;
                }
            }
            OneThousand.Text = OneT.ToString();
            FiveHundred.Text = FiveH.ToString();
            OneHundred.Text = oneH.ToString();
            Fifty.Text = fifty.ToString();
            Twenty.Text = twenty.ToString();
            Ten.Text = ten.ToString();
            Five.Text = five.ToString();
            One.Text = one.ToString();
            FiftyStang.Text = fiftystang.ToString();
            TwentyFiveStang.Text = twentyfivestang.ToString();
            TenStang.Text = tenstang.ToString();
            FiveStang.Text = fivestang.ToString();
            OneStang.Text = onestang.ToString();


        }

        private void Tea_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Tea_check.Checked == true)
            {
                TeaPrice.Enabled = true;
                HowManyTea.Enabled = true;
            }
            if (Tea_check.Checked == false)
            {
                TeaPrice.Enabled = false;
                HowManyTea.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Discount_Drink.Checked)
            {
                Discount_All.Checked = false;
                Discount_Food.Checked = false;
                Tb_DisDrink.Enabled = true;
            }
            else
            {
                Tb_DisDrink.Enabled = false;
            }
        }

        private void Discount_Food_CheckedChanged(object sender, EventArgs e)
        {
            if (Discount_Food.Checked)
            {
                Discount_All.Checked = false;
                Discount_Drink.Checked = false;
                Tb_DisFood.Enabled = true;
            }
            else
            {
                Tb_DisFood.Enabled = false;
            }
        }

        private void Discount_All_CheckedChanged(object sender, EventArgs e)
        {
            if (Discount_All.Checked)
            {
                Discount_Drink.Checked = false;
                Discount_Food.Checked = false;
                Discount_All.Checked = true;
                Tb_DisAll.Enabled = true;
            }
            else
            {
                Tb_DisAll.Enabled = false;
            }

        }


        private void Pizza_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Pizza_Check.Checked)
            {
                Pizza_Price.Enabled = true;
                Pizza_Amount.Enabled = true;
            }
            else
            {
                Pizza_Price.Enabled = false;
                Pizza_Amount.Enabled = false;
            }

        }

        private void Burger_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Burger_Check.Checked == true)
            {
                Burger_Price.Enabled = true;
                Burger_Amount.Enabled = true;
            }
            else
            {
                Burger_Price.Enabled = false;
                Burger_Amount.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

