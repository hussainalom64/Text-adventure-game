using System;

namespace TextAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to the text adventure game :D.");
            Console.WriteLine("In this game, you will make decisions and explore a virtual world.");

            //Setup variables for the game
            int playerHealth = 100;
            int playerGold = 10;
            string playerLocation = "village";

            //Loop the main game
            while(true)
            {
                //Current game status
                Console.WriteLine("");
                Console.WriteLine("Your current location: " + playerLocation);
                Console.WriteLine("Your health: " + playerHealth);
                Console.WriteLine("Your gold: " + playerGold);
                Console.WriteLine("What would you like to do?");

                if(playerLocation == "village")
                {
                    Console.WriteLine("Go to the forest");
                    Console.WriteLine("Go to the cave");
                    Console.WriteLine("Go to the castle");
                }
                else if(playerLocation == "forest")
                {
                    Console.WriteLine("Go to the village");
                    Console.WriteLine("Go to the cave");
                    Console.WriteLine("Go to the castle");
                    Console.WriteLine("Fight a monster!");
                }
                else if(playerLocation == "cave")
                {
                    Console.WriteLine("Go to the village");
                    Console.WriteLine("Go to the forest");
                    Console.WriteLine("Go to the castle");
                    Console.WriteLine("Find the treasue :O");
                }
                else if(playerLocation == "castle")
                {
                    Console.WriteLine("Go to the village");
                    Console.WriteLine("Go to the forest");
                    Console.WriteLine("Go to the cave");
                    Console.WriteLine("Talk to the king");
                }
                //Read players choice
                string choice = Console.ReadLine();

                //Perform actions based on choice
                if(playerLocation == "village")
                {
                    if(choice == "1")
                    {
                        playerLocation = "forest";
                    }
                    else if (choice == "2")
                    {
                        playerLocation = "cave";
                    }
                    else if (choice == "3")
                    {
                        playerLocation = "castle";
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
                else if (playerLocation == "forest")
                {
                    if (choice == "1")
                    {
                        playerLocation = "village";
                    }
                    else if (choice == "2")
                    {
                        playerLocation = "cave";
                    }
                    else if (choice == "3")
                    {
                        playerLocation = "castle";
                    }
                    else if (choice == "4")
                    {
                        //Random number generator to decide if the players wins or loses the fight
                        Random rnd = new Random();
                        int result = rnd.Next(1, 3);
                        if (result == 1)
                        {
                            playerHealth -= 30;
                            Console.WriteLine("You ran away because you got hurt too badly :(");
                        }
                        else
                        {
                            playerGold += 10;
                            Console.WriteLine("Well done, you have won and have gained 10 gold!");
                        }
                    }
                }
                else if (playerLocation == "cave")
                {
                     if(choice == "1")
                     {
                         playerLocation = "village";
                     }
                     else if(choice == "2")
                     {
                         playerLocation = "forest";
                     }
                     else if(choice == "3")
                     {
                         playerLocation = "castle";
                     }
                     else if(choice == "4")
                     {
                        //Another random generator to see if the player finds gold or not
                         Random rndg = new Random();
                         int goldResult = rndg.Next(1, 3);
                         if (goldResult == 1)
                         {
                             Console.WriteLine("You didn't find any gold");
                         }
                         else
                         {
                             playerGold += 10;
                             Console.WriteLine("You have found 10 gold!");
                         }
                     }
                }
                else if(playerLocation == "castle")
                { 
                    if(choice == "1")
                    {
                        playerLocation = "village";
                    }
                    else if(choice == "2")
                    {
                        playerLocation = "forest";
                    }
                    else if(choice == "3")
                    {
                        playerLocation = "cave";
                    }
                    else if(choice == "4")
                    {
                        Console.WriteLine("Good to see you, your highness :)");
                    }
                }
            }
        }
    }

}
