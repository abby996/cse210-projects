using System;

class ReflectingActivity : Activity


{
   public Reflexion()
   {
   ReflectingActivity reflectingActivity = new ReflectingActivity


      This.SetActivityName ( "Reflexion Activity");
      This.SetDescription(" This activity will help you Reflect on times in your life " +
       "when you have shown strengh and resilience."+
       "This will help you recognize the power and how you can use it in other aspect of your life ");
     
      {

      public void Run()
         { DisplayPEndingMessage();
          int interval = GetDuration()  / 6;
          for (int i = 0; i <= 2; i++)
          {
              Console.WriteLine() ;
              Console.Write("Think of a time when you stood up for someone else.");
              ShowCountDow(interval);
              Console.WriteLine();
              Console.Write("Think of a time when you did something really difficult");
              ShowCountDow(interval);
              Console.WriteLine();
              Console.Write("Think of a time when you helped someone in need.");
              ShowCountDow(interval);
              Console.WriteLine();
              Console.Write("Think of a time when you did something truly selfless");
              ShowCountDow(interval);
          }
          DisplayPEndingMessage();
         }
        
      
      
       Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
        string input = Console.ReadLine();
        if (input.ToLower() == "quit")
        {
            return;
        }

        foreach (string question in GetQuestions())
        {
            Console.Clear();
            Console.WriteLine(DisplayStartingMessage());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");
            input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine(question);
            ShowCountdown();
        }

        Console.WriteLine("Done");
    }

    private void ShowCountdown(int interval = 1000)
    {
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(interval);
        Console.WriteLine("I'm back!!");
    }
}
      
     

   for (i= 0 ; i >0)
   {
    Console.WriteLine();
    Console.Write("Why was this experience meaningful to you?");
    ShowCountDow()
    Console.WriteLine()
    Console.Write("Have you ever done anything like this before?");
    ShowCountDow()
    Console.WriteLine()
    Console.Write("How did you get started?");
    ShowCountDow()
    Console.WriteLine()
    Console.Write("How did you feel when it was complete?");
    ShowCountDow()
    Console.WriteLine()
    Console.Write("What made this time different than other times when you were not as successful?");
    ShowCountDow()
    Console.WriteLine()

    Console.Write("What is your favorite thing about this experience?");
    ShowCountDow()
    Console.WriteLine()
    Console.Write("What could you learn from this experience that applies to other situations?");
    ShowCountDow()
    Console.WriteLine()
    Console.Write("What did you learn about yourself through this experience?.");
    ShowCountDow()
    Console.WriteLine()
    Console.Write("How can you keep this experience in mind in the future?.");
    ShowCountDow()
    Console.WriteLine()
    Console.WriteLine("Going to sleep for a second...");
    ShowCountDow()
    
Thread.Sleep(2000);

Console.WriteLine("I'm back!!");
   }


   {Console.Write("Done")}
}
      }
      
      }
}