using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form2 : Form
    {
        //Form5 form5 = new Form5();

        public static int priceSum =0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string coke_zero = "코카콜라제로";
            int coke_zero_price = 1600;


            choose_menu.Text = choose_menu.Text + "\n" + coke_zero + "는        " + coke_zero_price.ToString() + "원";

            //form5.bag.Text = choose_menu.ToString();

            priceSum = priceSum + coke_zero_price;

            last_price.Text = priceSum.ToString();


            Menu_list check = new Menu_list();
            check.Menu_name(coke_zero).ToString();
            check.Menu_price(coke_zero_price);

           //choose_menu.Text = 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string coke = "코카콜라";
            int coke_price = 1600;

            choose_menu.Text =  choose_menu.Text+"\n" + coke + "는              "+ coke_price.ToString() + "원" ;
            

            priceSum = priceSum + coke_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(coke).ToString();
            check.Menu_price(coke_price);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fanta = "환타";
            int fanta_price = 1600;

            choose_menu.Text = choose_menu.Text + "\n" + fanta + "는                    " + fanta_price.ToString() + "원";


            priceSum = priceSum + fanta_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(fanta).ToString();
            check.Menu_price(fanta_price);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string milkiss = "밀키스";
            int milkiss_price = 1600;

            choose_menu.Text = choose_menu.Text + "\n" + milkiss + "는                 " + milkiss_price.ToString() + "원";


            priceSum = priceSum + milkiss_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(milkiss).ToString();
            check.Menu_price(milkiss_price);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sprite = "스프라이트";
            int sprite_price = 1600;

            choose_menu.Text = choose_menu.Text + "\n" + sprite + "는           " + sprite_price.ToString() + "원";


            priceSum = priceSum + sprite_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(sprite).ToString();
            check.Menu_price(sprite_price);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string banana_shake = "바나나 쉐이크";
            int banana_shake_price = 3100;

            choose_menu.Text = choose_menu.Text + "\n" + banana_shake + "는       " + banana_shake_price.ToString() + "원";


            priceSum = priceSum + banana_shake_price;
            
            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(banana_shake).ToString();
            check.Menu_price(banana_shake_price);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strawberry_shake = "딸기 쉐이크";
            int strawberry_shake_price = 3100;

            choose_menu.Text = choose_menu.Text + "\n" + strawberry_shake + "는          " + strawberry_shake_price.ToString() + "원";


            priceSum = priceSum + strawberry_shake_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(strawberry_shake).ToString();
            check.Menu_price(strawberry_shake_price);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string chcolate_shake = "초코 쉐이크";
            int chcolate_shake_price = 3100;

            choose_menu.Text = choose_menu.Text + "\n" + chcolate_shake + "는          " + chcolate_shake_price.ToString() + "원";


            priceSum = priceSum + chcolate_shake_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(chcolate_shake).ToString();
            check.Menu_price(chcolate_shake_price);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string orange_juice = "오렌지 쥬스";
            int orange_juice_price = 3100;

            choose_menu.Text = choose_menu.Text + "\n" + orange_juice + "는          " + orange_juice_price.ToString() + "원";


            priceSum = priceSum + orange_juice_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(orange_juice).ToString();
            check.Menu_price(orange_juice_price);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog(this);
        }
    }
}
