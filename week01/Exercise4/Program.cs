using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter as many numbers as you like. Type 0 to stop.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                if (number != 0)
                {
                    numbers.Add(number);
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a whole number.");
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        float average = (float)sum / numbers.Count;

        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest number: {max}");

        int smallestPositive = int.MaxValue;
        foreach (int n in numbers)
        {
            if (n > 0 && n < smallestPositive)
            {
                smallestPositive = n;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"Smallest positive number: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        numbers.Sort();
        Console.WriteLine("Sorted numbers:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}