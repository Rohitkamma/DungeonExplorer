using System;
using DungeonExplorer_Simplified;  // Add the necessary 'using' directive

namespace DungeonExplorer_Simplified
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); // Ensure Game class is available
            game.Start();
        }
    }
}
