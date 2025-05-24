using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Create a Reference object

        string text = "Therefore, dearly beloved brethren, let us cheerfully do all things that lie in our power; and then may we stand still, with the utmost assurance, to see the salvation of God, and for his arm to be revealed.";
        Reference _reference = new Reference("DyC", 123, 17);

        Scripture scripture = new Scripture(_reference, text);
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words have been hidden. Program will now exit.");
                break;
            }

            Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWord(3); // Oculta 3 palabras visibles por ronda
        }

         


    }
}