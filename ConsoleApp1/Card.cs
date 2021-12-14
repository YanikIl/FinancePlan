using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Card
    {
        public int Balance { get; set; }
        public string Name { get; set; }
        public int Transactions { get; set; }

        public Card(int balance, string name)
        {
            Balance = balance;
            Name = name;
        }

        public void ChangeBalanceMinus(int money)
        {
            Balance -= money;
            Transactions += money;
        }

        public void ChangeBalancePlus(int money)
        {
            Balance += money;
            Transactions += money;
        }
    }
}
