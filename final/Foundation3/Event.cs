class Event
{
    private string eventTitle;
    private string eventDescription;
    private DateTime eventDate;
    private TimeSpan eventTime;
    private Address eventAddress;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        eventTitle = title;
        eventDescription = description;
        eventDate = date;
        eventTime = time;
        eventAddress = address;
    }

    public virtual string GetEventDetails()
    {
        return $"Event Title: {eventTitle}\nDescription: {eventDescription}\nDate: {eventDate.ToShortDateString()}\nTime: {eventTime.ToString()}\nAddress: {eventAddress.ToString()}";
    }
}
