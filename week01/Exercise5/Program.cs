using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeUser();

        string user = GetName();
        int favNumber = GetFavoriteNumber();

        int squaredValue = FindSquare(favNumber);

        ShowFinalMessage(user, squaredValue);
    }

    static void WelcomeUser()
    {
        Console.WriteLine("Hello there! Welcome to the C# Function Demo.");
    }

    static string GetName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int GetFavoriteNumber()
    {
        Console.Write("Enter your favorite number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    static int FindSquare(int value)
    {
        return value * value;
    }

    static void ShowFinalMessage(string username, int result)
    {
        Console.WriteLine($"{username}, the square of your favorite number is {result}.");
    }
}
