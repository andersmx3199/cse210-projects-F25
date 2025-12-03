using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("236 Street Ln.", "Hawkins", "IN", "USA");
        Address a2 = new Address("21 East Sycamore Ln.", "Chicago", "IL", "USA");
        Address a3 = new Address("16005 Happy Street", "Atlanta", "GA", "USA");

        LectureEvent l1 = new LectureEvent("Inspiring Young Minds","Join Dr. Brenner as we explore the capabilities of the young mind!","March 22nd","9:00am",a1,"Dr. Brenner",200,"Lecture Event");
        OutdoorEvent o1 = new OutdoorEvent("Kayaking across Lake Michigan","Not for the faint of heart.", "July 26th", "12:30pm", a2,"Rainy", "Outdoor Event");
        ReceptionEvent r1 = new ReceptionEvent("Wedding Reception","Celebrate with Mark and Frankie", "June 12th","6:00pm",a3,"randomemail42@email.com","Reception Event");

        Console.WriteLine("");
        Console.WriteLine("Lecture Event Information\n--------------------------------------------------------------");
        Console.WriteLine($"Standard:\n{l1.GetStandard()}\n");
        Console.WriteLine($"Short:\n{l1.GetShort()}\n");
        Console.WriteLine($"Full:\n{l1.GetFull()}\n");
        Console.WriteLine("");
        Console.WriteLine("Outdoor Event Information\n--------------------------------------------------------------");
        Console.WriteLine($"Standard:\n{o1.GetStandard()}\n");
        Console.WriteLine($"Short:\n{o1.GetShort()}\n");
        Console.WriteLine($"Full:\n{o1.GetFull()}\n");
        Console.WriteLine("");
        Console.WriteLine("Reception Event Information\n--------------------------------------------------------------");
        Console.WriteLine($"Standard:\n{r1.GetStandard()}\n");
        Console.WriteLine($"Short:\n{r1.GetShort()}\n");
        Console.WriteLine($"Full:\n{r1.GetFull()}\n");
    }
}