using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManaging
{
    class Account
    {
        private string ID;
        private string Name;
        private string LastName;
        private double Balance;

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string LastName1
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public Double Balance1
        {
            get
            {
                return Balance;
            }

            set
            {
                Balance = value;
            }
        }

        public Account()
        {
            ID = "000";
            Name = "Minh Tri";
            LastName = "Tran";
            Balance = 18.2000;
        }
        public Account(string id, string stName, string lsName, double balance)
        {
            this.ID = id;
            this.Name = stName;
            this.LastName = lsName;
            this.Balance = balance;
        }
        public void input()
        {
            Console.Write("ID: ");
            ID = Console.ReadLine();
            Console.Write("Frist Name: ");
            Name = Console.ReadLine();
            Console.Write("Last Name: ");
            LastName= Console.ReadLine();
            Console.Write("Balance: ");
            Balance = double.Parse(Console.ReadLine());

        }
    }
}
