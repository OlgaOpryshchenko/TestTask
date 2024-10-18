using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Order
    {
        public List<OrderItem> OrderItems { get; set; }

        public int getTotalPrice() { 
            return OrderItems.Sum(x => x.returnPrice());

        }
    }
}
