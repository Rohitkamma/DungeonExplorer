using System;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            // Initialize the game with one room and one player
            player = new Player("Hero", 100);// Represents the player in the game
            currentRoom = new Room("You are in a dark cave. There is a faint light to the north.");// Tracks the player's current location
        }

        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Display the description of the current room
                Console.WriteLine(currentRoom.GetDescription());
                Console.WriteLine("What would you like to do? (type 'exit' to quit)");
                string input = Console.ReadLine();
        
                // Handle player commands
                if (input.ToLower() == "exit")
                {
                    playing = false; // Ends the game loop
                }
                else if (input.ToLower() == "pickup")
                {
                    player.PickUpItem("Mysterious Artifact");// Adds an item to the player's inventory
                    Console.WriteLine("You picked up a Mysterious Artifact.");
                }
                else if (input.ToLower() == "status")
                {
                    player.DisplayStatus();// Displays the player's current status
                }
                else
                {
                    Console.WriteLine("Invalid command. Try again.");// Handles unrecognized commands
                }
            }
        }
    }
}
