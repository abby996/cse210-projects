using System;
      
 

class Program
{
   

    static void Main(string[] args)
    {
        List<Media> mediaList = new List<Media>();

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


        
         mediaList.AddRange(new Media[] { video1, video2 });

        foreach (Media media in mediaList)
        {
            media.DisplayInfo();
        }
    }
}
