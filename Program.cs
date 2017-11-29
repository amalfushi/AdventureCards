using System;

namespace AdventureCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int five = 5;
            Boon b1 = new Boon("Bunnyknip", "Monster", "A Strange cross between a bunny and an aligator", 5);
            b1.onDefeat();
        }
    }
}
