class Scripture
{
    public Reference Reference { get; }
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        words = text.Split(' ').Select(wordString => new Word(wordString)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        // Get the words that are not already hidden
        List<Word> unhiddenWords = words.Where(word => !word.GetIsHidden()).ToList();

        if (unhiddenWords.Count > 0)
        {
            // Select a random word from the unhidden words list
            int randomIndex = random.Next(unhiddenWords.Count);
            Word randomWord = unhiddenWords[randomIndex];
            
            // Hide the selected random word
            randomWord.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden);
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", words.Select(word => word.GetDisplayText()));
        return $"{Reference.GetDisplayText()}\n{scriptureText}";
    }
}