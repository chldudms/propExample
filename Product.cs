using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PropExample32
{
    class Product
    {
        public string name;
        public int price;
        static Product product;

        static Product()
        {
            product = null;
            Console.WriteLine("정적 생성자 호출");
        }

        private Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public static Product GetInstance(string name, int price)
        {
            if (product == null)
            {
                product = new Product(name, price);
            }
            return product;
        }

        ~Product()
        {
            Console.WriteLine("소멸자 호출");
        }
    }

}