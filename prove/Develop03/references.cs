using System;

 

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