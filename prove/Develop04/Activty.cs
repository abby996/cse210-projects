using System.Diagnostics;

        

    public int GetDuration()
    {
        return duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {name}.");
        Console.Write();
        Console.WriteLine(description);
        Console.Write();

        Console.Write("How long, in second , would you like for your session?");
        duration = int.Parse(Console.Readline());

        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(5);

    }
    public void DisplayPEndingMessage()
    {
       Console.WriteLine();
       Console.WriteLine("well Done!!!");
       ShowSpinner(3);
       Console.WriteLine($" You have complete another {duration} seconde of the {name}.");
       ShowSpinner(5);
    }
    public void ShowSpinner(int numSecondsToRun)
    {
       Stopwatch stopwatch = new Stopwatch();
       stopwatch.Start() ;

       while (stopwatch.ElapsedMilliSeconds / 1000 < numSecondsToRun)
       {
           spinnerCounter++;
           switch (spinnerCounter % 4)
           {
            case 0: Console.Write("/"); break;
            case 1: Console.Write("-"); break;
            case 2: Console.Write("\\"); break;
            case 3: Console.Write("|"); break;
            
          
           }
           Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
           Thread.Sleep(2000);
       } 
       Console.Write(" ");
    }
    public void ShowCountDow(int numSecondsToRun)
    {
      for (int i = numSecondsToRun; i >= 1; i--)
      {
        Console.Write(string.Format("{0}",1));
        Console.SetCursorPosition(Console.CursorLeft -1 , Console.CursorTop());
        Thread.Sleep(1000);
      }
      Console.Write(" ");
    }

}