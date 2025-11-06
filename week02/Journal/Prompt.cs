using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> _prompts;
    private Random _random;

    public Prompt()
    {
        _prompts = new List<string>
        {
            "Who inspired me today, and why?",
            "What is one small victory I had today?",
            "What did I learn about myself today?",
            "What moment made me feel grateful?",
            "If I could relive one part of today, what would it be?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
