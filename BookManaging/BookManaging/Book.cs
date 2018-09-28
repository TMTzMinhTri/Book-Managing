using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    class Book
    {
        #region Định nghĩa dữ liệu
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;
        //luu tru mang chua ten chuong
        private ArrayList chapter = new ArrayList();
        #endregion

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                {
                    chapter[index] = value;
                }
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }


        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Author
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Publisher
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string ISBN
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Year
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Show()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0}: {1}", i + 1, chapter);
            Console.WriteLine("------------------------");
        }
        public void input()
        {
            Console.WriteLine("title: ");
            title = Console.ReadLine();
            Console.WriteLine("Author: ");
            author = Console.ReadLine();
            Console.WriteLine("Publisher: ");
            publisher = Console.ReadLine();
            Console.WriteLine("ISBN: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input chapter(finished with empty string");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);
        }
    }
}

