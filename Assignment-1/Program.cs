using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the virtual pet simulator");

        Console.WriteLine("Please select a pet of your choice:\n 1. Dog\n 2. Cat\n 3. Bird ");

        int pet_Type = Convert.ToInt32(Console.ReadLine());

        if (pet_Type == 1)
        {
            Console.WriteLine("You've chosen Dog, what would you like to name your pet");
        }
        else if (pet_Type == 2)
        {
            Console.WriteLine("You've chosen Cat, what would you like to name your pet: ");
        }
        else if (pet_Type == 3)
        {
            Console.WriteLine("You've chosen Bird, what would you like to name your pet: ");
        }
        else
        {
            Console.WriteLine("Please enter a valid input");
            return;
        }

        string pet_Name = Console.ReadLine();
        Console.WriteLine("Welcome " + pet_Name + "!");

        // Initialise default values
        int hunger = 5;
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

            // Display critical status messages
            if (hunger >= 7)
            {
                Console.WriteLine($"Critical Warning: {pet_Name} is Hungry");
            }
            if (happiness <= 3)
            {
                Console.WriteLine($"Critical Warning: {pet_Name} is sad");
            }
            if (health <= 3)
            {
                Console.WriteLine($"Critical Warning: {pet_Name} Health is critically low");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Feeding {pet_Name}");
                    hunger -= 2;
                    if (hunger > 10) hunger = 10;
                    if (hunger < 1) hunger = 1;

                    happiness += 1;
                    if (happiness > 10) happiness = 10;

                    health += 1;
                    if (health > 10) health = 10;
                    break;

                case 2:
                    Console.WriteLine($"Playing with {pet_Name}");
                    happiness += 2;
                    hunger -= 1;
                    if (hunger > 10) hunger = 10;
                    if (happiness > 10) happiness = 10;

                    health -= 1;
                    if (health < 1) health = 1;
                    break;

                case 3:
                    Console.WriteLine($"Letting {pet_Name} rest");
                    health += 2;
                    if (health > 10) health = 10;

                    happiness += 1;
                    if (happiness > 10) happiness = 10;
                    break;

                case 4:
                    Console.WriteLine($"Checking {pet_Name} status");
                    Console.WriteLine($"Hunger: {hunger}");
                    Console.WriteLine($"Happiness: {happiness}");
                    Console.WriteLine($"Health: {health}");
                    break;

                case 5:
                    Console.WriteLine("Exiting the program");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
