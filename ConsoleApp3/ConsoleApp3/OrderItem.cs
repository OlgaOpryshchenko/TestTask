using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class OrderItem
    {
        public List<IPrice> Items { get; set; } = new List<IPrice>();

        public int calculatePrice() {
            return Items.Sum(orderItem => orderItem.getPrice());
        }
    }
}
