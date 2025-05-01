using System; // Add the necessary 'using' directive

namespace DungeonExplorer_Simplified
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Item(string name, string type)
        {
            Name = name;
            Type = type;
        }
        
        public virtual void Use()
        {
            Console.WriteLine($"{Name} used!");
        }
    }

    public class Weapon : Item
    {
        public Weapon(string name) : base(name, "Weapon") { }

        public override void Use()
        {
            Console.WriteLine($"Swinging the {Name}!");
        }
    }

    public class Potion : Item
    {
        public Potion(string name) : base(name, "Potion") { }

        public override void Use()
        {
            Console.WriteLine($"Drinking the {Name} potion!");
        }
    }
}
