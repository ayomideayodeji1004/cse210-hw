using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished; ");
        int input = int.Parse(Console.ReadLine());
        while (input != 0)
        {
            numbers.Add(input);
            Console.Write("Enter a list of numbers, type 0 when finished; ");
            input = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / (double)numbers.Count}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum is: {max}");
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive is: {smallestPositive}");
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
    
}