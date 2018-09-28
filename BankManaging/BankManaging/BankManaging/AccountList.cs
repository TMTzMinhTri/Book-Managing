using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManaging
{
    class AccountList
    {
        public void SaveFile()
        {
            Console.WriteLine("Input file name to save: ");
            string FileName = Console.ReadLine();
            try
            {

            }
            catch (IOExeption e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
