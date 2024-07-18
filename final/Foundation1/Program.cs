using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Sunset Dreams";
        video1._length = "200";
        video1._author = "Alex Rivera";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Rylee Jett";
        video1Comment1._commentText = "The lyrics are amazing.";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Cam Emmerson";
        video1Comment2._commentText = "I love your music!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Courtney Ulyssa";
        video1Comment3._commentText = "Finally! I was hooked immediately when I heard the teaser.";

        Video video2 = new Video();
        video2._title = "Moonlit Night";
        video2._length = "245";
        video2._author = "Emily Grace";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Vito Trace";
        video2Comment1._commentText = "This is her best song!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Mary Beth";
        video2Comment2._commentText = "Excellent video!";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Tori Daria";
        video2Comment3._commentText = "I can never get tired of this song.";

        Video video3 = new Video();
        video3._title = "Rise and Shine";
        video3._length = "210";
        video3._author = "Michael Benson";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Amanda Jesse";
        video3Comment1._commentText = "Thank you so much for this song!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Louis Smith";
        video3Comment2._commentText = "Thank you!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Chris Low";
        video3Comment3._commentText = "You are one of my favorite artists!";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Manny Menning";
        video3Comment4._commentText = "Love this song!";

        //add comments to list for each video 
        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);

        //add each video to videosList 
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}