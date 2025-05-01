using System; // Add the necessary 'using' directive

using DungeonExplorer_Simplified;

namespace DungeonExplorer_Simplified
{
    public class Goblin : Monster
    {
        public Goblin() : base("Goblin", 50, 5) { }
        
        public override void Attack(Creature target)
        {
            Console.WriteLine("Goblin uses quick strike!");
            base.Attack(target);
        }
    }

    public class Dragon : Monster
    {
        public Dragon() : base("Dragon", 150, 30) { }
        
        public override void Attack(Creature target)
        {
            Console.WriteLine("Dragon breathes fire!");
            base.Attack(target);
        }
    }
}
