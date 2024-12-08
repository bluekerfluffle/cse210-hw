using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Canning for Beginners";
        video1._length = "1920";
        video1._author = "Mary Jane Watson ";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Rylee Brown";
        video1Comment1._commentText = "This is so helpful, Thank you.";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Cindy Green";
        video1Comment2._commentText = "What great tip you shared!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Lily Stevenson";
        video1Comment3._commentText = "Amazing demonstration! I can't wait to try!";

        Video video2 = new Video();
        video2._title = "Popular";
        video2._length = "456";
        video2._author = "Ariana Grande";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Dani B.";
        video2Comment1._commentText = "OMG AMAZING!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Makella M.";
        video2Comment2._commentText = "So glad I got to hear this!";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Austin M.";
        video2Comment3._commentText = "I loved the movie!";
        Video video3 = new Video();
        video3._title = "Minecradt";
        video3._length = "2900";
        video3._author = "Jaffa Cake";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Ben B.";
        video3Comment1._commentText = "Can't wait to try this in my world!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Braden B.";
        video3Comment2._commentText = "Fortnite is better!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Ryan Bellll";
        video3Comment3._commentText = "@Braden B. Fr bro";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Parker Dunn";
        video3Comment4._commentText = "I luv mincrafy.";

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