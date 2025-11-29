using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> activityHistory = new List<string>();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Program ===\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflection Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. View Activity History");
            Console.WriteLine("  5. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            Activity activity = null;
            
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    DisplayHistory(activityHistory);
                    continue;
                case "5":
                    Console.Clear();
                    Console.WriteLine("\n=== Session Summary ===");
                    Console.WriteLine($"Total activities completed: {activityHistory.Count}");
                    if (activityHistory.Count > 0)
                    {
                        Console.WriteLine("\nActivities you practiced:");
                        foreach (string record in activityHistory)
                        {
                            Console.WriteLine($"  - {record}");
                        }
                    }
                    Console.WriteLine("\nThank you for taking time for mindfulness today!");
                    Console.WriteLine("Remember: peace is always just a breath away. 🌿\n");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    Thread.Sleep(2000);
                    continue;
            }
            
            if (activity != null)
            {
                activity.Run();
                activityHistory.Add(activity.GetActivityRecord());
            }
        }
    }
    
    static void DisplayHistory(List<string> history)
    {
        Console.Clear();
        Console.WriteLine("\n=== Your Activity History (This Session) ===\n");
        
        if (history.Count == 0)
        {
            Console.WriteLine("No activities completed yet. Start your mindfulness journey!");
        }
        else
        {
            for (int i = 0; i < history.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {history[i]}");
            }
            Console.WriteLine($"\nTotal: {history.Count} activities");
        }
        
        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}
