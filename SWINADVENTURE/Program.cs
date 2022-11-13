using System;

namespace SWINADVENTURE
{
    class Program
    {
        static void Main(string[] args)
        {

            //get the player name and desciption
            Console.WriteLine("Welcome to Swin Game");
            Console.WriteLine("Enter Your Name");
            //user input the name 
            string name = Console.ReadLine();

            //A biography to describe user
            Console.WriteLine("Enter your description as a player");
            string description = Console.ReadLine();


            //Create a Player Object
            Player player = new Player(name, description);
            //create 2 items which is weapon and armour
            //first parameters defines as items
            Item weapon = new Item(new string[] {"axe","sword","bow"},"attack","weapon");
            Item armour = new Item(new string[] { "boots","chestplate","helmet","pants"}, "armour", "body armour");

            //add to player inventory
            player.Inventory.Put(weapon);
            // Weapon Item = axes,
            player.Inventory.Put(armour);

            //create a bag for the player
            Bag bag = new Bag(new string[] {"bag"},"bag","a typicial bag");
            // Create an item and let the bag keep
            Item food = new Item(new string[] {"bread"},"food","a toast bread");
            //Put the food into the bag
            bag.inventory.Put(food);
            bag.inventory.Put(weapon);
            //give the player a bag
            player.Inventory.Put(bag);

            //Create a while condition
              string command;
              bool comm = true;
              Look_Command look = new Look_Command();
              while(comm)
              {
                  Console.Write("Write your command :");
                  command = Console.ReadLine();
                  if (command.ToLower() !="end")
                  {

                      Console.WriteLine(look.Execute(player,command.Split()));
                  }
                  else
                  {
                      Console.WriteLine("End");
                      comm = false;
                  }
              }

          /*  string[] choiceList = new[] { "" };
            while (choiceList[0] != "quit")
            {
                Look_Command look = new Look_Command();
                Console.Write("Command - > ");
                string choice = Console.ReadLine();
                choiceList = choice.Split(" ");
                Console.Write(look.Execute(player, choiceList));
               
            }*/
        }

    }
}
