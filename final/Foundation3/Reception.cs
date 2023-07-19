using System;

class Reception : Event
{
    private string rsvpEmail;
    public DateTime Date { get; set; }
     public string Title { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetEventDetails()
    {
        string baseDetails = base.GetEventDetails();
        return $"{baseDetails}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

