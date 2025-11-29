// ListingActivity.cs
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _itemCount;
    
    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        
        _itemCount = 0;
    }
    
    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);
        
        Console.WriteLine("\n");
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _itemCount = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            
            DateTime itemEndTime = DateTime.Now.AddSeconds(5);
            string input = "";
            
            while (DateTime.Now < itemEndTime && DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input.Substring(0, input.Length - 1);
                        Console.Write("\b \b");
                    }
                    else if (!char.IsControl(key.KeyChar))
                    {
                        input += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                Thread.Sleep(50);
            }
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                _itemCount++;
            }
            
            Console.WriteLine();
            
            if (DateTime.Now >= endTime)
            {
                break;
            }
        }
        
        Console.WriteLine($"\nYou listed {_itemCount} items!");
    }
}