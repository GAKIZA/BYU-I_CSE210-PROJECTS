using System;

class Program
{
    static void Main(string[] args)
    {
        var letter="";
        var sign = "";
        Console.Write("What is your grade percentage? ");
        float grade_percentage = float.Parse(Console.ReadLine());
        if (grade_percentage % 10 >= 7 && grade_percentage > 60 && grade_percentage < 90)
        {
            sign = "+";
        }
        else if (grade_percentage % 10 < 3 && grade_percentage > 60) 
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (grade_percentage >= 90)
        {
            //Console.WriteLine("Your grade is A");
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            //Console.WriteLine("Your grade is B");
            letter = "B";
        }
        else if (grade_percentage >=70)
        {
            //Console.WriteLine("Your grade is C");
            letter = "C";
        }
        else if (grade_percentage >=60)
        {
            //Console.WriteLine("Your grade is D");
            letter = "D";
        }
        else if (grade_percentage < 60)
        {
            //Console.WriteLine("Your grade is F");
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}{sign}");
        Console.WriteLine();
        if (grade_percentage >= 70)
        {
            Console.WriteLine("congratulations you passed!");
        }
        else 
        {
            Console.WriteLine("Sorry, you didn't pass for today, Keep up the momentum!");
        }
    }
}