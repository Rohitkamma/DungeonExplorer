using System;
using System.Collections.Generic;

namespace DungeonExplorer_Simplified
{
    public class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            if (items.Count < 10) // Limit to 10 items
                items.Add(item);
            else
                Console.WriteLine("Inventory full.");
        }

        public void RemoveItem(Item item)
        {
            if (items.Contains(item))
                items.Remove(item);
            else
                Console.WriteLine("Item not found in inventory.");
        }

        public void ViewInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Type}");
            }
        }
    }
}
