using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    class BookList
    {
        private ArrayList list = new ArrayList();
        public void AddBook()
        {
            Book b = new Book();
            b.input();
            list.Add(b);
        }

        internal void showList()
        {
            throw new NotImplementedException();
        }

        public void ShowList()
        {
            foreach (Book b in list)
            {
                b.Show();
            }
        }
        public void InputList()
        {
            int n;
            Console.WriteLine("amount of books: ");
            n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                while (n>0)
                {
                    AddBook();
                    n--;
                }
            }
        }
    }
}
