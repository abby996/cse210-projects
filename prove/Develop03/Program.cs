using System;

class Program
{
    static void Main(string[] args)
    {
      

      string userInput = "";

      Reference reference = new Reference("Proverbes ", 3 ,5, 6);
      Scripture scripture = new Scripture(reference, "Trust in The Lord with all thine heart,");
        
      
      while (userInput != "quit")
      {
       Console.WriteLine(scripture.GetDisplayText());
       Console.WriteLine();
       Console.WriteLine("Press 'Enter' to continue or type 'quit' to finish"); 
       userInput=Console.ReadLine();
       scripture.HideRandomWords();
      }
        
    }
}