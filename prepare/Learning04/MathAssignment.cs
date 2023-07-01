using System;

public class MathAssignment : Assignment

{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string _studentName, string _topic, string _textbookSection, string _problems) : base (studentName , topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
   
    public string GetHomeworkList ()
    {
       
        return $"Section {_textbookSection} Problems {_problems}";
    }
}