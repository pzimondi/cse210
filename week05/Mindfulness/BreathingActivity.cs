// BreathingActivity.cs
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    
    protected override void PerformActivity()
    {
        Console.WriteLine("\nBegin breathing...\n");
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            if (DateTime.Now.AddSeconds(4) > endTime)
            {
                break;
            }
            
            ShowBreathingPulse("Breathe in...", 4);
            
            if (DateTime.Now >= endTime)
            {
                break;
            }
            
            ShowBreathingPulse("Breathe out...", 4);
        }
    }
}
