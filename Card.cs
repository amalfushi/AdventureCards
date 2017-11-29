namespace AdventureCards
{
    public class Card
    {
        public string type { get; set; }
        public string description { get; set; }
        public string name { get; set; }

        public Card(string name, string type, string description)
        {
            this.name = name;
            this.type = type;
            this.description = description;
        }
    }
}