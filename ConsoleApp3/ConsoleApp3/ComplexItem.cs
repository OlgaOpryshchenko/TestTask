using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ComplexItem: IPrice
    {
        public List<Item> ComplexItems { get; set; }

        public int getPrice()
        {
            return ComplexItems.Sum(x => x.Price);
        }
    }
}
