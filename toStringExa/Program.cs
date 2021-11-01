using System;

namespace toStringExa
{
    class Program
    {
        static void Main()
        {
            Athlete ath = new Athlete
            {
                Id = 1, Name = "Anders", Country = "DK", Height = 198
            };
            Console.WriteLine(ath.ToString());

            Object ath2 = new Athlete
            {
                Id = 2,
                Name = "Kurt",
                Country = "DK",
                Height = 168
            };
            Console.WriteLine(ath2.ToString());
            // Kalder Athlete.ToString()
            // Typen på ath2 (Object) bestemmer på compile-tid hvilke metoder vi må kalde (kun dem der er defineret i klassen Object)
            // På runtime bestemmer objektet (new Athlete) hvilke version af ToString metoden der kaldes.
            // Kaldes polymorfisme.
            // Keyword "override" på ToString er vigtigt - eller virker polymorfisme ikke.
        }
    }
}
