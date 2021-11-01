using System;

namespace toStringExa
{
    class Athlete: Object 
    // Klassen arver altid fra object, men normalt skriver vi det ikke eksplicit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Height { get; set; }

        // override: Jeg laver min egen version af den ToString metode der er i base klassen (Object)
        public override string ToString()
        {
            // return base.ToString();
            // FORKERT: Min ToString() kalder base-klassen (Object) ToString,
            // som producerer en uønsket string.
            
            //return ToString();
            // FORKERT: ToString kalder sig selv uden ende. Det ender med en stack overflow exception
            return Id + " " + Name + " " + Country + " " + Height;
        }
    }
}
