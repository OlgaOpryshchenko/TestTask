using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Order
    {
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();

        public int getTotalprice() {
            return Orders.Sum(order => order.calculatePrice());
        }
    }
}
