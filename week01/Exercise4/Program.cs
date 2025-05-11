using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        List<string> numbers = new List<string>();
        int Number=0;
        int Sum = 0;
        int Ave=0;
        int Max_num = -1;

        Console.WriteLine("Enter a number to the list. Enter 0 when you have finished");
        do
        {
            Console.WriteLine("Enter number");
            String num = Console.ReadLine();
            Number = int.Parse(num);

            numbers.Add(num);
        } while(!(Number==0));

        foreach (String E_num in numbers)
        { 
            int E_number = int.Parse(E_num);
            Sum = Sum + E_number;
            Ave = Sum / numbers.Count;
            if (E_number > Max_num)
            {
               Max_num=E_number;
            }
        }

        Console.WriteLine($"The sum is: {Sum}");
        Console.WriteLine($"The average is: {Ave}");
        Console.WriteLine($"The max number is: {Max_num}");
           
    }
}