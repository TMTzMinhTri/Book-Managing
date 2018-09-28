using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    interface IBook
    {
        string this[int index] //index sach
        {
            get;
            set;
        }
        string title // ten sach
        {
            get;
            set;
        }
        string author // tac gia
        {
            get;
            set;
        }
        string publisher// Nha xuat ban
        {
            get;
            set;
        }
        string ISBN
        {
            get;
            set;
        }
        int year
        {
            get;
            set;
        }
        void Show();
    }
}
