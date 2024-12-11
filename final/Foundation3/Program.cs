using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("1544 Temple Square Avenue", "Salt Lake City", "UT", "86540", "USA");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("General Conference", "Church meeting for all members of the Church of Jesus Christ of Latter-Day Saints.", "October 1, 2024", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Church Leadership", 25000);


        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplaySomeDetails();
        Console.WriteLine();
        lecture.DisplayLectureDetails();


        Address address2 = new Address ("1200 Muskogee Dr", "Muskogee", "OK", "74403", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Ben", "Ben's Birthday Party", "November 6, 2024", "1:00 pm - 3:00 pm", $"{receptionAddress}", "Reception", "gdunn3@byui.edu");

        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplaySomeDetails();
        Console.WriteLine();
        reception.DisplayReceptionsDetails();


        Address address3 = new Address ("999 Ocean Highway", "Pensacola","FL", "33257", "USA");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Beach Volleyball and Hangout", "Fun activities at the beach.", "June 27, 2025", "1:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");

        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplaySomeDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}