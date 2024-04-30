using System;

class Program
{
    
      static void Main(string[] args)
    {
       string playing;
       do
       {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessNumber;  
        int guesses = 0;
        
        do 
        {
            guesses += 1;
        Console.Write("What is your guess? ");
        guessNumber = int.Parse(Console.ReadLine());
        if (guessNumber > magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guessNumber < magicNumber)
         {
            Console.WriteLine("Lower");
        }
        } while (guessNumber != magicNumber);
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"You made {guesses} guesses");
        Console.Write("Do you want to play again? ");
        playing = Console.ReadLine(); 
        } while (playing.ToUpper() == "YES");
        Console.WriteLine("See you soon!");
    }
}