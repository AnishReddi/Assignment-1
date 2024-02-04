using System;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the virtual pet simulator");

        Console.WriteLine("Please select a pet of your choice: \n 1.Dog \n 2.Cat \n 3.Bird ");

        int pet_Type = Convert.ToInt32(Console.ReadLine());
        {
            if (pet_Type == 1)
            {
                Console.WriteLine("You've chosen Dog,what would you like to name your pet");

            }

            else if (pet_Type == 2)
            {

                Console.WriteLine("You've chosen Cat,what would you like to name your pet: ");

            }

            else if (pet_Type == 3)
            {
                Console.WriteLine("You've chosen Bird,what would you like to name your pet: ");

            }
            else
            {
                Console.WriteLine("Please enter a valid input");
            }
            string pet_Name = Console.ReadLine();
            Console.WriteLine("Welcome " + pet_Name + "!");

            int hunger = 5; // Initial values
            int happiness = 5;
            int health = 5;


            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Feed " + pet_Name);
                Console.WriteLine("2. Play with " + pet_Name);
                Console.WriteLine("3. Let " + pet_Name + " rest");
                Console.WriteLine("4. Check " + pet_Name + " status");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Feeding " + pet_Name);
                        // Decrease hunger, but not below 1
                        hunger = hunger - 2;
                        if (hunger < 1)
                        {
                            hunger = 1;
                        }

                        // Increase happiness, but not above 10
                        happiness = happiness + 1;
                        if (happiness > 10)
                        {
                            happiness = 10;
                        }

                        // Increase health, but not above 10
                        health = health + 1;
                        if (health > 10)
                        {
                            health = 10;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Playing with " + pet_Name);
                        // Increase happiness, but not above 10
                        happiness = happiness + 2;
                        if (happiness > 10)
                        {
                            happiness = 10;
                        }

                        // Decrease health, but not below 1
                        health = health - 1;
                        if (health < 1)
                        {
                            health = 1;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Letting " + pet_Name + " rest");
                        // Increase health, but not above 10
                        health = health + 2;
                        if (health > 10)
                        {
                            health = 10;
                        }

                        // Decrease happiness, but not below 1
                        happiness = happiness - 1;
                        if (happiness < 1)
                        {
                            happiness = 1;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Checking " + pet_Name + " status");
                        Console.WriteLine("Hunger: " + hunger);
                        Console.WriteLine("Happiness: " + happiness);
                        Console.WriteLine("Health: " + health);
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }



                
            }
        }
    }
}




    

        
