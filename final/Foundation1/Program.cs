using System;
      
 

class Program
{
    static void Main(string[] args)
    {
           List<Video> videos = new List<Video>();

        Video video1 = new Video("Diamonds", "Rihanna", 120);
        video1.AddComment("Taylor Smith", "That's supercool");
        video1.AddComment("Abdias Brevil", "I love this video ,it is amazing");
        video1.AddComment("Rebecca Bigord", "it's so nice");

        Video video2 = new Video("Discouraged? Look Outward", "Henry B. Eyring ", 180);
        video2.AddComment("james JeanPierre", "This message bless my life");
        video2.AddComment("Oreus sammar", "Thank you president Eyring for your message");

        Video video3 = new Video("How i #HearHim ", "Elder D.Todd Christofferson", 150);
        video3.AddComment("Onil JeanFrancois", "Thank you for your blessing message");
        video3.AddComment("Lauderson Fortune", "Amen");
        video3.AddComment("Taina Pierre", "I really love your message");
        video3.AddComment("Fritznord telier", "I learn so much , Thank you");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(comment.CommenterName + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}