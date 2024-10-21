using System;
public class Program
{
  public static string name;
  public static string age;
  public static string eyeColor;
  public static string hairColor;
  public static string shoeSize;
  public static string favColor;
  public static string favMovie;
  public static string favTeacher;
  public static string favClass;
  public static string favHoliday;
  public static string favSeason;
  public static string dreamJob;
  public static int ageInFiveYears;
  public static string siblings;
  public static string message;
  public static void Main(string[] args)
  {
    Name();
    Age();
    EyeColor();
    HairColor();
    ShoeSize();
    FavColor();
    FavMovie();
    FavTeacher();
    FavClass();
    FavHoliday();
    FavSeason();
    DreamJob();
    AgeInFiveYears();
    Siblings();
    Message();
  }
  public static void Name()
  {
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();
  }
  public static void Age()
  {
    Console.WriteLine("What is your age?");
     age = Console.ReadLine();

  }
  public static void EyeColor()
  {
    Console.WriteLine("What is your eye color?");
     eyeColor = Console.ReadLine();
  }

  public static void HairColor()
  {
    Console.WriteLine("What is your hair color?");
    hairColor = Console.ReadLine();
  }
  public static void ShoeSize()
  {
    Console.WriteLine("What is your shoe size?");
    shoeSize = Console.ReadLine();
  }
  public static void FavColor()
  {
    Console.WriteLine("What is your favorite color?");
    favColor = Console.ReadLine();
  }
  public static void FavMovie()
  {
    Console.WriteLine("What is your favorite movie?");
    favMovie = Console.ReadLine();
  }
  public static void FavTeacher()
  {
    Console.WriteLine("Who is your favorite teacher?");
     favTeacher = Console.ReadLine();
  }
  public static void FavClass()
  {
    Console.WriteLine("What is your favorite class?");
     favClass = Console.ReadLine();
  }
  public static void FavHoliday()
  {
    Console.WriteLine("What is your favorite holiday?");
    favHoliday = Console.ReadLine();
  }
  public static void FavSeason()
  {
    Console.WriteLine("What is your favorite season?");
     favSeason = Console.ReadLine();
  }
  public static void DreamJob()
  {
    Console.WriteLine("What is your dream job?");
     dreamJob = Console.ReadLine();
  }
  public static void AgeInFiveYears()
  {
    int number = int.Parse(age);
    ageInFiveYears = number + 5;
  }
  public static void Siblings()
  {
    Console.WriteLine("How many siblings do you have?");
     siblings = Console.ReadLine();
  }
  public static void Message()
  {
    Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + ". " + name + "'s hair color is " + hairColor + ". " + name + "'s shoe size is " + shoeSize +
    ". " + name + "'s favorite color is " + favColor + ". " + name + "'s favorite movie is " + favMovie + ". " + name + "'s favorite teacher is " + favTeacher + ". " + name + "'s favorite class is " + favClass + ". " + name + "'s favorite holiday is " + favHoliday +
    ". " + name + "'s favorite season is " + favSeason + ". " + name + "'s dream job is " + dreamJob + ". " + name + " will be " + ageInFiveYears + " in 5 years. " + name + " has " + siblings + " siblings. ");
  }

}


