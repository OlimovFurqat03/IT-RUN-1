using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Product
    {
        private Product()
        {

        }

        private Product(int count, string name)
        {
            Count = count;
            Name = name;
        }

        public static Product CreateNewProduct(int count, string name)
        {
            if (count < 0)
            {
                count = 0;
            }
            return new Product(count, name);
        }

        string name;
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    return "такое названия не сушествуеть";
                }
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }
        public int Count { get; private set; }

        public void Save()
        {

        }

        public void IncreaseCount(int count)
        {
            if (count > 0)
            {
                Count += count;
            }
        }

        public int MyProperty { get; set; }
    }
}
