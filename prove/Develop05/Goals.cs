using System;
using System.Collections.Generic;

public abstract class Goals
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public string ShortName => _shortName;
    public int Points => _points;

    public Goals(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    
}