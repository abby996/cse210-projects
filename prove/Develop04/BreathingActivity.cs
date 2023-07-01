

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
       this.SetActivityName("Breathing Activity");
       this.SetDescription("This activity will help you relax by walking you" +
        " through breathing in and out slowy." +
        "Clear your mind and focus on your Breathing ");
    }
    public void Run()
    {
       DisplayPEndingMessage();
       int interval = GetDuration()  / 6;
       for (int i = 0; i <= 2; i++)
       {
        Console.WriteLine();
        Console.Write("Breath' in...");
        ShowCountDow(interval);
        Console.WriteLine();
        Console.Write("Breath' out...");
        ShowCountDow(interval);
        Console.Write();
       }
       DisplayPEndingMessage();
    }

}
    
    
