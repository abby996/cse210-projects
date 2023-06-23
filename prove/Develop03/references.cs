using System;

class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int Verse { get; }
    public int EndVerse { get; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = 0;
    }

      public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        Verse = verseStart;
        EndVerse = verseEnd;
    }
    public string GetDisplayText()
    {
        
        {
            string ReferencesDisplay = "";

            if (EndVerse != 0)
            {
                ReferencesDisplay = $"{Book}, {Chapter}: {Verse}-{EndVerse}";
            }
            else
            
                ReferencesDisplay = $"{Book}, {Chapter}: {Verse}";

            return ReferencesDisplay;
        }
    }
}