using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();  // List for storing each Video instance

        // VIDEO 1
        Video v1 = new Video("Why Ugandan Rolex is Famous", "Arafat Media", 480);  // Arguments must much with the constructor parameters
        v1.AddComment(new Comment("Brian", "This video made me hungry 😂"));      // The constructor for the comments class is a (_name and _text) format
        v1.AddComment(new Comment("Sarah", "Uganda food is elite!"));
        v1.AddComment(new Comment("Michael", "Amazing shots!"));
        videos.Add(v1);                                                        // Adding object to the videos list

        // VIDEO 2
        Video v2 = new Video("Learning C# in 10 Minutes", "CodeSchool", 600);
        v2.AddComment(new Comment("Alice", "Super helpful!"));
        v2.AddComment(new Comment("John", "Finally understood classes."));
        v2.AddComment(new Comment("Liam", "Saved this!"));
        v2.AddComment(new Comment("Ali", "Clear explanation"));
        videos.Add(v2);

        // VIDEO 3
        Video v3 = new Video("Kampala City Tour", "Travel Africa", 720);
        v3.AddComment(new Comment("Ken", "Beautiful city!"));
        v3.AddComment(new Comment("Joy", "I want to visit now."));
        v3.AddComment(new Comment("Sam", "Great narration"));
        videos.Add(v3);

        // Displaying all videos in the list
        foreach (Video vid in videos)
        {
            vid.Display();      // Using our display method from the video class
        }
    }
}
