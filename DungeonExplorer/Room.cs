using System;

namespace DungeonExplorer_Simplified
{
    public class Room
    {
        public string Description { get; set; }
        public Monster Monster { get; set; }
        public Item Item { get; set; }

        // Constructor to accept either an Item or a Monster (not both at the same time)
        public Room(string description, Item item = null, Monster monster = null)
        {
            Description = description;
            Item = item;
            Monster = monster;
        }

        public void Connect(Room room)
        {
            Console.WriteLine($"Connected to {room.Description}.");
        }
    }
}
