using System;

namespace AdventureCards
{
    public class Boon: Card
    {

        public Action onDefeat;
        public int health { get; set; }
        public Boon(string name, string type, string description, int health, Action defeat = null): base(name, type, description)
        {
            this.health = health;
            if(defeat == null)
            {
                this.onDefeat = ()=>{System.Console.WriteLine("{0} has been defeated", name);};
            } 
            else 
            {
                this.onDefeat = defeat;
            }
        }
    }
}