using System;

class Program
{

    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int User_number=0;
        do
        {
            Console.WriteLine("What is your guess? ");
            string User_num = Console.ReadLine();
            User_number = int.Parse(User_num);

            if (User_number > number)
            {
            Console.WriteLine("Lower");
            }
            else if (User_number == number)
            {
            Console.WriteLine("You got it!");
            }
            else 
            {
            Console.WriteLine("Higher");
            }

        }while(User_number < number || User_number > number);
    }
}