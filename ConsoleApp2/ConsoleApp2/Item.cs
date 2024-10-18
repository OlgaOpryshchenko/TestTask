using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public virtual  int returnPrice() {
            if (Items.Any())
            {
                return Items.Sum(x => x.returnPrice());
            }
            else {
                return Price;
            }
        }
    }
}
