

class Scripture
{ 
    Reference reference ;
    List<Word>  words;

    public Scripture(Reference _references, string _text )
    {
        reference =_references;
        words = new List<Word>();
        List<string> allwords = _text.Split(' ').ToList();
        foreach (string wordstring in allwords)
        {
            Word newWord = new Word (wordstring);
            words.Add(newWord);
    
        }
    }

    public void HideRandomWords( )
    {
        
    }

    public string GetDisplayText()
{
    string scriptureText = "";
    foreach (Word word in words)
    {
        if (word.GetIsHidden() == false)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        else
        {
            scriptureText += new string('_', word.GetDisplayText().Length) + " ";
        }
    }

    return $"{reference.GetDisplayText()} {scriptureText}";
}

   public bool IsCompletelyHidden()
{
    
    return false; 
}
}