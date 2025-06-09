using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string input = "";
        while (input != "5")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");
            input = Console.ReadLine();


            if (input == "1")
            {
                new BreathingActivity().run();
                break;
            }
            else if (input == "2")
            {
                new ReflectingActivity().Run();
                break;
            }
            else if (input == "3")
            {
                new ListingActivity().Run();
                break;
            }
            else if (input == "4")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                break;
            }
            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();
        } 
        
    }

}