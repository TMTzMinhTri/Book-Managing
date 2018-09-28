using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList b1 = new BookList();
            b1.InputList();
            b1.showList();
            Console.ReadLine();
        }
    }
}
