using System;

namespace DungeonExplorer
{
    internal class Player
    {
        private string name;
        private int health;
        private string inventoryItem; // Stores the item the player is carrying

        public Player(string name, int health)
        {
            this.name = name;
            this.health = health;
            this.inventoryItem = null; // no item at start
        }

        public string Name
        {
            get { return name; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; } // allows modifying health like taking damage 
        }

        public string InventoryItem
        {
            get { return inventoryItem; }
        }
         // assigns an item to the players inventory
        public void PickUpItem(string item)
        {
            inventoryItem = item;
        }

        // Displays the player's current status, including name, health, and inventory
        public void DisplayStatus()
        {
            Console.WriteLine($"Player: {name}, Health: {health}, Inventory: {inventoryItem ?? "Empty"}");
        }
    }
}
