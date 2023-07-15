using System;
using System.Collections.Generic;




abstract class Media
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    public abstract void DisplayInfo();
}
