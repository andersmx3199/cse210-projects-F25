using System;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video();
        video1._author = "ENTER NAME 1";
        video1._length = 25;
        video1._title = "ENTER TITLE 1";
        // Video 2
        Video video2 = new Video();
        video2._author = "ENTER NAME 2";
        video2._length = 300;
        video2._title = "ENTER TITLE 2";
        // Video 3
        Video video3 = new Video();
        video3._author = "ENTER NAME 3";
        video3._length = 118;
        video3._title = "ENTER TITLE 3";


        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();
    }
}