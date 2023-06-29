using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace Task_2
{
    public class Book_Reader : User
    {
        public List<Book> Favorite_Books { get; set; }
    }
}
