using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    class Menu_list
    {
        //public static int priceSum;
        static public string menu_name;
        public int price = 0;


       
       /*public Menu_list(string menu_name,int price)
        {
            this.menu_name = menu_name;
            this.price = price;


        }
        */
        public List<string> Menu_name(string menu_name)
        {
            List<string> input_name = new List<string>();

            input_name.Add(menu_name);
            //foreach(var item in input_name)
            //{
            //   Console.Write(menu_name);
            //}
            return input_name;
        }

        public List<int> Menu_price(int price)
        {
            List<int> input_price = new List<int>();

            input_price.Add(price);

            //foreach (var item in input_price)
            //{
            //    Console.Write("         " + price +"입니다.");
            //}
            return input_price;
        }

        public void choose_menu()
        {
            string pick_menu;


            List<string> input_name = new List<string>();
            pick_menu = input_name.ToString();

            foreach(var item in pick_menu)
            {
                Console.WriteLine(pick_menu);
            }

           // Console.Write(priceSum);
        }




        /*        public void checking()
      {

          public List<string> list = new List<string>();

          foreach(var item in list)

          {
              Console.WriteLine(menu_name + "는" + price + "원  입니다.");
          }
      }
          */

    }
}
