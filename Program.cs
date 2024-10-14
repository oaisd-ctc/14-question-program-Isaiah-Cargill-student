using System;
public class Program
{
    public static void Main(string[]args)
    {
       Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

      Console.WriteLine("What is your age?");
        string age = Console.ReadLine();

      Console.WriteLine("What is your eye color?");
        string eyeColor = Console.ReadLine();

        Console.WriteLine("What is your hair color?");
        string hairColor = Console.ReadLine();

        Console.WriteLine("What is your shoe size?");
        string shoeSize = Console.ReadLine();

        Console.WriteLine("What is your favorite color?");
        string favColor = Console.ReadLine();

        Console.WriteLine("What is your favorite movie?");
        string favMovie = Console.ReadLine();

        Console.WriteLine("Who is your favorite teacher?");
        string favTeacher = Console.ReadLine();

        Console.WriteLine("What is your favorite class?");
        string favClass = Console.ReadLine();

        Console.WriteLine("What is your favorite holiday?");
        string favHoliday = Console.ReadLine();

        Console.WriteLine("What is your favorite season?");
        string favSeason = Console.ReadLine();

        Console.WriteLine("What is your dream job?");
        string dreamJob = Console.ReadLine();

        int number = int.Parse(age);
           
        Console.WriteLine("How many siblings do you have?");
        string siblings = Console.ReadLine();
        

        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + ". " + name + "'s hair color is " + hairColor + ". " + name + "'s shoe size is " + shoeSize +
        ". " + name + "'s favorite color is " + favColor + ". " + name + "'s favorite movie is " + favMovie + ". " + name + "'s favorite teacher is " + favTeacher + ". "  + name + "'s favorite class is " + favClass + ". "  + name + "'s favorite holiday is " + favHoliday +
        ". "  + name + "'s favorite season is " + favSeason + ". "  + name + "'s dream job is " + dreamJob + ". "  + name + " will be " + (number + 5) + " in 5 years. "  + name + " has " + siblings + " siblings. " );
        
    }
}


