using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("Avenida Agustin Balsamo", "Cadiz", "Algeciras", "105", "Spain");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Technology and Innovation Summit", "A conference focused on the latest advancements in technology and innovation.", "September 15, 2024", "09:00 am - 05:00 pm", $"{lectureAddress}", "Conference", "Dr. Steven Savarin", 500);

        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("Barrio La Bocaina", "Valencia", "Carabobo", "257-58", "Venezuela");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Anna and John's Celebration", "Celebration of Anna and John's anniversary", "October 14, 2024", "5:00 pm - 11:00 pm", $"{receptionAddress}", "Celebration", "anna.john@hotmail.com");
        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("Paradera", "Oranjestad", "Oranjestad", "2B", "Aruba");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Community Picnic", "A fun picnic day for families at the local park.", "August 10, 2024", "11:00 am", $"{outdoorAddress}", "Outdoor", "Partly Cloudy");
        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}