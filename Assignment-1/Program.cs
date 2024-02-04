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

            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Feed " + pet_Name);
                Console.WriteLine("2. Play with " + pet_Name);
                Console.WriteLine("3. Let " + pet_Name + " rest");
                Console.WriteLine("4. Check " + pet_Name + " status");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

            }
        }
}
    

        
