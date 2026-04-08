using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Street #1", "City #1", "State #1", "Country #1");
        Lecture lecture = new Lecture("Example Lecture", "This is a description of a lecture.", "1/1/2026", "1:00 PM", address1, "Bob Joe", 52);
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine(lecture.ShortDescription());

        Address address2 = new Address("Street #2", "City #2", "State #2", "Country #2");
        Reception reception = new Reception("Example Reception", "This is a description of a reception.", "2/2/26", "2:00 PM", address2, "rsvpemail@gmail.com");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine(reception.ShortDescription());

        Address address3 = new Address("Street #3", "City #3", "State #3", "Country #3");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Example Outdoor Gathering", "This is a description of a outdoor gathering.", "3/3/26", "3:00 PM", address3, "Tropical Cyclone");
        Console.WriteLine(outdoorGathering.StandardDetails());
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine(outdoorGathering.ShortDescription());
    }
}