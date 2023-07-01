using System;
using System.Collection.Generic;

public class Assignment
{
   private string _studentName;
   private string _topic;

    public Assignment(string _studentName, string _topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudent()
        {
            return _studentName;
        }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return = _studentName + " -  " + _topic;
    }
}