using System;
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadScripturesFromFile("scriptures.txt");

        Console.WriteLine("Welcome to the Scripture Memorization Program!");

        while (true)
        {
            Scripture scripture = library.GetNextScripture();

            if (scripture == null)
            {
                break;
            }

            ClearConsole();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");

            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.WriteLine("\nProgram finished. Press Enter to exit.");
        Console.ReadLine();
    }

    static void ClearConsole()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
    }
}