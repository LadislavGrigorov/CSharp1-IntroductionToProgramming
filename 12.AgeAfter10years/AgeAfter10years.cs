using System;
//12. Write a program to read your age from the console and print how old you will be after 10 years.
class AgeAfter10years
{
    static void Main()
    {
        Console.Write("How old are you: ");
        int years = int.Parse(Console.ReadLine());
        int sum = years + 10;
        Console.WriteLine("You are going to be {0} years old after 10 years.", sum);
    }
}

