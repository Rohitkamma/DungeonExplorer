using System;
using System.Collections.Generic;
using DungeonExplorer_Simplified;

namespace DungeonExplorer_Simplified
{
    public class GameMap
    {
        public List<Room> Rooms { get; private set; }

        public GameMap()
        {
            Rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public Room GetRoom(int index)
        {
            if (index < Rooms.Count)
                return Rooms[index];
            return null;
        }
    }
}
