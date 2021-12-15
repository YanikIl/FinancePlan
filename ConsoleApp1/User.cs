using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public List<Card> Cards = new();
        public string Login;
        public string PassWord;

        public User(string login, string password)
        {
            Login = login;
            PassWord = password;
        }

    }
}
