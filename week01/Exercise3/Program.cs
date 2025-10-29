using System;

class Program
{
    static void Main(string[] args)
    {

        Random numberGenerator = new Random();
        string keepPlaying = "yes";

        Console.WriteLine();
        Console.WriteLine("=== Welcome to the Guess My Number Game! ===");
        Console.WriteLine();

        while (keepPlaying.Trim().ToLower() == "yes")
        {
            int hiddenNumber = numberGenerator.Next(1, 101);
            int guessCount = 0;
            int playerGuess = -1;

            Console.WriteLine("I've picked a secret number between 1 and 100.");
            Console.WriteLine("Can you figure it out? Let's see how many tries it takes!");

            while (playerGuess != hiddenNumber)
            {
                Console.Write("Your guess: ");
                string guessInput = Console.ReadLine();

                if (int.TryParse(guessInput, out playerGuess))
                {
                    guessCount++;

                    if (playerGuess < hiddenNumber)
                    {
                        Console.WriteLine("Aim higher!");
                    }
                    else if (playerGuess > hiddenNumber)
                    {
                        Console.WriteLine("Go lower!");
                    }
                    else
                    {
                        Console.WriteLine($"Great job! You got it right in {guessCount} attempts!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please type a number between 1 and 100.");
                }
            }

            Console.Write("Would you like to play again? (yes/no): ");
            keepPlaying = Console.ReadLine() ?? "no";

            if (keepPlaying.Trim().ToLower() != "yes")
            {
                Console.WriteLine("Thanks for playing the Guess My Number Challenge!");
                Console.WriteLine("Hope to see you again soon.");
            }
        }

    }
}