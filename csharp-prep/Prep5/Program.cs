using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int favorite_number = PromptUserNumber();
        DisplayResult(username,SquareNumber(favorite_number));

    }
     static void DisplayWelcome()
     {
        Console.WriteLine("Welcome to the Program!");
     }
     static string PromptUserName()
     {
        Console.Write("Please provide your name ");
        string user_name = Console.ReadLine();
        return user_name;
     }
     static int PromptUserNumber()
     {
        Console.Write("Please type your favorite integer number! ");
        int favorite_number = int.Parse(Console.ReadLine());
        return favorite_number;
     }
      static int SquareNumber(int number)
     {
        int squared_number = number * number;
        return squared_number;
     }
     static void DisplayResult(string username,int squared_number)
     {
        Console.WriteLine($"{username}, the square of your number is {squared_number}");
     }


}