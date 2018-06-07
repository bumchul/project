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
    public partial class Form4 : Form
    {
        public static int priceSum;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string golden_egg =  "골든 에그 치즈버거";
            int golden_egg_price = 8100;

            choose_menu.Text = choose_menu.Text + "\n" + golden_egg + "는         " + golden_egg_price.ToString() + "원";


            priceSum = priceSum + golden_egg_price;

            last_price.Text = priceSum.ToString();
        
            Menu_list check = new Menu_list();
            check.Menu_name(golden_egg).ToString();
            check.Menu_price(golden_egg_price);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hash_brown = "1955 해쉬 브라운";
            int hash_brown_price = 8400;

            choose_menu.Text = choose_menu.Text + "\n" + hash_brown + "는         " + hash_brown_price.ToString() + "원";


            priceSum= priceSum + hash_brown_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(hash_brown).ToString();
            check.Menu_price(hash_brown_price);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bigmak = "빅 맥";
            int bigmak_price = 6400;

            choose_menu.Text = choose_menu.Text + "\n" + bigmak + "는                           " + bigmak_price.ToString() + "원";


            priceSum = priceSum+ bigmak_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(bigmak).ToString();
            check.Menu_price(bigmak_price);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string shanghai = "상하이 버거";
            int shanghai_price = 6400;

            choose_menu.Text = choose_menu.Text + "\n" + shanghai + "는                  " + shanghai_price.ToString() + "원";


            priceSum = priceSum + shanghai_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(shanghai).ToString();
            check.Menu_price(shanghai_price);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Tomato_Deluxe = "베이컨 토마토 디럭스";
            int Tomato_Deluxe_price = 7600;

            choose_menu.Text = choose_menu.Text + "\n" + Tomato_Deluxe + "는      " + Tomato_Deluxe_price.ToString() + "원";


            priceSum = priceSum + Tomato_Deluxe_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(Tomato_Deluxe).ToString();
            check.Menu_price(Tomato_Deluxe_price);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string shrimp = "슈비 버거";
            int shrimp_price = 7800;

            choose_menu.Text = choose_menu.Text + "\n" + shrimp + "는                      " + shrimp_price.ToString() + "원";


            priceSum = priceSum + shrimp_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(shrimp).ToString();
            check.Menu_price(shrimp_price);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string double_bulgogi = "더블 불고기 버거";
            int double_bulgogi_price = 6400;

            choose_menu.Text = choose_menu.Text + "\n" + double_bulgogi + "는            " + double_bulgogi_price.ToString() + "원";


            priceSum = priceSum + double_bulgogi_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(double_bulgogi).ToString();
            check.Menu_price(double_bulgogi_price);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string bulgogi = "불고기 버거";
            int bulgogi_price = 5400;

            choose_menu.Text = choose_menu.Text + "\n" + bulgogi + "는                  " + bulgogi_price.ToString() + "원";


            priceSum = priceSum + bulgogi_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(bulgogi).ToString();
            check.Menu_price(bulgogi_price);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string cheeze = "치즈 버거";
            int cheeze_price = 6400;

            choose_menu.Text = choose_menu.Text + "\n" + cheeze + "는                     " + cheeze_price.ToString() + "원";


            priceSum = priceSum + cheeze_price;

            last_price.Text = priceSum.ToString();

            Menu_list check = new Menu_list();
            check.Menu_name(cheeze).ToString();
            check.Menu_price(cheeze_price);
        }

        private void choose_menu_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog(this);
        }
    }
}
