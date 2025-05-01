
using System;

namespace DungeonExplorer_Simplified
{
    public abstract class Creature : IDamageable
    {
        private string name;
        private int health;
        private int strength;

        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Strength { get => strength; set => strength = value; }

        public Creature(string name, int health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }

        public abstract void Attack(Creature target);

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }

    public class Player : Creature
    {
        public Player(string name, int health, int strength) : base(name, health, strength) { }
        
        public override void Attack(Creature target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with strength {Strength}.");
            target.TakeDamage(Strength);
        }
    }

    public class Monster : Creature
    {
        public Monster(string name, int health, int strength) : base(name, health, strength) { }
        
        public override void Attack(Creature target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with strength {Strength}.");
            target.TakeDamage(Strength);
        }
    }
}
