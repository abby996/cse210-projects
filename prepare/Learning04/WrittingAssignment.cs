using system;

public class WrittingAssignment


{
    private string _title;

    public WrittingAssignment(string _studentName, string _topic, string _title ): base (studentName, topic)
     {
        _title =title;
     }
    

    public string GetWrittingInformation()
    {
      string studentName= GetStudentName();

      return $"{_title} {studentName}"
    }

}