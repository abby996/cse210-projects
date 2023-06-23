using System;
using System.Collections.Generic;
using System.IO;

class ScriptureLibrary
{
    private List<Scripture> scriptures;
    private int currentIndex;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
        currentIndex = -1;
    }

    public void LoadScripturesFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    string book = parts[0];
                    int chapter = int.Parse(parts[1]);
                    string text = parts[2];

                    Reference reference = new Reference(book, chapter, 1);
                    Scripture scripture = new Scripture(reference, text);
                    scriptures.Add(scripture);
                }
                else if (parts.Length == 4)
                {
                    string book = parts[0];
                    int chapter = int.Parse(parts[1]);
                    int verseStart = int.Parse(parts[2]);
                    int verseEnd = int.Parse(parts[3]);

                    Reference reference = new Reference(book, chapter, verseStart, verseEnd);
                    Scripture scripture = new Scripture(reference, "");
                    scriptures.Add(scripture);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error loading scriptures from file: {e.Message}");
        }
    }

    public Scripture GetNextScripture()
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures available.");
            return null;
        }

        currentIndex = (currentIndex + 1) % scriptures.Count;
        return scriptures[currentIndex];
    }
}