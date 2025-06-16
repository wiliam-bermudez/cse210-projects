using System;

class Program_
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
         GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("\n=== Goal Tracker Menu ===");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option (1-6): ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.DisplayScore();
                manager.ListGoals();
            }
            else if (choice == "3")
            {
                manager.SaveGoals();
            }
            else if (choice == "4")
            {
                manager.LoadGoals();
            }
            else if (choice == "5")
            {
                manager.RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose again.");
            }

            Console.WriteLine();
        }
    }
}

