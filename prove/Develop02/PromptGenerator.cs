using System;
using System.Collections.Generic;

class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What made you smile today?",
        "What is something you learned recently?",
        "What are you grateful for right now?",
        "What is a challenge you are currently facing?",
        "What is something you are looking forward to?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}