using System;
using DungeonExplorer_Simplified;  // Add the necessary 'using' directive
using System.Diagnostics;

namespace DungeonExplorer_Simplified
{
    public static class Testing
    {
        public static void RunTests()
        {
            // Run various tests on game features
            Debug.Assert(Game.TestRoomConnectivity(), "Room connectivity failed!");
            Debug.Assert(Game.TestMonsterAttributes(), "Monster attributes failed!");
        }
    }
}
