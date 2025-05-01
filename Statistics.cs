using System;

namespace DungeonExplorer_Simplified
{
    public class Statistics
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }

        public Statistics(int health, int strength, int defense)
        {
            Health = health;
            Strength = strength;
            Defense = defense;
        }
    }
}
