namespace Asad_Muhammad_a1.rpg
{
    using System;
   
    class Program
    {
        static void Main()
        { 

        
                //Game preparation
                bool doorUnlocked = false;
                string input;
                string keyLocation = "on the shelf";

                Console.WriteLine("welcome to the game");
                Console.WriteLine("you woke up in a room. You see a door in front of you");

                //Central game loop
                while (true)
                {
                    Console.WriteLine("\nWhat is your action? (look/move north/open door/take key/I am a wimp");
                    input = Console.ReadLine().ToLower();

                    // Manage player code
                    if (input == "look")
                    {
                        Console.WriteLine($"You see a key {keyLocation} and a door in front of you.");

                    }
                    else if (input == "move north")
                    {
                        if (doorUnlocked)
                        {
                            Console.WriteLine("you escaped, victory");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The door won't open, use a key.");

                        }
                    }
                    else if (input == "open door")
                    {
                        if (keyLocation == "on the shelf")
                        {
                            doorUnlocked = true;
                            Console.WriteLine("use the key to open the door.");
                        }
                        else
                        {
                            Console.WriteLine("the door won't open, use the key");

                        }
                    }
                    else if (input == "take key")
                    {
                        if (keyLocation == "pn the shelf")
                        {
                            keyLocation = "om the shelf";
                            Console.WriteLine("pick the key up.");

                        }
                        else
                        {
                            Console.WriteLine("You have the key.");

                        }
                    }
                    else if (input == "I am a wimp")
                    {
                        Console.WriteLine("You chose to be a wimp. Farewell");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("wrong button. Press the correct one.");
                    }
                }
            }

        }
    }

