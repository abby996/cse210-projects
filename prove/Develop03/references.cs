using System;
class Reference
{
    string book;
    int chapter, verse, endverse;
    public Reference(string _book, int _chapter, int _verse)
    {
        book    =_book;
        chapter =_chapter;
        verse   =_verse;
    }
    public Reference(string _book, int _chapter, int _verseStart, int _verseEnd )
    {
        book        = _book;
        chapter     =_chapter;
        verse       =_verseStart;
        endverse   =_verseEnd;
    }

    public string GetDisplayText()
    {
        
        {
            string ReferencesDisplay = "";

            if (endverse != 0)
            {
                ReferencesDisplay = $"{book}, {chapter}: {verse}-{endverse}";
            }
            else
            
                ReferencesDisplay = $"{book}, {chapter}: {verse}";

            return ReferencesDisplay;
        }
    }
}