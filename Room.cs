using System;

namespace DungeonExplorer
{
    // Represents a room in the dungeon with a description
    internal class Room
    {
        //private field to store the rooms description
        private string description;
        
        //constructor to itialize the room with a description
        public Room(string description)
        {
            this.description = description;
        }
        //method to retrieve the rooms descripiton
        public string GetDescription()
        {
            return description;
        }
    }
}
