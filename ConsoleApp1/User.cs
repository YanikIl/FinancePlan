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
        public string Name;
        public string Login;

        public User(string name, string login)
        {
            Name = name;
            Login = login;
        }

    }
}
