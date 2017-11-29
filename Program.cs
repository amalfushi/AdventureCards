using System;

namespace AdventureCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // int five = 5;
            Player p1 = new Player("Frank");
            Bane b1 = new Bane("Bunnyknip", "Monster", "A Strange cross between a bunny and an aligator", 5);
            Bane b2 = new Bane("Cold", "Disease", "A Common Cold", 2);
            Bane b3 = new Bane("Chupacabra", "Disease", "A Common Cold", 3);
            b1.onDefeat();
            b2.onDefeat();
            b3.onDefeat();
        }
    }
}
