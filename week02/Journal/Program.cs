using System;
using System.Collections;
using System.IO;

class Program()
{


    static void Main(string[] args)
    {
        // Program class -----------------------
        int _userChoice;


        // Journal class -----------------------

        Journal theJournal = new Journal();

        // Entry class -------------------------


        // Prompt class ------------------------

        Console.WriteLine("Select an option: \n 1. Write \n 2. Display \n 3. Save \n 4. Load \n 5. Quit");
        _userChoice = int.Parse(Console.ReadLine());

        do
        {
            switch (_userChoice)
            {
                case 1:
                    theJournal.AddEntry();
                    break;

                case 2:
                    theJournal.Display();
                    break;

                case 3:
                    Console.WriteLine("What will be the name of the file?");
                    String filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                    break;

                case 4:
                    Console.WriteLine("What will be the name of the file?");
                    String filenameLoad = Console.ReadLine();
                    theJournal.LoadFromFile(filenameLoad);
                    break;
            }

            Console.WriteLine("Select an option: \n 1. Write \n 2. Display \n 3. Save \n 4. Load \n 5. Quit");
            Console.WriteLine("Write your choice: ");
            _userChoice = int.Parse(Console.ReadLine());


        } while (_userChoice != 5);
        
            Console.WriteLine("See you tomorrow");

        
    }
}