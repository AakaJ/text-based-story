using System;

namespace textbasedstory
{
    internal class Sword
    {
        public int damage = 0;
        public int maxDamage = 100;
        public int swordLevel = 1;
        public int maxSwordLevel = 100;

        public Player player = new Player();

        public void RepairSword()
        {
            if (damage >= 100 && player.dabloons == 100) 
            {
                damage = 0;
                player.dabloons -= 100;
            }
        }
    }

    class Player
    {
        public int health = 100;
        public int maxHealth = 100;
        public int level = 1;
        public int maxLevel = 100;
        public int dabloons = 0;
        public Sword sword = new Sword();
    }


    internal class Program
    {
        static string input = "";
        static Player player = new Player(); // <--- new instance

        static void Main(string[] args)
        {
            Console.WriteLine("Create your story!");
            Console.Write("Enter the title of your story: ");
            string title = Console.ReadLine();
            Console.Title = title;
            Console.WriteLine("Set title to: " + title);
            Console.WriteLine("You are new in the world");

            StartStory();
        }

        static void StartStory()
        {
            while(input != "exit")
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Read");
                Console.WriteLine("2. Explore");
                Console.WriteLine("3. Fight Monsters");
                Console.Write("Input: ");
                input = Console.ReadLine();

                if (input == "3")
                {
                    fightMonsters();
                }
            }
        }

        static void fightMonsters()
        {
            if (player.sword.damage >= player.sword.maxDamage)
            {
                Console.WriteLine("Repair your sword first");
                Console.WriteLine("Tips: Explore a bit");
            }
            bool battleInProgress = true;
            Console.WriteLine("After a long search you found a monster");
            while (battleInProgress == true)
            { 
                Console.WriteLine("Current HP: " + player.health); // use instance + semicolon
                Console.WriteLine("Choose your action: ");
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Run");
                input = Console.ReadLine();

                if (input == "2")
                {
                    Console.WriteLine("You decided to run away from the monster");
                    battleInProgress = false;
                }
            }
        }
    }
}
