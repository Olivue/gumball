using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gumball
{
    class GumballMachine
    {
        private int gumballs;
        private int price;
        private int coins;

        public int Price
        {
            get
            {
                return price;
            }
        }
        public GumballMachine(int gumballs, int price, int coines)
        {
            this.gumballs = gumballs;
            this.price = price;
            coins = coines;
        }
        public string DispenseOneGumball(int price, int coinsInserted)
        {
            if (coinsInserted >= price)
            { // проверка поля
                gumballs -= 1;
                return "Вот ваша жевательная резинка";
                //MessageBox.Show("Вот ваша жевательная резинка");
            }
            else
            {
                return "Сумма недостаточна";
                //MessageBox.Show("Сумма недостаточна");
            }
        }
    }
}
