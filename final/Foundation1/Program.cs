using System;
// Last comment for final push
class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video();
        video1._author = "CrispCraft";
        video1._length = 360;
        video1._title = "Apple Crisp with Crisp Apples!";
        video1.AddComment(new Comment("PixelPanda42", "'I added this to my recipe list!'"));
        video1.AddComment(new Comment("CommentKing101", "'I could do that waaaay better!'"));
        video1.AddComment(new Comment("La-A", "'I like apples :) '"));
        // Video 2
        Video video2 = new Video();
        video2._author = "OutdoorAdventures";
        video2._length = 300;
        video2._title = "Join me on an adventure under Antarctica!";
        video2.AddComment(new Comment("SkylineFlier", "'Love these vids! Keep it up!'"));
        video2.AddComment(new Comment("Vibevoyager", "'You should go to the Moon next!!!'"));
        video2.AddComment(new Comment("RatherBeInSide", "'I don't understand how anyone find this fun...'"));
        // Video 3
        Video video3 = new Video();
        video3._author = "ProductReviewDude";
        video3._length = 118;
        video3._title = "Reviewing a new product";
        video3.AddComment(new Comment("RunningElephant", "'Love these reviews!'"));
        video3.AddComment(new Comment("KoiSupporter", "'Very vague title...'"));
        video3.AddComment(new Comment("FrostedCircuit", "'Isn't this what 5 star reviews are for???'"));

        // Display all the video information
        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();
    }
}