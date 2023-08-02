using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public static class ShoppingCart
    {
        public static Dictionary<string, int> Items { get; set; }

        public static void AddItem(string name, int quantity)
        {
            Items.Add(name, quantity);
        }

        public static void RemoveItem(string name)
        {
            Items.Remove(name);
        }
    }
}
