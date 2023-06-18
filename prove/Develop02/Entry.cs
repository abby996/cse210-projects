using System;


class Entry
{
    public string date, promptText, entryText;

    public Entry(string _date, string _promptText, string _entryText) 
    {
       date           = _date;
       promptText     = _promptText;
       entryText      = _entryText;
    }

    public void Display()

    {
       Console.WriteLine($"Date: {date} . promt: {promptText} . Entry: {entryText}");
       Console.WriteLine (entryText);
    }
}
