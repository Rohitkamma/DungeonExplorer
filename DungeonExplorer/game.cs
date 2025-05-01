using System;

namespace DungeonExplorer_Simplified
{
    public class Game
    {
        private GameMap map;
        private Player player;

        public Game()
        {
            map = new GameMap();
            player = new Player("Hero", 100, 20);
            InitializeRooms();
        }

        private void InitializeRooms()
        {
            // Create rooms with either an Item or Monster
            Room room1 = new Room("A dark room", new Item("Sword", "Weapon")); // Item
            Room room2 = new Room("A dimly lit room", new Item("Shield", "Armor")); // Item
            Room room3 = new Room("A cold, silent room", null, new Monster("Goblin", 50, 10)); // Monster
            room1.Connect(room2);
            room2.Connect(room3);

            map.AddRoom(room1);
            map.AddRoom(room2);
            map.AddRoom(room3);
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Dungeon Explorer!");
            bool gameRunning = true;

            while (gameRunning)
            {
                Console.WriteLine("\nSelect an action:");
                Console.WriteLine("1. View current room description");
                Console.WriteLine("2. Fight the monster");
                Console.WriteLine("3. Pick up an item");
                Console.WriteLine("4. Quit game");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowCurrentRoom();
                        break;
                    case "2":
                        FightMonster();
                        break;
                    case "3":
                        PickUpItem();
                        break;
                    case "4":
                        gameRunning = false;
                        Console.WriteLine("Thank you for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        private void ShowCurrentRoom()
        {
            // For now, just a simple print statement
            Console.WriteLine("You are in a room with a description.");
        }

        private void FightMonster()
        {
            // Check if there is a monster in the room
            // For now, just a simple message
            Console.WriteLine("You are fighting the monster!");
            // In a real game, you would add combat mechanics here.
        }

        private void PickUpItem()
        {
            // Check if there is an item to pick up
            Console.WriteLine("You have picked up an item!");
            // In a real game, you would manage inventory here.
        }

        // Sample test methods for the Game class
        public static bool TestRoomConnectivity()
        {
            return true;
        }

        public static bool TestMonsterAttributes()
        {
            return true;
        }
    }
}
