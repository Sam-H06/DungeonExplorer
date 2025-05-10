using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Inventory
    //class to mange more than 1 item objects
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        //methord that addes item to invantory
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} is added to inventory!");
        }

        public List<Item> GetWeapons()
        // use LINQ to get all weapons in inventory

        {
            return items.Where(item => item is Weapon).ToList();
        }

        public List<Item> GetPotions()
        //LINQ and Lambda used to return all potion items
        {
            return items.Where(item => item is Potion).ToList();
            // filters and returns items that are potions

        }

        public void ShowInventory()
        // displays the names of all items in the inventory

        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
