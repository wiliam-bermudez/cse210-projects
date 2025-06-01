using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Unboxing the Latest Smartphone", "TechGuru", 300);
        video1.AddComment(new Comment("Alice", "Great review!"));
        video1.AddComment(new Comment("Bob", "Can you test the camera in low light?"));
        video1.AddComment(new Comment("Charlie", "Nice editing!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Travel Destinations", "Wanderlust", 420);
        video2.AddComment(new Comment("Dave", "I want to visit them all!"));
        video2.AddComment(new Comment("Eve", "Thanks for the inspiration."));
        video2.AddComment(new Comment("Frank", "Amazing visuals."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to Cook Pasta", "ChefAnna", 180);
        video3.AddComment(new Comment("Grace", "Yummy!"));
        video3.AddComment(new Comment("Heidi", "Trying this tonight."));
        video3.AddComment(new Comment("Ivan", "Add some garlic for extra flavor!"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("How to Run Faster", "RunBrandon", 250);
        video4.AddComment(new Comment("Wiliam","I can be faster now!"));
        video4.AddComment(new Comment("Joshua","I needed this video"));
        video4.AddComment(new Comment("David","Great!"));
        videos.Add(video4);


        // Display all videos
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}