using System;

namespace AdventureCards
{
    public class Bane: Card
    {

        public delegate void onDefeat(Player player);
        public int health { get; set; }
        public Bane(string name, string type, string description, int health): base(name, type, description)
        {
            this.health = health;
            onDefeat = genericDefeat;
            switch (name)
            {
                case "Bunnyknip":
                    onDefeat = ()=> {System.Console.WriteLine("Bunnyknip leapt from the waters, but you were prepared!");};
                    break;
                case "Cold":
                    onDefeat = ()=> {System.Console.WriteLine("The coughing fits have subsided!");};
                    break;
                default:
                    break;
            };
        }

        private void genericDefeat(Player p){
            System.Console.WriteLine("{0} has been defeated", name);
            // return p;
        }
        
    }
}