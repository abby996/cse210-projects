using System;
using System.Collections.Generic;


class PromptGenerator

{
    private List<string> prompts;

    public PromptGenerator()

    {
     prompts = new List<string>
     {
        "Who was the most interesting person i interacted with today ?",
        "What was the best part of my day?",
        "How did i see the hand of the Lord in my life today?",
        "What was the strongest emotion i felt today?",
        "If i had one thing i could do over today, what would it to be?"
     };

    }

    public string GetRandomPrompt()
    {
       string randomPrompt= "";
       int randomIndex = new Random().Next(prompts.count);
       randomPrompt= prompts[randomIndex];

       return randomPrompt;
    }

}