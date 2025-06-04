using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Item
    {
        private static int count;
        public readonly int id;
        public string name;
        public int price;

        public Item( string name, int price)
        {
            int id = count++;
            this.name = name;
            this.price = price;
        }
    }
}
