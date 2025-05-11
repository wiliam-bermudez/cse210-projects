using System;
using System.ComponentModel;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String UserName= PromptUserName();
        int UserNumber= PromptUserNumber();
        float SquaredNumber = SquareNumber();
        String Sentence = DisplayResult(UserName,SquaredNumber);

        Console.WriteLine($"Your name is:  {UserName} \n Your favorite number is {UserNumber} \n The Squared number is {SquaredNumber}");
        Console.WriteLine($"{Sentence}");
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName()
    {
        String name;
        Console.WriteLine("Please enter your name: ");
        name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        int number;
        Console.WriteLine("Enter your favorite number: ");
        number = int.Parse(Console.ReadLine());

        return number;
    }

    static float SquareNumber()
    {
        float numbersqrd;
        float Squared_Number=0;
        Console.WriteLine("Enter a number to be squared: ");
        numbersqrd= float.Parse(Console.ReadLine());
        Squared_Number=numbersqrd*numbersqrd;
        return Squared_Number;
    }

    static String DisplayResult(String name, float SqrNumber)
    {
        String Sentence ="";
        Sentence="Your name is: " + name + " and the squared number is " + SqrNumber;
        return Sentence;
    }
}