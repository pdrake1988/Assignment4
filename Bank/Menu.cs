using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Menu
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public static List<Menu> Dishes = new List<Menu>();
        public static void AddDish(Menu menu)
        {
            Dishes.Add(menu);
        }
        public static void DisplayMenu()
        {
            foreach (Menu dish in Dishes)
            {
                Console.WriteLine(dish.Name);
            }
        }
    }
}
