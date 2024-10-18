using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Item: IPrice
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int getPrice()
        {
           return Price;
        }
    }
}
