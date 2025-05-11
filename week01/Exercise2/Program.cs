using System;

class Program
{
    static void Main(string[] args)
    {   
        String letter="";
        Console.WriteLine("What is your grade percentage?");
        string User_grade= Console.ReadLine();
        int User_grade_int= int.Parse(User_grade);

        if (User_grade_int>=70)
        {
            Console.WriteLine("You passed!");
            letter="Congratulations, you are amazing!";
        }
        else if (User_grade_int >=50 && User_grade_int<70)
        {
            Console.WriteLine("You have one more opportunity.");
            letter="Congratulations, you can still got it";
        }
        else
        {
            Console.WriteLine("You did not pass");
            letter="You are amazing, you can do it better next time";
        }

        Console.Write(letter);
    }
} 