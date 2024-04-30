using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int Num;
        int Sum = 0;
        float Average;
        int Count = 0;
        int largest;
        List<int> numbers = new List<int>();


        do{
            Console.Write("Enter a number: ");
            Num = int.Parse(Console.ReadLine());
            numbers.Add(Num);
            Sum += Num;
            Count += 1;

        } while (Num !=0);
        Average = Sum / Count;
        numbers.Sort();
        largest = numbers[Count-1];
        Console.WriteLine($" the sum is {Sum}");
        Console.WriteLine($"Average is {Average}");
        Console.WriteLine($" for a list of {Count} elements, the largest is {largest} ");
        foreach (int number in numbers)
        {
              Console.WriteLine(number);
        }
    }
}