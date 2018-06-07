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
    public partial class Form5 : Form
    {
        public static int priceSum;
        

        public Form5()
        {
            InitializeComponent();
            
            //Menu_list buy_menu = new Menu_list();           
            //buy_menu.choose_menu();

            bag.Text = (Form2.priceSum + Form4.priceSum) +"입니다!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog(this);
        }
    }
}
