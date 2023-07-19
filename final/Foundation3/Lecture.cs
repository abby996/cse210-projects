class Lecture : Event
{
    private string speaker;
    public string Title { get; set; }
     public DateTime Date  { get; set; }
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetEventDetails()
    {
        string baseDetails = base.GetEventDetails();
        return $"{baseDetails}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}
