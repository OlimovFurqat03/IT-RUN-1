using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Book
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"Title: {Title} \n Authors: {Authors} \n Genre: {Genre}";
        }
    }
}
