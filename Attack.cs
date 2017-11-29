namespace AdventureCards
{
    public class Attack: Card
    {
        public int damage { get; set; }
        public string element { get; set; }

        public Attack(string name, string description, int damage, string element): base(name, "Attack", description)
        {
            this.damage = damage;
            this.element = element;
        }
    }
}